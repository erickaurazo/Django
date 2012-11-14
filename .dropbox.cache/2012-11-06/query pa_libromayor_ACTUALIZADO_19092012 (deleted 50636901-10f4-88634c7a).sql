---LIBRO MAYOR MODIFICADO 19 DE SEPTIEMBRE 2012, 10:AM
--drop procedure RPTLIBRO_MAYOR_SUNAT_SJ

altder PROCEDURE RPTLIBRO_MAYOR_SUNAT_SJ
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
				MMES 			nvarchar(02) default '',		-- (TABLE.CABCONTA)
				MNUMASIOPE		nvarchar(15)	default '',		-- COMPROBANTE O VOUCHER (TABLE.CABCONTA)
				MNUMCTACON		nvarchar(24) default '',		-- idcuenta (TABLE.DETCONTA)
				MFECOPE 		datetime default null,		-- fecha (TABLE.CABCONTA)
				MGLOSA			nvarchar(200) default '',	-- descripcion (TABLE.DETCONTA)
				MCENCOS			nvarchar(10) default '',		-- idccosto (TABLE.DETCONTA)
				MDEBE			numeric(17,2) default 0,	-- SUM DEBE (TABLE.DETCONTA)
				MHABER			numeric(17,2) default 0,	-- SUM HABER (TABLE.DETCONTA)
				MINTREG			nvarchar(20) default '',	-- idcabcon(TABLE.CABCONTA)
				MINTKARDEX		nvarchar(20) default '',	-- idcabcon(TABLE.CABCONTA)
				MINTVTACOM		nvarchar(20) default '',	-- idcabcon(TABLE.CABCONTA)
				MINTREG2		nvarchar(20) default '')		-- idcabcon(TABLE.CABCONTA)					
---Inserta Saldos
  --insert into #temp_mayor (PERIODO, MFECOPE, DMES, diario, NNUMCTACON, denominacion, DNUMASIOPE,MCENCOS, MGLOSA, MDEBE, MHABER, debemex,habermex, MINTREG)
	insert into #temp_mayor (DMES, DNUMASIOPE, DNUMCTACON, DFECOPE, DGLOSA, DCENCOS,DDEBE , DHABER,DINTREG ,DINTKARDEX,DINTVTACOM,DINTREG2  )
	select	MONTH(convert(datetime, @c_desde, 103)), '', d.idcuenta, convert(datetime,@c_desde, 103),
			'SALDO INICIAL', '' as idccosto,
				case when isnull(sum(isnull(d.cargo_mof,0)),0) - isnull(sum(isnull(d.abono_mof,0)),0)>0 
				then isnull(sum(isnull(d.cargo_mof,0)),0)- isnull(sum(isnull(d.abono_mof,0)),0)	else 0 end,				
				case when isnull(sum(isnull(d.cargo_mof,0)),0)- isnull(sum(isnull(d.abono_mof,0)),0)<0
				then isnull(sum(isnull(d.abono_mof,0)),0)- isnull(sum(isnull(d.cargo_mof,0)),0)	else 0 end,				
				'' ,'' , '' , '' 	
	from cabconta c
		inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
		inner join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
	where c.idempresa=@c_emp  and c.idestado <> 'AN'  and 
	 	(convert(char(8), c.fecha, 112) < @c_desde  or  (convert(char(8), c.fecha, 112) between @c_desde and @c_hasta and c.idsubdiario = @apertura))
		and  d.idcuenta between rtrim(@c_cuenta1)  and  rtrim(@c_cuenta2)	 
	group by d.idcuenta
	order by d.idcuenta

	insert into #temp_mayor (MMES, MNUMASIOPE, MNUMCTACON, MFECOPE, MGLOSA, MCENCOS,MDEBE , MHABER,MINTREG ,MINTKARDEX,MINTVTACOM,MINTREG2 )
	select	month(c.Fecha) , c.voucher, d.idcuenta, c.fecha,	
			case c.idestado when 'AN' then '*** ANULADO ***' else isnull(RTRIM(d.glosa), isnull(RTRIM(d.glosa),p.descripcion)) end,				
			d.idccosto,	
			debe = case c.idestado when 'AN' then 0 else case @c_mon when 'N' then d.cargo_mof else d.cargo_mex end end,
			haber = case c.idestado when 'AN' then 0 else  case @c_mon when 'N' then d.abono_mof else d.abono_mex end end,			
			c.IdCabConta, c.IdCabConta, c.IdCabConta, ''																											
	from	cabconta c
			inner join detconta d on c.idcabconta = d.idcabconta and c.idempresa = d.idempresa
			inner join planctas p on d.idcuenta = p.idcuenta and d.idempresa = p.idempresa
			inner join subdiario s on c.idsubdiario = s.idsubdiario and c.idempresa = s.idempresa
	where	c.idempresa=@c_emp and c.idestado <> 'AN'
	and c.idsubdiario <> @apertura 
	and d.idcuenta between @c_cuenta1 and @c_cuenta2
	and	c.periodo  between left(@c_desde,6) and left(@c_hasta,6)
	order by d.idcuenta						
	select * from #temp_mayor where (MDEBE+MHABER)<>0	
	
	select sum(MDEbe)as debe, sum(Mhaber) from #temp_mayor
End
GO

exec RPTLIBRO_MAYOR_SUNAT_SJ '001','10','9779914 ','20100101','20100131','N'