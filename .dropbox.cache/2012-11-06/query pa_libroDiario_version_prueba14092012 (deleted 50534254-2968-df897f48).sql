alter  PROCEDURE RPTLIBRO_DIARIO_SUNAT_PRUEBA
	@c_emp char (3),		-- código de la empresa
	@c_desde char (8),		-- desde (yyyymmdd)
	@c_hasta char (8),		-- hasta (yyyymmdd)
	@c_mon char(1),			-- tipo moneda 'N'acional o 'E'xtranjera
	@c_tipo char(1),		-- (N]ormal o (S)implificado
	@c_grupo char(1)		-- [F]echa o [P]eriodo
AS
declare
		@apertura	char(3)
Begin
	SELECT @APERTURA = RTRIM(VALOR) FROM PEMPRESA WHERE PARAMETRO ='SUB_APERTU' AND IDEMPRESA=@C_EMP

	if @c_tipo = 'N'
	Begin
		create table #temp (	
					dmes			char(2),
					tipo			varchar(20),
					codigo_libro	char(2),
					DNUMASIOPE		char(10),
					operacion		varchar(20) default '',
					DFECOPE 		datetime default null,
					descripcion		varchar(200) default '',
					dcencos			varchar(30) default '',
					DNUMCTACON		varchar(12) default '',
					DGLOSA			varchar(200) default '',
					Ddebe			numeric(17,2) default 0,
					Dhaber			numeric(17,2) default 0,
					DINTREG			varchar(15) default '',
					ventana			varchar(100) default '',
					doc_origen      varchar(20) default '')
					

		insert into #temp (DMES,tipo, codigo_libro,DFECOPE, descripcion,dcencos ,DNUMCTACON, DGLOSA,Ddebe, Dhaber)
		select 	'01','[1] APERTURA', '' , convert(datetime, @c_desde, 103), 'SALDO INICIAL','' ,d.idcuenta, p.descripcion as denominacion,  
			CASE WHEN @C_MON='N' THEN
				CASE when SUM(ISNULL(d.cargo_mof,0) - ISNULL(d.abono_mof,0)) >0 THEN abs(SUM(ISNULL(d.cargo_mof,0) - ISNULL(d.abono_mof,0))) else 0 end 
			ELSE
				CASE when SUM(ISNULL(d.cargo_mex,0) - ISNULL(d.abono_mex,0)) >0 THEN abs(SUM(ISNULL(d.cargo_mex,0) - ISNULL(d.abono_mex,0))) else 0 end 
			END	AS debe,
			CASE WHEN @C_MON='N' THEN
				CASE when SUM(ISNULL(d.cargo_mof,0) - ISNULL(d.abono_mof,0)) <0 THEN abs(SUM(ISNULL(d.abono_mof,0) - ISNULL(d.cargo_mof,0))) else 0 end 
			ELSE
				CASE when SUM(ISNULL(d.cargo_mex,0) - ISNULL(d.abono_mex,0)) <0 THEN abs(SUM(ISNULL(d.abono_mex,0) - ISNULL(d.cargo_mex,0))) else 0 end 
			END AS haber			
		from cabconta c
		inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
		left join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
		where (c.periodo<left(@c_desde,6) OR (periodo between left(@c_desde,6) and (left(@c_hasta,6)) and c.idsubdiario=@apertura)) and c.idempresa=@c_emp and c.idestado <> 'AN'
		group by d.idcuenta, p.descripcion
		order by d.idcuenta

		insert into #temp
		select 	month(c.fecha) ,case isnull(s.para_ajuste,0) when 0 then '[2] OPERAC.MES' else '[4] AJUSTES MES' end, s.codigo_rtps,c.voucher,c.idsubdiario+'-'+c.voucher operacion, c.fecha, 
			case c.idestado when 'AN' then '*** ANULADO ***' else isnull(d.glosa, isnull(c.glosa,'')) end,d.idccosto,d.idcuenta, p.descripcion as denominacion, 
			Ddebe = case c.idestado when 'AN' then 0 else case @c_mon when 'N' then d.cargo_mof else d.cargo_mex end end,
			Dhaber = case c.idestado when 'AN' then 0 else case @c_mon when 'N' then d.abono_mof else d.abono_mex end end,
			c.idcabconta, c.ventana, d.iddocumento+' '+d.serie+'-'+d.numero
		from cabconta c
		inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
		inner join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
		inner join subdiario s on c.idsubdiario = s.idsubdiario and c.idempresa = s.idempresa
		where c.idempresa=@c_emp and c.idsubdiario <> @apertura and convert(char(8), c.fecha, 112) between @c_desde and @c_hasta   



--////
		update #temp 
		set codigo_libro = ' '
		where codigo_libro is null
		
		
		update #temp 
		set DNUMASIOPE = ' '
		where DNUMASIOPE is null
		
		
		update #temp 
		set dcencos = ' '
		where dcencos is null
		
		update #temp 
		set ventana = ' '
		where ventana is null
		
		update #temp 
		set doc_origen = ' '
		where doc_origen is null



--////



		select * from #temp where Ddebe<>0 or Dhaber<>0 order by 1, 2
		

	End
	Else
	Begin
		if @c_grupo = 'P'
			select 	convert(char(6), c.fecha, 112) as periodo, s.descripcion,
				tot10 = abs(sum(case left(d.idcuenta,2) when '10' then (cargo_mof - abono_mof) else 0 end)),
				tot12 = abs(sum(case left(d.idcuenta,2) when '12' then (cargo_mof - abono_mof) else 0 end)),
				tot16 = abs(sum(case left(d.idcuenta,2) when '16' then (cargo_mof - abono_mof) else 0 end)),
				tot20 = abs(sum(case left(d.idcuenta,2) when '20' then (cargo_mof - abono_mof) else 0 end)),
				tot21 = abs(sum(case left(d.idcuenta,2) when '21' then (cargo_mof - abono_mof) else 0 end)),
				tot33 = abs(sum(case left(d.idcuenta,2) when '33' then (cargo_mof - abono_mof) else 0 end)),
				tot34 = abs(sum(case left(d.idcuenta,2) when '34' then (cargo_mof - abono_mof) else 0 end)),
				tot38 = abs(sum(case left(d.idcuenta,2) when '38' then (cargo_mof - abono_mof) else 0 end)),
				tot39 = abs(sum(case left(d.idcuenta,2) when '39' then (cargo_mof - abono_mof) else 0 end)),
				tot42 = abs(sum(case left(d.idcuenta,2) when '42' then (cargo_mof - abono_mof) else 0 end)),
				tot46 = abs(sum(case left(d.idcuenta,2) when '46' then (cargo_mof - abono_mof) else 0 end)),
				tot50 = abs(sum(case left(d.idcuenta,2) when '50' then (cargo_mof - abono_mof) else 0 end)),
				tot58 = abs(sum(case left(d.idcuenta,2) when '58' then (cargo_mof - abono_mof) else 0 end)),
				tot59 = abs(sum(case left(d.idcuenta,2) when '59' then (cargo_mof - abono_mof) else 0 end)),
				tot60 = abs(sum(case left(d.idcuenta,2) when '60' then (cargo_mof - abono_mof) else 0 end)),
				tot61 = abs(sum(case left(d.idcuenta,2) when '61' then (cargo_mof - abono_mof) else 0 end)),
				tot62 = abs(sum(case left(d.idcuenta,2) when '62' then (cargo_mof - abono_mof) else 0 end)),
				tot63 = abs(sum(case left(d.idcuenta,2) when '63' then (cargo_mof - abono_mof) else 0 end)),
				tot64 = abs(sum(case left(d.idcuenta,2) when '64' then (cargo_mof - abono_mof) else 0 end)),
				tot65 = abs(sum(case left(d.idcuenta,2) when '65' then (cargo_mof - abono_mof) else 0 end)),
				tot66 = abs(sum(case left(d.idcuenta,2) when '66' then (cargo_mof - abono_mof) else 0 end)),
				tot67 = abs(sum(case left(d.idcuenta,2) when '67' then (cargo_mof - abono_mof) else 0 end)),
				tot68 = abs(sum(case left(d.idcuenta,2) when '68' then (cargo_mof - abono_mof) else 0 end)),
				tot69 = abs(sum(case left(d.idcuenta,2) when '69' then (cargo_mof - abono_mof) else 0 end)),
				tot70 = abs(sum(case left(d.idcuenta,2) when '70' then (cargo_mof - abono_mof) else 0 end)),
				tot75 = abs(sum(case left(d.idcuenta,2) when '75' then (cargo_mof - abono_mof) else 0 end)),
				tot76 = abs(sum(case left(d.idcuenta,2) when '76' then (cargo_mof - abono_mof) else 0 end)),
				tot77 = abs(sum(case left(d.idcuenta,2) when '77' then (cargo_mof - abono_mof) else 0 end)),
				tot79 = abs(sum(case left(d.idcuenta,2) when '79' then (cargo_mof - abono_mof) else 0 end))
			from cabconta c
			inner join detconta d on d.idcabconta = c.idcabconta and d.idempresa = c.idempresa
			inner join subdiario s on c.idsubdiario = s.idsubdiario and c.idempresa = s.idempresa
			where c.idempresa=@c_emp and c.idestado<>'AN' and convert(char(6), c.fecha, 112) between @c_desde and @c_hasta  
			group by convert(char(6), c.fecha, 112), s.descripcion
		Else
			select convert(char(10), c.fecha, 103) as periodo, s.descripcion, 
				tot10 = (sum(case left(d.idcuenta,2) when '10' then (cargo_mof - abono_mof) else 0 end)),
				tot12 = (sum(case left(d.idcuenta,2) when '12' then (cargo_mof - abono_mof) else 0 end)),
				tot16 = (sum(case left(d.idcuenta,2) when '16' then (cargo_mof - abono_mof) else 0 end)),
				tot20 = (sum(case left(d.idcuenta,2) when '20' then (cargo_mof - abono_mof) else 0 end)),
				tot21 = (sum(case left(d.idcuenta,2) when '21' then (cargo_mof - abono_mof) else 0 end)),
				tot33 = (sum(case left(d.idcuenta,2) when '33' then (cargo_mof - abono_mof) else 0 end)),
				tot34 = (sum(case left(d.idcuenta,2) when '34' then (cargo_mof - abono_mof) else 0 end)),
				tot38 = (sum(case left(d.idcuenta,2) when '38' then (cargo_mof - abono_mof) else 0 end)),
				tot39 = (sum(case left(d.idcuenta,2) when '39' then (cargo_mof - abono_mof) else 0 end)),
				tot42 = (sum(case left(d.idcuenta,2) when '42' then (cargo_mof - abono_mof) else 0 end)),
				tot46 = (sum(case left(d.idcuenta,2) when '46' then (cargo_mof - abono_mof) else 0 end)),
				tot50 = (sum(case left(d.idcuenta,2) when '50' then (cargo_mof - abono_mof) else 0 end)),
				tot58 = (sum(case left(d.idcuenta,2) when '58' then (cargo_mof - abono_mof) else 0 end)),
				tot59 = (sum(case left(d.idcuenta,2) when '59' then (cargo_mof - abono_mof) else 0 end)),
				tot60 = (sum(case left(d.idcuenta,2) when '60' then (cargo_mof - abono_mof) else 0 end)),
				tot61 = (sum(case left(d.idcuenta,2) when '61' then (cargo_mof - abono_mof) else 0 end)),
				tot62 = (sum(case left(d.idcuenta,2) when '62' then (cargo_mof - abono_mof) else 0 end)),
				tot63 = (sum(case left(d.idcuenta,2) when '63' then (cargo_mof - abono_mof) else 0 end)),
				tot64 = (sum(case left(d.idcuenta,2) when '64' then (cargo_mof - abono_mof) else 0 end)),
				tot65 = (sum(case left(d.idcuenta,2) when '65' then (cargo_mof - abono_mof) else 0 end)),
				tot66 = (sum(case left(d.idcuenta,2) when '66' then (cargo_mof - abono_mof) else 0 end)),
				tot67 = (sum(case left(d.idcuenta,2) when '67' then (cargo_mof - abono_mof) else 0 end)),
				tot68 = (sum(case left(d.idcuenta,2) when '68' then (cargo_mof - abono_mof) else 0 end)),
				tot69 = (sum(case left(d.idcuenta,2) when '69' then (cargo_mof - abono_mof) else 0 end)),
				tot70 = (sum(case left(d.idcuenta,2) when '70' then (cargo_mof - abono_mof) else 0 end)),
				tot75 = (sum(case left(d.idcuenta,2) when '75' then (cargo_mof - abono_mof) else 0 end)),
				tot76 = (sum(case left(d.idcuenta,2) when '76' then (cargo_mof - abono_mof) else 0 end)),
				tot77 = (sum(case left(d.idcuenta,2) when '77' then (cargo_mof - abono_mof) else 0 end)),
				tot79 = (sum(case left(d.idcuenta,2) when '79' then (cargo_mof - abono_mof) else 0 end))
			from cabconta c
			inner join detconta d on d.idcabconta = c.idcabconta and d.idempresa = c.idempresa
			inner join subdiario s on c.idsubdiario = s.idsubdiario and c.idempresa = s.idempresa
			where c.idempresa=@c_emp  and c.idestado<>'AN' and convert(char(8), c.fecha, 112) between @c_desde and @c_hasta   
			group by convert(char(10), c.fecha, 103), s.descripcion
	End
End
GO



--exec RPTLIBRO_DIARIO_SUNAT_PRUEBA '001', '20100101', '20100131', 'N', 'N', 'F'