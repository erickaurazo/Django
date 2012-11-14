
---- Buscar valores que se encuentren dentro del criterio del numero de cuenta
create procedure pa_listarPlandeCuentasxCuenta
@cuenta nvarchar(20)
as
select idcuenta, descripcion from PLANCTAS
where idcuenta like '%' + @cuenta + '%' 
--exec pa_listarPlandeCuentasxCuenta '101'





--- buscar cuenta exacta
alter procedure pa_listarPlandeCuentasxCuentaExacta
@cuenta nvarchar(20)
as
select idcuenta, descripcion from PLANCTAS
where idcuenta = @cuenta




--exec pa_listarPlandeCuentasxCuentaExacta '10'
---- Buscar valores que se encuentren dentro del criterio del nombre/descripci{on de cuenta
create procedure pa_listarPlandeCuentasxDescripcion
@Descripcion nvarchar (200)
as
select idcuenta, descripcion from PLANCTAS
where descripcion like '%' + @Descripcion + '%' 





----- LISTAR EL PRIMER Y ULTIMA CUENTA VIGENTE
--exec pa_listarPlandeCuentasxCuentaDescripcion '102',''


and descripcion like '%' + @Descripcion + '%'

alter procedure pa_listarCuentaMinimaMaxima
as
select idcuenta, descripcion  from PLANCTAS
where idcuenta = (select min(idcuenta) from PLANCTAs)
union
select idcuenta, descripcion  from PLANCTAS
where idcuenta = (select max(idcuenta) from PLANCTAs)
go

--exec pa_listarCuentaMinimaMaxima











