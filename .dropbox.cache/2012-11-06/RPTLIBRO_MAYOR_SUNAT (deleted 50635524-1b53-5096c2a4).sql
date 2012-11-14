
-- exec RPTLIBRO_MAYOR_SUNAT '001','10','9779914 ','20100101','20100131','N'
-- exec RPTLIBRO_MAYOR '001','10','9779914 ','20100101','20100131','N'

-- F.CREACION : 15/05/2011
-- F.ACTULIZA : 15/05/2011

ALTER PROCEDURE RPTLIBRO_MAYOR_SUNAT
	@c_emp char (3),		-- código de la empresa
	@c_cuenta1 varchar (12),	-- desde la cuenta
	@c_cuenta2 varchar (12),	-- hasta la cuenta
	@c_desde char (8),		-- desde (yyyymmdd)
	@c_hasta char (8),		-- hasta (yyyymmdd)
	@c_mon char(1)			-- tipo moneda 'N'acional o 'E'xtranjera

AS
declare
		@apertura	char(3),
		@comparar   char(12)
		
Begin
	SELECT @APERTURA = RTRIM(VALOR) FROM PEMPRESA WHERE PARAMETRO ='SUB_APERTU' AND IDEMPRESA=@C_EMP
	PRINT @APERTURA
	PRINT @c_cuenta1
	select @c_cuenta2 = case when len(rtrim(@c_cuenta2)) =0 then '' else rtrim(@c_cuenta2) + '9' end
	PRINT @c_cuenta2
	
	
	create table #temp_mayor (
				PERIODO         varchar(20) default '',
				MFECOPE 		datetime default null, --fecha
				DMES 			varchar(20) default '',
				diario			varchar(10)	default '',
				NNUMCTACON		varchar(12) default '',  -- idcuenta
				denominacion	varchar(100) default '', 
				DNUMASIOPE		varchar(20)	default '',  -- COMPROBANTE
				documento		varchar(25)	default '',
				MCENCOS			varchar(15) default '',  -- idccosto
				operacion		varchar(35)	default '',
				MGLOSA			varchar(200) default '', -- descripcion
				MDEBE			numeric(17,2) default 0, -- 
				MHABER			numeric(17,2) default 0,
				debemex			numeric(17,2) default 0,
				habermex		numeric(17,2) default 0,
				idorigen		varchar(15) default '',
				ventana			varchar(100) default '',
				MINTREG			varchar(20) default '')
		

/*Modificacion por ejcc*/
/* se agrego los null en los cargos y abonos para evitar si viente algun null exista uan eliminacion de fila*/
/* adicionalmente se reestructuro el between de las cuentas*/
/* y por ultimo el orden logico de los parentesiss de la condicion OR*/
	--if(LEN(@c_cuenta1)>LEN(@c_cuenta2))
	--	begin
	--		set @comparar=@c_cuenta2
	--	end
	--else
	--	begin
	--		set @comparar=@c_cuenta1
	--	end

---Inserta Saldos

	insert into #temp_mayor (PERIODO, MFECOPE, DMES, diario, NNUMCTACON, denominacion, DNUMASIOPE, 
							 MCENCOS, MGLOSA, MDEBE, MHABER, debemex,habermex, MINTREG)
	select	'201001', convert(datetime, @c_desde, 103) as fecha,  MONTH(convert(datetime, @c_desde, 103)) as DMES, 
			'' as idsubdiario, d.idcuenta,'' as denominacion,
			'' as comprobante,
			'' as idccosto, 'SALDO INICIAL',
				
				case when isnull(sum(isnull(d.cargo_mof,0)),0) - isnull(sum(isnull(d.abono_mof,0)),0)>0 
				then isnull(sum(isnull(d.cargo_mof,0)),0)- isnull(sum(isnull(d.abono_mof,0)),0)	else 0 end,
				
				case when isnull(sum(isnull(d.cargo_mof,0)),0)- isnull(sum(isnull(d.abono_mof,0)),0)<0
				then isnull(sum(isnull(d.abono_mof,0)),0)- isnull(sum(isnull(d.cargo_mof,0)),0)	else 0 end,
				
				case when isnull(sum(isnull(d.cargo_mex,0)),0)- isnull(sum(isnull(d.abono_mex,0)),0)>0
				then isnull(sum(isnull(d.cargo_mex,0)),0)- isnull(sum(isnull(d.abono_mex,0)),0)	else 0 end,
				
				case when isnull(sum(isnull(d.cargo_mex,0)),0)- isnull(sum(isnull(d.abono_mex,0)),0)<0
				then isnull(sum(isnull(d.abono_mex,0)),0)- isnull(sum(isnull(d.cargo_mex,0)),0)	else 0 end,
			'' as IdCabConta

	from cabconta c
		inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
		inner join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
	where c.idempresa=@c_emp  and c.idestado <> 'AN'  and 
	 	(convert(char(8), c.fecha, 112) < @c_desde  or  (convert(char(8), c.fecha, 112) between @c_desde and @c_hasta and c.idsubdiario = @apertura))
		and  d.idcuenta between rtrim(@c_cuenta1)  and  rtrim(@c_cuenta2)	 
	group by d.idcuenta
	order by d.idcuenta
	

/*se agrego la condicion de que no sea anulado*/
/* se ordeno la sentencia de las cuentas*/
/* se ordeno la sentencia del bewteen */
---Inserta Movimientos

	insert into #temp_mayor(PERIODO, MFECOPE, DMES, diario, NNUMCTACON, denominacion, DNUMASIOPE,documento,
							MCENCOS, operacion, MGLOSA, MDEBE, MHABER,
							debemex,habermex,idorigen,ventana, MINTREG)
							
	select 	C.PERIODO, c.fecha, day(c.Fecha) as DMES, c.idsubdiario, d.idcuenta, p.descripcion as denominacion, c.voucher,
		d.iddocumento+' '+d.serie+' - '+ d.numero,d.idccosto,
			case c.tablaorigen 
				when 'COBRARPAGARDOC' then (select TOP 1  p.idOperacion+' '+p.numOperacion  from COBRARPAGARDOC p where p.idEmpresa=c.idempresa and p.idcobrarpagardoc=c.idorigen)
				when 'INGRESOSALIDAALM'	then (select TOP 1  o.idOperacion+' '+o.numOperacion from INGRESOSALIDAALM o where o.idEmpresa=c.idempresa and o.IDINGRESOSALIDAALM=c.idorigen)
				when 'BAJAACTIVOS'	then (select TOP 1  q.idOperacion+' '+q.numOperacion from BAJAACTIVOS q where q.idEmpresa=c.idempresa and q.IDBAJAACTIVO=c.idorigen)
				when 'TRANSACTIVOS'	then (select TOP 1  r.idOperacion+' '+r.numOperacion from TRANSACTIVOS r where r.idEmpresa=c.idempresa and r.idtransactivo=c.idorigen)
				when 'MOVIMIENTO_PLANILLA' then (select TOP 1  s.idOperacion+' '+s.numOperacion from MOVIMIENTO_PLANILLA s where s.idEmpresa=c.idempresa and s.IDMOVIMIENTO=c.idorigen)
				when 'INGRESOEGRESOCABA' then (select TOP 1  t.idOperacion+' '+t.numOperacion from INGRESOEGRESOCABA t where t.idEmpresa=c.idempresa and t.IDINGRESOEGRESOCABA=c.idorigen)
				when 'DEPRECACTIVO'	then (select TOP 1  w.idOperacion+' '+w.numOperacion from DEPRECACTIVO w where w.idEmpresa=c.idempresa and w.IDDEPRECACTIVO=c.idorigen)
				else 'Diario-Aplicacion' end as operacion, 
			case c.idestado when 'AN' then '*** ANULADO ***' else isnull(d.glosa, isnull(c.glosa,p.descripcion)) end, 
			debe = case c.idestado when 'AN' then 0 else case @c_mon when 'N' then d.cargo_mof else d.cargo_mex end end,
			haber = case c.idestado when 'AN' then 0 else  case @c_mon when 'N' then d.abono_mof else d.abono_mex end end,
			debemex=case c.idestado when 'AN' then 0 else d.cargo_mex end,
			habermex=case c.idestado when 'AN' then 0 else  d.abono_mex end,
			c.idcabconta, c.ventana,
			c.IdCabConta
	from	cabconta c
			inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
			inner join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
			inner join subdiario s on c.idsubdiario = s.idsubdiario and c.idempresa = s.idempresa
	where	c.idempresa=@c_emp and c.idestado <> 'AN'
	and c.idsubdiario <> @apertura 
	and d.idcuenta between @c_cuenta1 and @c_cuenta2
	and	c.periodo  between left(@c_desde,6) and left(@c_hasta,6)
	order by d.idcuenta		
				
	update 	#temp_mayor set ventana='edt_cabconta' where ventana is null 

	--select * from #temp where (debe<>0 or haber<>0)  order by 1, 2
	--select SUM(debe) debe,SUM(haber) haber,SUM(debemex) debemex,SUM(habermex) habermex from #temp

	select * from #temp_mayor where (MDEBE+MHABER+debemex+habermex)<>0
	
End


GO


