alter procedure pa_insertarStandar
@IdEstandar int output,
@IdArea	char(2),
@HorasTrabajadas decimal(17,2),	
@Estandar	decimal(17,2),	
@EstandarExtra	decimal(17,2),	
@Jornal	decimal(17,2),	
@PrecioUnitario	decimal(17,2),	
@PrecioUnitarioExtra	decimal(17,2),	
@UserDecimal01	decimal(17,2),	
@UserVarchar01	nvarchar(200),	
@FechaInicio	datetime,	
@FechaFinal	datetime,	
@IdFormato	char(2),	
@EstandarPorcentajePrimerDia decimal(17,2),	
@EstandarPorcentajeSegundoDia decimal(17,2),	
@EstandarPrimerDia	decimal(17,2),	
@EstandarSegundoDia	decimal(17,2),	
@PrecioPrimerDia	decimal(17,6),	
@PrecioSegundoDia	decimal(17,6)	
as
insert into SJ_Estandar
(IdArea,	
HorasTrabajadas	,
Estandar	,
EstandarExtra,	
Jornal	,
PrecioUnitario	,
PrecioUnitarioExtra	,
UserDecimal01	,
UserVarchar01	,
FechaInicio	,
FechaFinal	,
IdFormato	,
EstandarPorcentajePrimerDia,
EstandarPorcentajeSegundoDia,
EstandarPrimerDia	,
EstandarSegundoDia	,
PrecioPrimerDia	,
PrecioSegundoDia)
values
(
@IdArea	,
@HorasTrabajadas	,
@Estandar	,
@EstandarExtra	,
@Jornal	,
@PrecioUnitario	,
@PrecioUnitarioExtra	,
@UserDecimal01	,
@UserVarchar01	,
@FechaInicio	,
@FechaFinal	,
@IdFormato	,
@EstandarPorcentajePrimerDia,
@EstandarPorcentajeSegundoDia,
@EstandarPrimerDia	,
@EstandarSegundoDia	,
@PrecioPrimerDia,	
@PrecioSegundoDia)
set @IdEstandar = scope_identity()
go




select * from SJ_Estandar



exec pa_insertarStandar 
'',
'04',	
8.40,	
210.00,	
210.00,	
26.340000,
0.119727,
0.120000,
0.000000,
's',
'2012-10-02',
'2012-10-02',
'45',
75.00,
90.00,
165.00,	
198.00,	
0.159636,
0.133030


--el jornal lo saco del jornalbase, dependiendo de la fecha.

select * from sj_jornalBase

de aca saco el idarea

alter procedure pa_listarAreadeProceso
as
select idarea, descripcion from  SJ_AreaGeneral
where idarea < 5
go

exec pa_listarAreadeProceso