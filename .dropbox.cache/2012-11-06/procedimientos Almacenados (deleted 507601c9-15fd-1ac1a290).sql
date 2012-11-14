-- PA 01 - LISTAR AREAS DE PROCESO
--use BdSanJuanEficienciaPlanta
-- prodecimiento para mostrar las cuatro área de proceso

alter procedure pa_listarAreadeProceso
as
select idarea, descripcion from SJ_AreaGeneral
where idarea < 5
go

--exec pa_listarAreadeProceso

-- PA 02 -- LISTAR STANDARES
-- procedimiento almacenado para listar los standares
--create procedure pa_listarStandares
--modificado 10-10-2012, agregar column idarea y idformato
alter PROCEDURE pa_listarEstandares
as
select ES.IdEstandar, AG.Descripcion as oArea, ES.HorasTrabajadas, ES.Estandar, ES.EstandarExtra,ES.Jornal,
ES.PrecioUnitario, ES.PrecioUnitarioExtra, ES.UserDecimal01, ES.UserVarchar01, ES.FechaInicio,
ES.FechaFinal, F.Descripcion as oFormato, ES.EstandarPorcentajePrimerDia, ES.EstandarPorcentajeSegundoDia, 
ES.EstandarPrimerDia, ES.EstandarSegundoDia, ES.PrecioPrimerDia, ES.PrecioSegundoDia, ES.IdArea, ES.IdFormato from 
SJ_Estandar ES inner join SJ_AreaGeneral AG on
ES.IdArea=AG.IdArea
INNER JOIN SJ_Formato F ON
ES.IdFormato=F.IdFormato
order by IdEstandar desc


--exec pa_listarEstandares

--PA 03 -- INSERTAR STANDARES
--procedimiento almacenado para registrar los standares
alter procedure pa_insertarStandar
@IdEstandar int output,
@IdArea	char(2),
@HorasTrabajadas decimal(17,2),	
@Estandar	decimal(17,6),	
@EstandarExtra	decimal(17,6),	
@Jornal	decimal(17,6),	
@PrecioUnitario	decimal(17,6),	
@PrecioUnitarioExtra	decimal(17,6),	
@UserDecimal01	decimal(17,6),	
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
-----
-----





--PA 04 -- INSERTAR STANDARES
--procedimiento almacenado para registrar los standares
alter procedure pa_actualizarStandar
@IdEstandar int,
@IdArea	char(2),
@HorasTrabajadas decimal(17,2),	
@Estandar	decimal(17,6),	
@EstandarExtra	decimal(17,6),	
@Jornal	decimal(17,6),	
@PrecioUnitario	decimal(17,6),	
@PrecioUnitarioExtra	decimal(17,6),	
@UserDecimal01	decimal(17,6),	
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
update SJ_Estandar
set IdArea = @IdArea,
HorasTrabajadas	= @HorasTrabajadas,
Estandar = @Estandar,
EstandarExtra = @EstandarExtra,	
Jornal=@Jornal,
PrecioUnitario = @PrecioUnitario,
PrecioUnitarioExtra = @PrecioUnitarioExtra,
UserDecimal01 = @UserDecimal01,
UserVarchar01 = @UserVarchar01,
FechaInicio = @FechaInicio,
FechaFinal = @FechaFinal,
IdFormato = @IdFormato,
EstandarPorcentajePrimerDia = @EstandarPorcentajePrimerDia,
EstandarPorcentajeSegundoDia = @EstandarPorcentajeSegundoDia,
EstandarPrimerDia = @EstandarPrimerDia,
EstandarSegundoDia = @EstandarSegundoDia,
PrecioPrimerDia = @PrecioPrimerDia,
PrecioSegundoDia = @PrecioSegundoDia
where IdEstandar = @IdEstandar

--PA 05 -- selecionar el jornal basico
--procedimiento almacenado para registrar los standares
alter procedure pa_selecionarJornalBase
as
select top 1 JornalBasico from SJ_JornalBase
order by ID desc

--exec pa_selecionarJornalBase

--PA 06 -- selecionar el formato
--procedimiento almacenado para listar los formatos
alter procedure pa_listarFormatos
as
select * from sj_formato
order by idFormato asc


--PA 07 -- Validar la duplicidad del Estandar
--procedimiento almacenado para listar los formatos
alter procedure pa_verificarStandar
@idarea char(2),
@fechainico datetime
as
select IdArea from SJ_Estandar 
where IdArea = @idarea and month(FechaInicio)= month(@fechainico) and year(FechaInicio)= year(@fechainico) and day(FechaInicio)= day(@fechainico)

--pa_verificarStandar '01', '2012-10-09'



--PA 08 -- Limpiar Listado del Estandar
--procedimiento almacenado para listar los formatos en blanco
create PROCEDURE pa_limpiarEstandares
as
select ES.IdEstandar, AG.Descripcion as oArea, ES.HorasTrabajadas, ES.Estandar, ES.EstandarExtra,ES.Jornal,
ES.PrecioUnitario, ES.PrecioUnitarioExtra, ES.UserDecimal01, ES.UserVarchar01, ES.FechaInicio,
ES.FechaFinal, F.Descripcion as oFormato, ES.EstandarPorcentajePrimerDia, ES.EstandarPorcentajeSegundoDia, 
ES.EstandarPrimerDia, ES.EstandarSegundoDia, ES.PrecioPrimerDia, ES.PrecioSegundoDia, ES.IdArea, ES.IdFormato from 
SJ_Estandar ES inner join SJ_AreaGeneral AG on
ES.IdArea=AG.IdArea
INNER JOIN SJ_Formato F ON
ES.IdFormato=F.IdFormato and year(ES.FechaInicio)>5000
order by IdEstandar desc