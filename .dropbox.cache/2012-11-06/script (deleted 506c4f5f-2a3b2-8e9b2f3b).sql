USE [master]
GO
/****** Object:  Database [BdSanJuanEficienciaPlanta]    Script Date: 10/03/2012 09:44:44 ******/
CREATE DATABASE [BdSanJuanEficienciaPlanta] ON  PRIMARY 
( NAME = N'BdSanJuanPlanta', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BdSanJuanEficienciaPlanta.mdf' , SIZE = 214016KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BdSanJuanPlanta_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\BdSanJuanEficienciaPlanta.ldf' , SIZE = 1008000KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BdSanJuanEficienciaPlanta].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ANSI_NULLS OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ANSI_PADDING OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ARITHABORT OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET  DISABLE_BROKER
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET  READ_WRITE
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET RECOVERY FULL
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET  MULTI_USER
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [BdSanJuanEficienciaPlanta] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'BdSanJuanEficienciaPlanta', N'ON'
GO
USE [BdSanJuanEficienciaPlanta]
GO
/****** Object:  Table [dbo].[SJ_Refrigerio]    Script Date: 10/03/2012 09:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Refrigerio](
	[IdAsistencia] [char](8) NOT NULL,
	[IdTipoRefrigerio] [char](2) NOT NULL,
	[FechaHoraInicio] [datetime] NOT NULL,
	[FechaHoraFin] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_Refrigerio] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC,
	[IdTipoRefrigerio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_PosicionDiaria]    Script Date: 10/03/2012 09:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_PosicionDiaria](
	[IdPosicionDiaria] [int] IDENTITY(1,1) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[IdPosicion] [char](4) NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_PosicionDiaria] PRIMARY KEY CLUSTERED 
(
	[IdPosicionDiaria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IDX_TRAB_POS] ON [dbo].[SJ_PosicionDiaria] 
(
	[IdAsistencia] ASC,
	[IdArea] ASC,
	[DniTrabajador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = OFF) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SJ_Posicion]    Script Date: 10/03/2012 09:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Posicion](
	[IdPosicion] [char](4) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdGrupo] [char](3) NULL,
 CONSTRAINT [PK_SJ_Posicion] PRIMARY KEY CLUSTERED 
(
	[IdPosicion] ASC,
	[IdLinea] ASC,
	[IdArea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_PersonalPlanta]    Script Date: 10/03/2012 09:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_PersonalPlanta](
	[DniTrabajador] [char](8) NOT NULL,
	[ApellidosNombres] [varchar](200) NOT NULL,
	[IdCodigoGeneral] [char](8) NOT NULL,
 CONSTRAINT [PK_SJ_PersonalPlanta] PRIMARY KEY CLUSTERED 
(
	[DniTrabajador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_MotivoDescanso]    Script Date: 10/03/2012 09:44:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_MotivoDescanso](
	[IdMotivoDescanso] [char](2) NOT NULL,
	[Descripcion] [varchar](60) NULL,
 CONSTRAINT [PK_SJ_MotivoDescanso] PRIMARY KEY CLUSTERED 
(
	[IdMotivoDescanso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[ObtenerSoloFecha]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ObtenerSoloFecha]
(@fechahora datetime) 
RETURNS datetime 
AS  
BEGIN   
declare @retvalue datetime  
set @retvalue= @fechahora
--set @retvalue = select Cast(Floor(Cast(@fechahora as Float))as DateTime)  
select @retvalue = Cast(Floor(Cast(@fechahora as Float))as DateTime)  
return @retvalue END
GO
/****** Object:  Table [dbo].[ItemSJ]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemSJ](
	[Item] [int] NOT NULL,
 CONSTRAINT [PK_ItemSJ] PRIMARY KEY CLUSTERED 
(
	[Item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SJ_Usuario]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Usuario](
	[Dni] [char](8) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[NombreCompleto] [varchar](150) NOT NULL,
	[Estado] [varchar](2) NOT NULL,
	[FechaRegistro] [datetime] NOT NULL,
	[IdTipoUsuario] [varchar](2) NOT NULL,
 CONSTRAINT [PK_SJ_Usuario] PRIMARY KEY CLUSTERED 
(
	[Dni] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Linea]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Linea](
	[IdLinea] [char](2) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
 CONSTRAINT [PK_SJ_Linea] PRIMARY KEY CLUSTERED 
(
	[IdLinea] ASC,
	[IdArea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_JornalBase]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_JornalBase](
	[Id] [char](2) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFinal] [datetime] NOT NULL,
	[JornalBasico] [decimal](17, 3) NOT NULL,
 CONSTRAINT [PK_SJ_JornalBase] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Formato]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Formato](
	[IdFormato] [char](2) NULL,
	[Descripcion] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Estandar]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Estandar](
	[IdEstandar] [int] IDENTITY(1,1) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[HorasTrabajadas] [decimal](17, 2) NOT NULL,
	[Estandar] [decimal](17, 2) NOT NULL,
	[EstandarExtra] [decimal](17, 2) NOT NULL,
	[Jornal] [decimal](17, 6) NOT NULL,
	[PrecioUnitario] [decimal](17, 6) NOT NULL,
	[PrecioUnitarioExtra] [decimal](17, 6) NOT NULL,
	[UserDecimal01] [decimal](17, 6) NOT NULL,
	[UserVarchar01] [varchar](50) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFinal] [datetime] NOT NULL,
	[IdFormato] [char](2) NOT NULL,
	[EstandarPorcentajePrimerDia] [decimal](17, 2) NOT NULL,
	[EstandarPorcentajeSegundoDia] [decimal](17, 2) NOT NULL,
	[EstandarPrimerDia] [decimal](17, 2) NOT NULL,
	[EstandarSegundoDia] [decimal](17, 2) NOT NULL,
	[PrecioPrimerDia] [decimal](17, 6) NOT NULL,
	[PrecioSegundoDia] [decimal](17, 6) NOT NULL,
 CONSTRAINT [PK_SJ_Estandar] PRIMARY KEY CLUSTERED 
(
	[IdEstandar] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_EficienciaOperadorPrueba]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_EficienciaOperadorPrueba](
	[IdEficienciaOperador] [int] IDENTITY(1,1) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
	[FechaAsistencia] [datetime] NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdLote] [char](8) NOT NULL,
	[IdFormato] [char](2) NOT NULL,
	[FechaHoraRegistro] [datetime] NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_EficienciaPrueba] PRIMARY KEY CLUSTERED 
(
	[IdEficienciaOperador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_EficienciaOperador]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_EficienciaOperador](
	[IdEficienciaOperador] [int] IDENTITY(1,1) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
	[FechaAsistencia] [datetime] NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdLote] [char](8) NOT NULL,
	[IdFormato] [char](2) NOT NULL,
	[FechaHoraRegistro] [datetime] NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_Eficiencia] PRIMARY KEY CLUSTERED 
(
	[IdEficienciaOperador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Descanso]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Descanso](
	[IdDescanso] [int] IDENTITY(1,1) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[FechaHoraInicio] [datetime] NOT NULL,
	[FechaHoraFin] [datetime] NOT NULL,
	[IdMotivoDescanso] [char](2) NOT NULL,
 CONSTRAINT [PK_SJ_Descanso] PRIMARY KEY CLUSTERED 
(
	[IdDescanso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_DeficienciaProducto]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_DeficienciaProducto](
	[IdDeficienciaProducto] [int] IDENTITY(1,1) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdLote] [char](8) NOT NULL,
	[FechaHoraRegistro] [datetime] NOT NULL,
	[IdDefectoProducto] [char](2) NOT NULL,
	[DniCosechador] [char](8) NOT NULL,
	[CantidadRacimos] [int] NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_DeficienciaProducto] PRIMARY KEY CLUSTERED 
(
	[IdDeficienciaProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_DefectoProducto]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_DefectoProducto](
	[IdDefectoProducto] [char](2) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SJ_DefectoProducto] PRIMARY KEY CLUSTERED 
(
	[IdDefectoProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_ControlPagosEficiencias]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_ControlPagosEficiencias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCodigoGeneral] [char](8) NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[Cantidad] [decimal](17, 6) NOT NULL,
	[Importe] [decimal](17, 6) NOT NULL,
	[CantidadExtra] [decimal](17, 6) NOT NULL,
	[ImporteExtra] [decimal](17, 6) NOT NULL,
	[Precio] [decimal](17, 6) NOT NULL,
	[PrecioExtra] [decimal](17, 6) NOT NULL,
	[IdMedida] [varchar](30) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[IdFormato] [char](2) NOT NULL,
	[HorasTrabajadas] [decimal](17, 2) NOT NULL,
	[EstandarNormal] [decimal](17, 2) NOT NULL,
	[EstandarExtra] [decimal](17, 2) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
 CONSTRAINT [PK_SJ_ControlPagosEfciencias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Consumidor]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Consumidor](
	[IdConsumidor] [char](8) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[InicialVariedad] [char](1) NOT NULL,
	[Variedad] [varchar](100) NOT NULL,
 CONSTRAINT [PK_SJ_Consumidor] PRIMARY KEY CLUSTERED 
(
	[IdConsumidor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_CambioArea]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_CambioArea](
	[IdCambioArea] [int] IDENTITY(1,1) NOT NULL,
	[IdAsistencia] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[FechaHoraSalida] [datetime] NOT NULL,
	[FechaHoraRegreso] [datetime] NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdAreaDestino] [char](2) NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_CambioArea] PRIMARY KEY CLUSTERED 
(
	[IdCambioArea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_AsistenciaDetalleSobreTiempo]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_AsistenciaDetalleSobreTiempo](
	[IdAsistencia] [char](8) NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[Item] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdPosicion] [char](4) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[FechaHoraIngreso] [datetime] NOT NULL,
	[FechaHoraSalida] [datetime] NOT NULL,
	[Eficiencia] [int] NOT NULL,
	[DetalleInconsistencia] [varchar](300) NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_AsistenciaDetalleSobreTiempo_1] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC,
	[DniTrabajador] ASC,
	[IdArea] ASC,
	[IdLinea] ASC,
	[Item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_AsistenciaDetalle]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_AsistenciaDetalle](
	[IdAsistencia] [char](8) NOT NULL,
	[DniTrabajador] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[Item] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdPosicion] [char](4) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[FechaHoraIngreso] [datetime] NOT NULL,
	[FechaHoraSalida] [datetime] NOT NULL,
	[Eficiencia] [int] NOT NULL,
	[DetalleInconsistencia] [varchar](300) NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_AsistenciaDetalle] PRIMARY KEY CLUSTERED 
(
	[Item] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
CREATE NONCLUSTERED INDEX [IDX_TRAB_ASIST] ON [dbo].[SJ_AsistenciaDetalle] 
(
	[IdAsistencia] ASC,
	[DniTrabajador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = OFF) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SJ_Asistencia]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Asistencia](
	[IdAsistencia] [char](8) NOT NULL,
	[IdArea] [char](2) NOT NULL,
	[IdLinea] [char](2) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[FechaHoraInicio] [datetime] NOT NULL,
	[FechaHoraFin] [datetime] NOT NULL,
	[Cerrado] [char](2) NOT NULL,
	[FechaHoraTransferencia] [datetime] NOT NULL,
 CONSTRAINT [PK_SJ_Asistencia_1] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC,
	[IdArea] ASC,
	[IdLinea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_AreaGeneral]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_AreaGeneral](
	[IdArea] [char](2) NOT NULL,
	[Descripcion] [varchar](60) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdMedida] [varchar](30) NOT NULL,
	[IdActividad] [char](8) NULL,
	[IdLabor] [char](8) NULL,
	[IdCentroCosto] [varchar](10) NULL,
 CONSTRAINT [PK_SJ_AreaGeneral] PRIMARY KEY CLUSTERED 
(
	[IdArea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SJ_Area]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SJ_Area](
	[IdArea] [char](2) NOT NULL,
	[Descripcion] [varchar](60) NOT NULL,
	[DniSupervisor] [char](8) NOT NULL,
	[IdMedida] [varchar](30) NOT NULL,
	[IdActividad] [char](8) NULL,
	[IdLabor] [char](8) NULL,
	[IdCentroCosto] [varchar](10) NULL,
 CONSTRAINT [PK_SJ_Area] PRIMARY KEY CLUSTERED 
(
	[IdArea] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SJ_ReporteCostosDirectos]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec SJ_ReporteCostosDirectos '01/01/2010 00:00:00', '31/01/2010 23:59:59', '106', 'SI'

CREATE Procedure [dbo].[SJ_ReporteCostosDirectos]
(
	@FechaInicial varchar(20),
	@FechaFinal varchar(20),
	@IdConsumidor char(8),
	@IncluirParteMaq char(2)
)
AS
Begin
	IF(@IncluirParteMaq = 'SI')
		Select	RC.Fecha, RC.DocumentoReferencia, RC.IdCuentaContable, RC.IdCentroCosto, RC.CentroCosto,
				RC.IdConsumidor, RC.Consumidor,
				RC.TipoGasto, RC.IdProducto, RC.Producto, RC.IdMedida, RC.Cantidad, 
				isnull(RC.ImporteMof,0) as ImporteMof
		from	SJ_ResumenCostoDetalle as RC
				Inner join Consumidor as C On RC.IdConsumidor = C.IdConsumidor and C.IdEmpresa = '001'
		Where	Fecha >= @FechaInicial and Fecha <= @FechaFinal and 
				RC.IdConsumidor = @IdConsumidor
		--Order by Fecha, RC.TipoGasto
		
		UNION ALL

		SELECT	pm.Fecha, (isnull(pm.Serie,'000') + '-' + isnull(pm.Numero,'000')) as DocumentoReferencia,
				'' as IdCuentaContable, isnull(cc.IdClaseCCosto,'0004') as IdCentroCosto,
				isnull(cc.Descripcion,'G.COMUNES') as CentroCosto,
				isnull(dp.IdConsumidor,'') as IdConsumidor, isnull(co.Descripcion,'') as Consumidor,
				'MAQUINARIA' as TipoGasto,
				isnull(dpmd.IdProducto,'') as IdProducto, isnull(dpmd.Descripcion,'') as Producto,
				isnull(dpmd.IdMedida,'') as IdMedida, isnull(dpmd.Cantidad,0) as Cantidad,	
				isnull(dbo.SJFU_ObtenerValorProrrateado(pm.IdParteMaq, dp.HORAS_TRAB1),0) as ImporteMof
		FROM	parte_maquinaria as pm
				left join dparte_maquinaria dp on dp.idempresa = pm.idempresa and dp.idpartemaq=pm.idpartemaq
				left join consumidor co on co.idempresa = dp.idempresa and co.idconsumidor=dp.idconsumidor
				left join clasesccosto cc  on cc.idempresa = co.idempresa and cc.idclaseccosto = co.idclaseccosto
				left join dparte_maquinaria_prd dpmd on dpmd.idempresa = pm.idempresa and dpmd.idpartemaq=pm.idpartemaq
		WHERE	pm.Fecha >= @FechaInicial and pm.Fecha <= @FechaFinal and
				dp.idconsumidor = @IdConsumidor and
				dbo.SJFU_ObtenerValorProrrateado(pm.IdParteMaq, dp.HORAS_TRAB1) > 0

	ELSE
		Select	RC.Fecha, RC.DocumentoReferencia, RC.IdCuentaContable, RC.IdCentroCosto, RC.CentroCosto,
				RC.IdConsumidor, RC.Consumidor,
				RC.TipoGasto, RC.IdProducto, RC.Producto, RC.IdMedida, RC.Cantidad,isnull( RC.ImporteMof,0) as ImporteMof
		from	SJ_ResumenCostoDetalle as RC
				Inner join Consumidor as C On RC.IdConsumidor = C.IdConsumidor and C.IdEmpresa = '001'
		Where	Fecha >= @FechaInicial and Fecha <= @FechaFinal and 
				RC.IdConsumidor = @IdConsumidor
End
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerCuentaContable]    Script Date: 10/03/2012 09:44:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  select dbo.SJFU_ObtenerCuentaContable('201006', '_2ZF0I4RBD37206', '260200100000064')

--and  C.IdCabConta = '_2ZF0I4RBD37206'
	--and IdProducto = '260200100000064'

CREATE FUNCTION [dbo].[SJFU_ObtenerCuentaContable]
(
	@Periodo char(6),
	@IdCabConta varchar(20),
	@IdProducto decimal(17,2)
)
RETURNS VARCHAR(20)
AS 
BEGIN
	DECLARE @RetValue VARCHAR(20)

	SET @RetValue = ''
	
		--  SE OBTIENE LA CUENTA CONTABLE DEL PRODUCTO
		SELECT	@RetValue = ISNULL(D.IdCuenta,'')
		FROM	CABCONTA as C
				Inner Join DETCONTA as D on
					C.idempresa = D.idempresa and
					C.idcabconta = D.idcabconta
		WHERE	D.idempresa='001' and C.Periodo = @Periodo and D.idcuenta <> '' and 
				D.idcuenta like '9%' and
				D.idconsumidor <> '' and D.idproducto <> '' and (D.cargo_mof <>0 or D.Abono_mof <> 0)
				and  C.IdCabConta = @IdCabConta
				and IdProducto = @IdProducto
	
	IF(@RetValue = '')
		SELECT	@RetValue = ISNULL(D.IdCuenta,'')
		FROM	CABCONTA as C
				Inner Join DETCONTA as D on
					C.idempresa = D.idempresa and
					C.idcabconta = D.idcabconta
		WHERE	D.idempresa='001' and C.Periodo = @Periodo and D.idcuenta <> '' and 
				D.idcuenta like '9%' and
				D.idconsumidor <> '' and D.idproducto <> '' and (D.cargo_mof <>0 or D.Abono_mof <> 0)
				and  C.IdCabConta = @IdCabConta


	RETURN @RetValue

END
GO
/****** Object:  View [dbo].[v_EficienciasPlantaByVariedad]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_EficienciasPlantaByVariedad]

AS
SELECT		EO.IdAsistencia,
			MAX(ISNULL(PP.IdCodigoGeneral, '')) AS IdCodigoGeneral, 
			EO.DniTrabajador,
			MAX(ISNULL(PP.ApellidosNombres, 'DESCONOCIDO')) AS Nombres,
			CO.InicialVariedad,
			A.IdArea,
            MAX(ISNULL(A.Descripcion, '0')) AS Area,
			ISNULL(CO.InicialVariedad, '') + ISNULL(MAX(A.IdCentroCosto), '') AS CC,
			MAX(ISNULL(A.IdActividad, '')) AS Act,
			MAX(ISNULL(A.IdLabor, '')) AS Lab,
            MAX(ISNULL(A.IdMedida, '')) AS IdMedida,
			ISNULL(COUNT(EO.DniTrabajador), 0) AS Cantidad,
			MAX(EO.FechaHoraRegistro) AS Fecha,
			--MAX(ISNULL(AD.IdLinea, '')) AS LineaTrabajo,
			'00' as LineaTrabajo,
			'0000' as Posicion,
			--MAX(ISNULL(AD.IdPosicion, '')) AS Posicion,
			--EO.IdFormato
			'00' as IdFormato
FROM        dbo.SJ_EficienciaOperador AS EO
			LEFT JOIN dbo.SJ_AreaGeneral AS A ON EO.IdArea = A.IdArea
			LEFT JOIN dbo.SJ_Consumidor AS CO ON EO.IdLote = CO.IdConsumidor
			LEFT JOIN dbo.SJ_PersonalPlanta AS PP ON EO.DniTrabajador = PP.DniTrabajador
--			LEFT JOIN dbo.SJ_AsistenciaDetalle AS AD ON EO.IdAsistencia = AD.IdAsistencia
--				 AND EO.DniTrabajador = AD.DniTrabajador
--				 AND EO.IdArea = AD.IdArea
WHERE		(A.IdArea IN ('01', '02', '03', '04'))
--GROUP		BY EO.IdAsistencia, EO.DniTrabajador, A.IdArea, EO.IdFormato , CO.InicialVariedad
GROUP		BY EO.IdAsistencia, EO.DniTrabajador, A.IdArea, CO.InicialVariedad
GO
/****** Object:  View [dbo].[v_EficienciasPlanta]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_EficienciasPlanta]

AS
SELECT		EO.IdAsistencia,
			MAX(ISNULL(PP.IdCodigoGeneral, '')) AS IdCodigoGeneral, 
			EO.DniTrabajador,
			MAX(ISNULL(PP.ApellidosNombres, 'DESCONOCIDO')) AS Nombres,
			--CO.InicialVariedad,
			A.IdArea,
            MAX(ISNULL(A.Descripcion, '0')) AS Area,
			--ISNULL(CO.InicialVariedad, '') + ISNULL(MAX(A.IdCentroCosto), '') AS CC,
			ISNULL(MAX(A.IdCentroCosto), '') AS CC,
			MAX(ISNULL(A.IdActividad, '')) AS Act,
			MAX(ISNULL(A.IdLabor, '')) AS Lab,
            MAX(ISNULL(A.IdMedida, '')) AS IdMedida,
			ISNULL(COUNT(EO.DniTrabajador), 0) AS Cantidad,
			MAX(EO.FechaHoraRegistro) AS Fecha,
			'00' as LineaTrabajo,
			--MAX(ISNULL(AD.IdLinea, '')) AS LineaTrabajo,
			--MAX(ISNULL(AD.IdPosicion, '')) AS Posicion,
			'0000' as Posicion,
			EO.IdFormato
			--'00' as IdFormato
FROM        dbo.SJ_EficienciaOperador AS EO
			LEFT JOIN dbo.SJ_AreaGeneral AS A ON EO.IdArea = A.IdArea
			LEFT JOIN dbo.SJ_Consumidor AS CO ON EO.IdLote = CO.IdConsumidor
			LEFT JOIN dbo.SJ_PersonalPlanta AS PP ON EO.DniTrabajador = PP.DniTrabajador
--			LEFT JOIN dbo.SJ_AsistenciaDetalle AS AD ON EO.IdAsistencia = AD.IdAsistencia
--				 AND EO.DniTrabajador = AD.DniTrabajador
--				 AND EO.IdArea = AD.IdArea
WHERE		(A.IdArea IN ('01', '02', '03', '04'))
GROUP		BY EO.IdAsistencia, EO.DniTrabajador, A.IdArea, EO.IdFormato --, CO.InicialVariedad
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerConversionHoras]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  select dbo.SJFU_ObtenerImporteAvance('23/09/2011 00:00:00', 261, '02', 0, '00')
--  select dbo.SJFU_ObtenerImporteAvance('23/09/2011 00:00:00', 261, '02', 1, '00')

CREATE FUNCTION [dbo].[SJFU_ObtenerConversionHoras]
(
	@Fecha varchar(20),
	@Importe decimal(17,6)
)
RETURNS DECIMAL(17,2) AS 
BEGIN

	DECLARE @RetValue decimal(17,2)
	DECLARE @JornalBase decimal(17,3)
	
	SET @JornalBase =	(SELECT	TOP 1 JornalBasico
						 FROM	SJ_JornalBase
						 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal)

	--CALCULO DE TOTAL DE HECTAREAS DE ACUERDO A UN PERIODO

	IF(@JornalBase > 0 and @Importe > 0)
	BEGIN
		SELECT @RetValue = ((@Importe * 8) /  @JornalBase)
	END
	ELSE
	BEGIN
		SELECT @RetValue = 0
	END
	
	RETURN @retValue

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ListarEficienciasOperadores]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- SP_HELPTEXT SJ_ListarEficienciasOperadores  
    
--- CREADO EL 11/11/2010    
--  Exec SJ_ListarEficienciasOperadores '15/11/2011 00:00:00', '15/11/2011 23:59:59','20111115'

CREATE PROCEDURE [dbo].[SJ_ListarEficienciasOperadores]
(    
	@FechaInicio varchar(20),  
	@FechaFinal varchar(20),  
	@IdAsistencia char(8)  
 --	@IdArea char(2)  
)  
AS  
BEGIN  
  
  --ACTUALIZAMOS LAS EFICIENCIAS A UN ESTANDAR GENERAL  
  --PARA LAS AREAS DE LIMPIEZA Y SELECCION.  
  --*******************************************************************  
  UPDATE SJ_EficienciaOperador SET IdFormato = '00'  
  WHERE  IdArea IN('01','02') and IdAsistencia = @IdAsistencia  
  --*******************************************************************  
  -- EJECUTAMOS EL PROCEDIMIENTO PARA GENERAR EFIECIENAS SELECCIONADOTRAS
  ---------------------------------------------------------------------------
  -- EXEC SJ_GenerarEficienciasSeleccionadoras '14/11/2011 00:00:00'
  ---------------------------------------------------------------------------

  
 IF((SELECT DATEDIFF(day, @FechaInicio, @FechaFinal)) = 0)  
 BEGIN  
		SELECT	Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral,  
				EO.DniTrabajador,  
				Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) As Nombres,  
				Max(ISNULL(A.IdArea,'0')) as IdArea,  
				Max(ISNULL(A.Descripcion,'0')) as Area,  
				Max(ISNULL(A.IdMedida,'')) as IdMedida,
				ISNULL(Count(EO.Dnitrabajador),0) as Cantidad,
				Max(EO.FechaHoraRegistro) as Fecha,
				----MOSTRAR LINEA Y POSICIONES ULTIMAS
				ISNULL(PD.IdLinea,'') as LineaTrabajo,
				--Max(ISNULL(PD.IdLinea,'')) as LineaTrabajo,
				Max(ISNULL(PD.IdPosicion,'')) as Posicion,
				--EO.IdFormato
				Min(FechaHoraRegistro) as PrimerRegistro,
				Max(FechaHoraRegistro) as UltimoRegistro
		FROM	SJ_EficienciaOperador as EO    
				LEFT JOIN SJ_Area as A on EO.IdArea = A.IdArea    
				LEFT JOIN SJ_PersonalPlanta as PP on EO.DniTrabajador = PP.DniTrabajador    
				LEFT JOIN
		(    
				SELECT	IdAsistencia,    
						DniTrabajador,    
						IdArea,    
						Max(IdLinea) as IdLinea,     
						Max(IdPosicion) as IdPosicion    
				FROM	SJ_PosicionDiaria    
				WHERE	IdAsistencia = @IdAsistencia    
				GROUP	BY IdAsistencia, DniTrabajador,IdArea    
		) PD ON     
			@IdAsistencia = PD.IdAsistencia and    
			EO.IdArea = PD.IdArea and    
			EO.DniTrabajador = PD.DniTrabajador
     WHERE		(EO.FechaHoraRegistro >= @FechaInicio and EO.FechaHoraRegistro <= @FechaFinal)    
				AND A.IdArea IN('01','02','03','04')  
     GROUP BY	EO.DniTrabajador, A.IdArea, PD.IdLinea
	 --GROUP	BY EO.DniTrabajador, A.IdArea
     ORDER BY	A.IdArea, Isnull(Count(EO.Dnitrabajador),0)    
 END
 ELSE
 BEGIN
		SELECT	Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral,    
				EO.DniTrabajador,    
				Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) As Nombres,  
				Max(ISNULL(A.IdArea,'0')) as IdArea,  
				Max(ISNULL(A.Descripcion,'0')) as Area,    
				Max(ISNULL(A.IdMedida,'')) as IdMedida,    
				ISNULL(Count(EO.Dnitrabajador),0) as Cantidad,    
				Max(EO.FechaHoraRegistro) as Fecha,    
				----MOSTRAR LINEA Y POSICIONES ULTIMAS    
				' ' as LineaTrabajo,  
				' ' as Posicion  
				--EO.IdFormato  
		FROM	SJ_EficienciaOperador as EO    
				left join SJ_Area as A on EO.IdArea = A.IdArea    
				left join SJ_PersonalPlanta as PP on EO.DniTrabajador = PP.DniTrabajador    
		WHERE	(EO.FechaHoraRegistro >= @FechaInicio and EO.FechaHoraRegistro <= @FechaFinal)    
				AND A.IdArea IN('01','02','03','04')    
		--GROUP BY EO.DniTrabajador, A.IdArea, EO.IdFormato  
		GROUP BY EO.DniTrabajador, A.IdArea
		ORDER BY Isnull(Count(EO.Dnitrabajador),0),A.IdArea    
 END    
END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ListarEficienciasAgrupadaPorHora]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  EXEC SJ_ListarEficienciasAgrupadaPorHora '20111018', '01'

CREATE PROCEDURE [dbo].[SJ_ListarEficienciasAgrupadaPorHora]
(
	@IdAsistencia char(8),
	@IdArea char(2)
)
AS
BEGIN
	With AgrupadoHoras(DniTrabajador, Nombres, Area, Cantidad, L, P, Hora) AS
		(SELECT	EO.DniTrabajador,
				Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) As Nombres,
				Max(ISNULL(A.Descripcion,'0')) as Area,
				ISNULL(Count(EO.Dnitrabajador),0) as Cantidad,

				Max(ISNULL(PD.IdLinea,'')) as L,
				Max(ISNULL(PD.IdPosicion,'')) as P,

				DATEPART(hour, EO.FechaHoraRegistro) as Hora
		FROM	SJ_EficienciaOperador as EO
				left join SJ_Area as A on EO.IdArea = A.IdArea
				left join SJ_PersonalPlanta as PP on EO.DniTrabajador = PP.DniTrabajador
				left join
				(
					select	IdAsistencia,
							DniTrabajador,
							IdArea,
							Max(IdLinea) as IdLinea, 
							Max(IdPosicion) as IdPosicion
					from	SJ_PosicionDiaria
					where	IdAsistencia = @IdAsistencia
					group by IdAsistencia, DniTrabajador,IdArea
				) PD ON 
						EO.IdAsistencia = PD.IdAsistencia and
						EO.IdArea = PD.IdArea and
						EO.DniTrabajador = PD.DniTrabajador
		WHERE	EO.IdAsistencia = @IdAsistencia and A.IdArea = @IdArea
		GROUP BY  EO.IdAsistencia, EO.DniTrabajador, 
				  A.IdArea , DATEPART(hour, EO.FechaHoraRegistro), PD.IdLinea)
		---------------------------------------------------------------
		SELECT	DniTrabajador, Nombres, Area, ISNULL(CONVERT(INT,L),0) AS L, ISNULL(CONVERT(INT,P),0) AS P,
				isnull([6],0) as '06',isnull([7],0) as '07',isnull([8],0) as '08',
				isnull([9],0) as '09',isnull([10],0) as '10',isnull([11],0) as '11',
				isnull([12],0) as '12',isnull([13],0) as '13',isnull([14],0) as '14',
				isnull([15],0) as '15',isnull([16],0) as '16',isnull([17],0) as '17',
				isnull([18],0) as '18',isnull([19],0) as '19',isnull([20],0) as '20',
				isnull([21],0) as '21',isnull([22],0) as '22',isnull([23],0) as '23',
				isnull([0],0) as '00',isnull([1],0) as '01',isnull([2],0) as '02',
				isnull([3],0) as '03',
				--MOSTRAMOS EL RESUMEN TOTAL POR FILA
				ISNULL((isnull([6],0) + isnull([7],0) + isnull([8],0) +
				isnull([9],0) + isnull([10],0) + isnull([11],0) +
				isnull([12],0) + isnull([13],0) + isnull([14],0) +
				isnull([15],0) + isnull([16],0) + isnull([17],0) +
				isnull([18],0) + isnull([19],0) + isnull([20],0) +
				isnull([21],0) + isnull([22],0) + isnull([23],0) +
				isnull([0],0) + isnull([1],0) + isnull([2],0) +
				isnull([3],0)),0) as SUBTOTAL
		FROM AgrupadoHoras
		PIVOT (
				SUM(Cantidad) 
				FOR Hora IN ([6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],
							 [18],[19],[20],[21],[22],[23],[0],[1],[2],[3])
			  )
		AS PVT

END
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerTiempoRefrigerioDetallado]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[SJFU_ObtenerTiempoRefrigerioDetallado]
(
	@IdAsistencia char(8),
	@HorasMinutos char(2),
	@FechaHoraIngresoTrabajador DateTime,
	@FechaHoraSalidaTrabajador DateTime
	--@IdArea char(2)
	--@IdTipoRefrigerio char(2)
)
RETURNS INT AS 
BEGIN
	DECLARE @RetValue INT

	DECLARE @FechaHoraAlmuerzoIni DateTime
	DECLARE @FechaHoraAlmuerzoFin DateTime

	DECLARE @FechaHoraCenaIni DateTime
	DECLARE @FechaHoraCenaFin DateTime

	DECLARE @IdArea char(2)
	set @IdArea = ''	

	SET @RetValue = 0
	----EL PROCEDIMIENTO ALMACENADO SOPORTA DOS HORAS DE REFRIGERIO
	----ALMUERZO Y CENA	
	
	IF(@IdArea != '07')
	BEGIN

			IF(@HorasMinutos = 'HH')
			BEGIN
				--CALCULAMOS LAS HORAS DE INICIO Y FIN EN EL ALMUERZO 
				SELECT @FechaHoraAlmuerzoIni = FechaHoraInicio
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'AL'

				SELECT @FechaHoraAlmuerzoFin = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'AL'

				--CALCULAMOS LAS HORAS DE INICIO Y FIN EN LA CENA
				SELECT @FechaHoraCenaIni = FechaHoraInicio
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'CE'

				SELECT @FechaHoraCenaFin = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'CE'
			
				-- SUMAMOS LAS HORAS DE ALMUERZO SIMPRE Y CUANDO EL TRABAJADOR ESTE TRABAJANDO ENTRE ESAS HORAS
				IF((@FechaHoraIngresoTrabajador < @FechaHoraAlmuerzoIni) and (@FechaHoraSalidaTrabajador >= @FechaHoraAlmuerzoFin))
				BEGIN
					SELECT	@RetValue = @RetValue + DatePart(hour,(FechaHoraFin - FechaHoraInicio))
					FROM	SJ_Refrigerio
					WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'AL'	
				END

				-- SUMAMOS LAS HORAS DE CENA SIMPRE Y CUANDO EL TRABAJADOR ESTE TRABAJANDO ENTRE ESAS HORAS
				IF((@FechaHoraIngresoTrabajador < @FechaHoraCenaIni) and (@FechaHoraSalidaTrabajador >= @FechaHoraCenaFin))
				BEGIN
					SELECT	@RetValue = @RetValue + DatePart(hour,(FechaHoraFin - FechaHoraInicio))
					FROM	SJ_Refrigerio
					WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'CE'	
				END	

			END --FIN IF (@HorasMinutos)
			ELSE
			BEGIN
				
				--CALCULAMOS LAS HORAS DE INICIO Y FIN EN EL ALMUERZO 
				SELECT @FechaHoraAlmuerzoIni = FechaHoraInicio
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'AL'

				SELECT @FechaHoraAlmuerzoFin = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'AL'

				--CALCULAMOS LAS HORAS DE INICIO Y FIN EN LA CENA
				SELECT @FechaHoraCenaIni = FechaHoraInicio
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'CE'

				SELECT @FechaHoraCenaFin = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia and IdTipoRefrigerio = 'CE'
			
				-- SUMAMOS LOS MINUTOS DE ALMUERZO SIMPRE Y CUANDO EL TRABAJADOR ESTE TRABAJANDO ENTRE ESAS HORAS
				IF((@FechaHoraIngresoTrabajador < @FechaHoraAlmuerzoIni) and (@FechaHoraSalidaTrabajador >= @FechaHoraAlmuerzoFin))
				BEGIN
					SELECT	@RetValue = @RetValue + DatePart(minute,(FechaHoraFin - FechaHoraInicio))
					FROM	SJ_Refrigerio
					WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'AL'	
				END

				-- SUMAMOS LOS MINUTOS DE CENA SIMPRE Y CUANDO EL TRABAJADOR ESTE TRABAJANDO ENTRE ESAS HORAS
				IF((@FechaHoraIngresoTrabajador < @FechaHoraCenaIni) and (@FechaHoraSalidaTrabajador >= @FechaHoraCenaFin))
				BEGIN
					SELECT	@RetValue = @RetValue + DatePart(minute,(FechaHoraFin - FechaHoraInicio))
					FROM	SJ_Refrigerio
					WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'CE'	
				END	

			END

	END

	RETURN @retValue

END
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerTiempoRefrigerio]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  select dbo.SJFU_ObtenerTiempoRefrigerio('20101118', 'MM', '18/11/2010 21:00:00')


CREATE FUNCTION [dbo].[SJFU_ObtenerTiempoRefrigerio]
(
	@IdAsistencia char(8),
	@HorasMinutos char(2),
	@FechaHoraSalidaTrabajador DateTime
	--@IdArea char(2)
	--@IdTipoRefrigerio char(2)
)
RETURNS INT AS 
BEGIN
	DECLARE @RetValue INT
	DECLARE @FechaHoraUltimoRefrigerio DateTime
	DECLARE @IdArea char(2)

	set @IdArea = ''
	SET @RetValue = 0
	----EL PROCEDIMIENTO ALMACENADO SOPORTA DOS HORAS DE REFRIGERIO
	----ALMUERZO Y CENA	
	
	--  A TODOS EL PERSONAL DE FRIO NO SE LE DESCUENTA REFRIGERIO
	IF(@IdArea != '07')
	BEGIN
		IF(@HorasMinutos = 'HH')
		BEGIN
				--VERIFICAMOS SI LA HORA SALIDA EN MAYOR IGUAL QUE LA ULTIMA HORA DE REFRIGERIO
			SELECT @FechaHoraUltimoRefrigerio = Max(FechaHoraInicio)
			FROM SJ_Refrigerio
			WHERE IdAsistencia = @IdAsistencia

			IF(@FechaHoraSalidaTrabajador >= @FechaHoraUltimoRefrigerio)
			BEGIN
				SELECT	@RetValue = Sum(DatePart(hour,(FechaHoraFin - FechaHoraInicio)))
				FROM	SJ_Refrigerio
				WHERE	IdAsistencia =  @IdAsistencia
				GROUP BY IdAsistencia
			END
			ELSE
			BEGIN
				--VERIFICAMOS SI LA HORA SALIDA EN MAYOR IGUAL QUE LA DEL ALMUERZO
				--SINO QUIERE DECIR QUE SALIO TEMPRANO ANTES DE ALMUERZO Y NO SE LE DEBE DE CONSIDERAR
				--DSCUENTOS DE HORAS
				SELECT @FechaHoraUltimoRefrigerio = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia AND IdTipoRefrigerio = 'AL'

					IF(@FechaHoraSalidaTrabajador >= @FechaHoraUltimoRefrigerio)
					BEGIN
						SELECT	@RetValue = Sum(DatePart(hour,(FechaHoraFin - FechaHoraInicio)))
						FROM	SJ_Refrigerio
						WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'AL'
						GROUP BY IdAsistencia
					END
					ELSE
						SET @RetValue = 0
			
			END

		END --FIN IF (@HorasMinutos)
		ELSE
		BEGIN
			
				--VERIFICAMOS SI LOS HORAS SALIDA EN MAYOR IGUAL QUE LA ULTIMA HORA DE REFRIGERIO
			SELECT @FechaHoraUltimoRefrigerio = Max(FechaHoraInicio)
			FROM SJ_Refrigerio
			WHERE IdAsistencia = @IdAsistencia

			IF(@FechaHoraSalidaTrabajador >= @FechaHoraUltimoRefrigerio)
			BEGIN
				SELECT	@RetValue = Sum(DatePart(minute,(FechaHoraFin - FechaHoraInicio)))
				FROM	SJ_Refrigerio
				WHERE	IdAsistencia =  @IdAsistencia
				GROUP BY IdAsistencia
			END
			ELSE
			BEGIN
				--VERIFICAMOS SI LA HORA SALIDA EN MAYOR IGUAL QUE LA DEL ALMUERZO
				--SINO QUIERE DECIR QUE SALIO TEMPRANO ANTES DE ALMUERZO Y NO SE LE DEBE DE CONSIDERAR
				--DSCUENTOS DE HORAS
				SELECT @FechaHoraUltimoRefrigerio = FechaHoraFin
				FROM SJ_Refrigerio
				WHERE IdAsistencia = @IdAsistencia AND IdTipoRefrigerio = 'AL'

					IF(@FechaHoraSalidaTrabajador >= @FechaHoraUltimoRefrigerio)
					BEGIN
						SELECT	@RetValue = Sum(DatePart(minute,(FechaHoraFin - FechaHoraInicio)))
						FROM	SJ_Refrigerio
						WHERE	IdAsistencia =  @IdAsistencia and IdTipoRefrigerio = 'AL'
						GROUP BY IdAsistencia
					END
					ELSE
						SET @RetValue = 0
			
			END

		END
	
	END -- END DE IdArea	

	RETURN @retValue

END
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerInformacionEstandares]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  SELECT dbo.SJFU_ObtenerInformacionEstandares('23/09/2011 00:00:00', 261, '02', 'CANES', '00')

CREATE FUNCTION [dbo].[SJFU_ObtenerInformacionEstandares]
(
	@Fecha varchar(20),
	@Cantidad decimal(17,6),
	@IdArea char(2),
	@Indicador char(5),
	@IdFormato char(2),
	@DniTrabajador char(8)
)
RETURNS DECIMAL(17,2) AS 
BEGIN

	DECLARE	@FechaInicioProceso varchar(20)
	DECLARE	@FechaFinProceso varchar(20)
	
	SET @FechaInicioProceso = '21/09/2011 00:00:00'
	SET @FechaFinProceso = (SUBSTRING(@Fecha, 1, 10) + ' 23:59:59')

	DECLARE @RetValue decimal(17,2)
	DECLARE @CantEstandar decimal(17,6)
	DECLARE	@PrecioEstandar decimal(17,6)
	DECLARE	@HorasTrabajadas decimal(17,2)
	---------------------------------------
	DECLARE @EstandarNormal decimal(17,6)
	DECLARE @EstandarExtra decimal(17,6)

	DECLARE @CantExtra decimal(17,6)
	DECLARE	@PrecioExtra decimal(17,6)

	DECLARE	@CantidadDias_x_Area decimal(17,6)
	DECLARE	@CantidadDias decimal(17,6)

	SET @RetValue = 0

	SET @CantEstandar = (SELECT	TOP 1 Estandar
						 FROM	SJ_Estandar
						 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
								and IdArea = @IdArea
								and IdFormato = @IdFormato)

	SET @EstandarExtra = (SELECT	TOP 1 EstandarExtra
						  FROM		SJ_Estandar
						  WHERE		@Fecha >= FechaInicio and @Fecha <= FechaFinal 
									and IdArea = @IdArea
									and IdFormato = @IdFormato)

	--CANTIDAD DE DIAS QUE TIENE TRABAJANDO
	--SI ES MAYOR A TRES DIAS NO SE CONSIDERA PORCENTAJE JORNAL ESPECIAL
	SET @CantidadDias_x_Area = (SELECT  COUNT(Cont) as Cont
								FROM	
									(SELECT	COUNT(IdAsistencia) as Cont
									 FROM	SJ_AsistenciaDetalle
									 WHERE	Fecha >= @FechaInicioProceso and Fecha <= @FechaFinProceso
											and DniTrabajador = @DniTrabajador
											and IdArea = @IdArea
									 GROUP	by IdAsistencia) AS T)

	SET @CantidadDias = (SELECT  COUNT(Cont) as Cont
						 FROM	
									(SELECT	COUNT(IdAsistencia) as Cont
									 FROM	SJ_AsistenciaDetalle
									 WHERE	Fecha >= @FechaInicioProceso and Fecha <= @FechaFinProceso
											and DniTrabajador = @DniTrabajador
									 GROUP	by IdAsistencia) AS T)

	SET @EstandarNormal = @CantEstandar

	SET @CantExtra = @Cantidad - @CantEstandar

	SET @PrecioEstandar = (SELECT	TOP 1 PrecioUnitario
						   FROM		SJ_Estandar
						   WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal 
									and IdArea = @IdArea
									and IdFormato = @IdFormato)

	SET @PrecioExtra =	(SELECT	TOP 1 PrecioUnitarioExtra
						 FROM	SJ_Estandar
						 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal 
								and IdArea = @IdArea
								and IdFormato = @IdFormato)

	SET @HorasTrabajadas =	(SELECT	TOP 1 HorasTrabajadas
							 FROM	SJ_Estandar
							 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
									and IdArea = @IdArea
									and IdFormato = @IdFormato)

	
	--MOSTRAMOS EL INDICADOR QUE DESEAMOS
	--------------------------------------------------
	IF(@Indicador = 'DIAST') --CANTIDAD DE DIAS X AREA
		SELECT @RetValue = @CantidadDias_x_Area

	IF(@Indicador = 'DIASP') --CANTIDAD DE DIAS TRABAJANDO EN TODO EL PROCESO
		SELECT @RetValue = @CantidadDias

	IF(@Indicador = 'ESTES') --ESTANDAR NORMAL ESTABLECIDO PARA ESE DIA
		SELECT @RetValue = @EstandarNormal
	IF(@Indicador = 'ESTEX') --ESTANDAR EXTRA ESTABLECIDO PARA ESE DIA
		SELECT @RetValue = @EstandarExtra

	IF(@Indicador = 'HRSTR') --CANTIDAD ESTANDAR
		SELECT @RetValue = @HorasTrabajadas
	
	IF(@Indicador = 'CANES') --CANTIDAD ESTANDAR QUE HA HECHO EL TRABAJADOR
		SELECT @RetValue = @CantEstandar
	IF(@Indicador = 'CANEX') --CANTIDAD EXTRA QUE HA HECHO EL TRABAJADOR
		IF(@CantExtra > 0)
			SELECT @RetValue = @CantExtra
		ELSE
			SELECT @RetValue = 0
	IF(@Indicador = 'PREES') --PRECIO ESTANDAR
		SELECT @RetValue = @PrecioEstandar
	IF(@Indicador = 'PREEX') --PRECIO EXTRA
		SELECT @RetValue = @PrecioExtra
	IF(@Indicador = 'CANNN') --CANTIDAD REAL SIEMPRE Y CUANDO SEA MENOR AL ESTANDAR, SINO MOSTRARA EL ESTANDAR
		IF(@Cantidad < @CantEstandar)
			SELECT @RetValue = @Cantidad
		ELSE
			SELECT @RetValue = @CantEstandar

	RETURN @retValue

END
GO
/****** Object:  StoredProcedure [dbo].[pa_listarAreadeProceso]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[pa_listarAreadeProceso]
as
select idarea, descripcion from SJ_AreaGeneral
where idarea < 5
GO
/****** Object:  StoredProcedure [dbo].[SJ_GenerarEficienciasSeleccionadoras]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--***************************************************************
----------------------------------------------------------------
-- PROCESO PARA GENERAR LAS EFICIENIAS DE LAS SELECIONADORAS
----------------------------------------------------------------
--***************************************************************

--  EXEC SJ_GenerarEficienciasSeleccionadoras '19/11/2011 00:00:00'

CREATE PROCEDURE [dbo].[SJ_GenerarEficienciasSeleccionadoras]
(
	@Fecha varchar(20)
)
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Dni char(8), @IdArea char(2),
			@IdLinea char(2),
			@Cantidad int, @IdGrupo char(3),
			@IdLote char(8),
			@IdAsistencia char(8),
			@Cont int,
			--@Fecha varchar(20),
			@DniSeleccionadora char(8)

	--SET @Fecha = '14/11/2011 00:00:00'
	SET @IdAsistencia = SUBSTRING(@Fecha, 7,4) + SUBSTRING(@Fecha, 4,2) + SUBSTRING(@Fecha, 1,2)
	SET @Cont = 0
	SET @DniSeleccionadora = ''

	--ELIMINAOMOS LAS EFICIENCIAS ANTERIORES
	DELETE	FROM SJ_EficienciaOperador
	WHERE	IdAsistencia = @IdAsistencia and IdArea = '02'

    DECLARE limpieza_cursor CURSOR FOR

    SELECT	EO.DniTrabajador,
			A.IdArea,
			Pd.IdLinea,
			ISNULL(Count(EO.Dnitrabajador),0) as Cantidad,
			----MOSTRAR LINEA Y POSICIONES ULTIMAS
			Max(ISNULL(PD.IdGrupo,'')) as IdGrupo,
			EO.IdLote
	FROM	SJ_EficienciaOperador as EO
			left join SJ_Area as A on EO.IdArea = A.IdArea
			left join SJ_PersonalPlanta as PP on EO.DniTrabajador = PP.DniTrabajador
			left join
			(
				select	posd.IdAsistencia,
						posd.DniTrabajador,
						posd.IdArea,
						Max(posd.IdLinea) as IdLinea, 
						Max(posd.IdPosicion) as IdPosicion,
						Max(pos.IdGrupo) as IdGrupo
				from	SJ_PosicionDiaria AS posd
						Left Join SJ_Posicion as pos on pos.IdPosicion = posd.IdPosicion
							and pos.IdLinea = posd.IdLinea and pos.IdArea = posd.IdArea
				where	IdAsistencia = @IdAsistencia
				group by posd.IdAsistencia, posd.DniTrabajador, posd.IdArea
			) PD ON 
					PD.IdAsistencia = @IdAsistencia and
					EO.IdArea = PD.IdArea and
					EO.DniTrabajador = PD.DniTrabajador
	WHERE	--(EO.FechaHoraRegistro >= '21/09/2011 00:00:00' and EO.FechaHoraRegistro <= '21/09/2011 23:59:59')
			EO.IdAsistencia = @IdAsistencia
			and A.IdArea IN('01')
	GROUP	BY EO.DniTrabajador, A.IdArea , PD.IdLinea, EO.IdLote
	ORDER	BY Max(ISNULL(PD.IdGrupo,'')), Isnull(Count(EO.Dnitrabajador),0),A.IdArea


    OPEN limpieza_cursor
    FETCH NEXT FROM limpieza_cursor INTO @Dni, @IdArea, @IdLinea, @Cantidad , @IdGrupo, @IdLote
 
    IF @@FETCH_STATUS <> 0
        PRINT '         <<None>>'    
 
    WHILE @@FETCH_STATUS = 0
    BEGIN
 
        --PRINT @Dni + ' ' + @IdGrupo + ' ' + @IdLote

		IF EXISTS(SELECT	AP.DniTrabajador, 
							AP.Item, AP.IdAsistencia, ISNULL(PP.IdCodigoGeneral,'') AS IdCodigoGeneral,
							ISNULL(PP.ApellidosNombres,'DESCONOCIDO') AS ApellidosNombres,
							ISNULL(AP.IdArea,'') as IdArea, ISNULL(AR.Descripcion,'') as Area,
							pos.IdGrupo,
							AP.Fecha as FechaAsistencia
					FROM	dbo.SJ_AsistenciaDetalle as AP
							LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
							LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
							LEFT JOIN SJ_Posicion AS pos on pos.IdPosicion = AP.IdPosicion
										and pos.IdArea = AP.IdArea and pos.IdLinea = AP.IdLinea
					WHERE	IdAsistencia = @IdAsistencia AND AP.IdArea = '02' 
							and pos.IdGrupo = @IdGrupo 
							and pos.IdLinea = @IdLinea
				  )
		BEGIN
			-- buscamos el dni de la seleccionadora
			--********************************************
			SELECT	@DniSeleccionadora = AP.DniTrabajador
					FROM	dbo.SJ_AsistenciaDetalle as AP
							LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
							LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
							LEFT JOIN SJ_Posicion AS pos on pos.IdPosicion = AP.IdPosicion
										and pos.IdArea = AP.IdArea and pos.IdLinea = AP.IdLinea
					WHERE	IdAsistencia = @IdAsistencia AND AP.IdArea = '02' 
							and pos.IdGrupo = @IdGrupo 
							and pos.IdLinea = @IdLinea

			--INICIAMOS LA INSERCION DE ASISTENCIAS 
			--PRINT 'OK'

			WHILE(@Cont < @Cantidad)
			BEGIN

				SET @Cont = @Cont +1
				--PRINT cONVERT(VARCHAR,@Cont) + '  ' + @DniSeleccionadora

				INSERT INTO SJ_EficienciaOperador(IdAsistencia, FechaAsistencia, IdArea,
												DniTrabajador, DniSupervisor, IdLote,
												IdFormato, FechaHoraRegistro, FechaHoraTransferencia)
				VALUES(@IdAsistencia, Convert(DateTime,@Fecha), '02', @DniSeleccionadora, '', @IdLote, '', Convert(DateTime,@Fecha), GetDate())
	
			END

			--PRINT '--------------------------'			
			SET @Cont = 0

		END
		ELSE
			PRINT 'DNI NO ENCONTRADO -> ' + @Dni + '  Area : ' + @IdArea + '  Grupo : ' + @IdGrupo
		 
        FETCH NEXT FROM limpieza_cursor INTO @Dni, @IdArea, @IdLinea, @Cantidad , @IdGrupo, @IdLote

    END
 
    CLOSE limpieza_cursor
    DEALLOCATE limpieza_cursor
 

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_FormatoFirmaAsistenciaPlanta]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  EXEC SJ_FormatoFirmaAsistenciaPlanta '21/09/2011 00:00:00','21/09/2011 23:59:59'

CREATE PROCEDURE [dbo].[SJ_FormatoFirmaAsistenciaPlanta]
(
	@FechaInicio varchar(20),
	@FechaFinal varchar(20)
)
AS
BEGIN
		SELECT	ISNULL(pp.IdCodigoGeneral,'') as Codigo, ISNULL(pp.ApellidosNombres, '') as Nombres, 
				ISNULL(pd.DniTrabajador,'') as Dni, 
				pd.Fecha as FechaHoraIngreso,
				'13:00:00' as HoraInicioRefrigerio, '14:00:00' as HoraFinalRefrigerio,
				' ' as FechaHoraSalida,
				' ' as FechaHoraInicioExtra,
				' ' as FechaHoraFinalExtra,
				' ' as Firma,
				ar.IdCentroCosto, ar.IdActividad, IdLabor,
				' ' as TotalHoras,
				pd.IdArea,
				pd.DniSupervisor, ISNULL(pps.ApellidosNombres, 'Desconocido') as Supervisor
		FROM	SJ_PosicionDiaria as pd
				LEFT JOIN SJ_PersonalPlanta as pp on pd.DniTrabajador = pp.DniTrabajador
				LEFT JOIN SJ_PersonalPlanta as pps on pd.DniSupervisor = pps.DniTrabajador
				LEFT JOIN SJ_Area as ar on pd.IdArea = ar.IdArea
		WHERE	pd.Fecha >= @FechaInicio and pd.Fecha<= @FechaFinal
				--AND ISNULL(pp.IdCodigoGeneral,'') != ''
		ORDER	BY ISNULL(pp.ApellidosNombres, '') DESC, ar.IdArea

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ReporteCosechaUva]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- EXEC SJ_ReporteCosechaUva '15/11/2010 00:00:00', '15/11/2010 23:59:59'

CREATE PROCEDURE [dbo].[SJ_ReporteCosechaUva]
(
	@FechaInicio varchar(20),
	@FechaFinal varchar(20)
)
AS
BEGIN
	--set dateformat dmy
	SELECT	Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral,
			EO.DniTrabajador,
			Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) As Nombres,
			Max(ISNULL(A.Descripcion,'0')) as Area,
			Max(ISNULL(A.IdMedida,'')) as IdMedida,
			ISNULL(Count(EO.Dnitrabajador),0) as Cantidad,
			Max(EO.FechaHoraRegistro) as Fecha
	FROM	SJ_EficienciaOperador as EO
			left join SJ_Area as A on EO.IdArea = A.IdArea
			left join SJ_PersonalPlanta as PP on EO.DniTrabajador = PP.DniTrabajador
	WHERE	(EO.FechaHoraRegistro >= @FechaInicio and EO.FechaHoraRegistro <= @FechaFinal)
			AND A.IdArea = '00'
	GROUP	BY EO.DniTrabajador
	ORDER	BY Isnull(Count(EO.Dnitrabajador),0) DESC
END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ListarEficienciasOperadoresPagoJornal]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--- CREADO EL 11/11/2010
--******************************************************************
-- LA CONSULTA SIMPRE DEBE DE SER AGRUPADO POR
-- FORMATO, DE LOS CONTRARIO SALE UN ERROR LOGICO EN LAS SUMAS.
-- 03-10-2011 - CHRISTIAN.
--******************************************************************
-- Exec SJ_ListarEficienciasOperadoresPagoJornal '21/10/2011 00:00:00', '21/10/2011 23:59:59','20111021', '03', 'SI'

--***********************************************
-- TRABAJADO EN CASA EL DIA 30/10/2011
-- TRABAJADO POR CHRISTIAN LL.

CREATE PROCEDURE [dbo].[SJ_ListarEficienciasOperadoresPagoJornal]
(
	@FechaInicio varchar(20),
	@FechaFinal varchar(20),
	@IdAsistencia char(8),
	@IdArea char(2),
	@AgrupandoFormato char(2)
)
AS
BEGIN
	SET @AgrupandoFormato = 'SI'
	--**************************** FORMATO AGRUPADO ************************************
	IF(@AgrupandoFormato = 'SI')
		IF((SELECT DATEDIFF(day, @FechaInicio, @FechaFinal)) = 0)
		BEGIN
			SELECT	ISNULL(EO.IdCodigoGeneral,'') AS IdCodigoGeneral,
					EO.DniTrabajador,
					ISNULL(EO.Nombres,'DESCONOCIDO') As Nombres,
					ISNULL(EO.IdArea,'0') as IdArea,
					ISNULL(EO.Area,'0') as Area,
					ISNULL(EO.CC,'') as CC,
					ISNULL(EO.Act,'') as Act,
					ISNULL(EO.Lab,'') as Lab,
					ISNULL(EO.IdMedida,'') as IdMedida,
					ISNULL(EO.Cantidad,0) as Cantidad,
					EO.Fecha as Fecha,
					----MOSTRAR LINEA Y POSICIONES ULTIMAS
					ISNULL(EO.LineaTrabajo,'') as LineaTrabajo,
					ISNULL(EO.Posicion,'') as Posicion,
					EO.IdFormato,
					----------------------------------------------------
					cp.Cantidad as CantidadNormal,
					cp.Importe as ImporteNormal,
				    cp.CantidadExtra as CantidadExtra,
					cp.ImporteExtra as ImporteExtra,
					cp.Precio as PrecioNormal,
					cp.PrecioExtra as PrecioExtra,
					cp.HorasTrabajadas as HorasTrabajadas,
					cp.EstandarNormal as EstandarNormal,
					cp.EstandarExtra as EstandarExtra,
					----------------------------------------------------
					HorasReal = ISNULL((SELECT dbo.SJFU_ObtenerConversionHoras(@FechaInicio, ISNULL(cp.Importe,0))),0),
					DiasTrabajados = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@FechaInicio, 0, ISNULL(EO.IdArea,'0'), 'DIAST', '00', EO.DniTrabajador)),
					DiasTrabajadosProceso = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@FechaInicio, 0, ISNULL(EO.IdArea,'0'), 'DIASP', '00', EO.DniTrabajador))
			FROM	dbo.v_EficienciasPlanta as EO
					left join SJ_ControlPagosEficiencias as cp on cp.DniTrabajador = EO.DniTrabajador
							  and cp.IdArea = EO.IdArea 
							  and cp.IdAsistencia = EO.IdAsistencia
							  and cp.IdFormato = EO.IdFormato
			WHERE	EO.IdAsistencia = @IdAsistencia
					and EO.IdArea = @IdArea
			--ORDER	EO.DniTrabajador
	
		END

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ReporteAsistenciaPlantaDetallado]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  exec SJ_ReporteAsistenciaPlantaDetallado '20111102'
  
CREATE PROCEDURE [dbo].[SJ_ReporteAsistenciaPlantaDetallado]  
(  
 @IdAsistenciaInicio char(8)  
 --@IdAsistenciaFin char(8)  
)  
AS  
BEGIN  
  
	declare @Fecha varchar(20)
	set @Fecha = substring(@IdAsistenciaInicio,7,2) + '/' + 
				 substring(@IdAsistenciaInicio,5,2) + '/' + 
				 substring(@IdAsistenciaInicio,1,4) + ' 00:00:00'

  SELECT AP.Item, AP.IdAsistencia, ISNULL(PP.IdCodigoGeneral,'') AS IdCodigoGeneral,   
    AP.DniTrabajador,   
    ISNULL(PP.ApellidosNombres,'DESCONOCIDO') AS ApellidosNombres,  
    ISNULL(AP.IdArea,'') as IdArea, ISNULL(AR.Descripcion,'') as Area,  
    AP.Fecha as FechaAsistencia,  
    ISNULL(AR.IdCentroCosto,'') as IdCentroCosto,  
    ISNULL(AR.IdActividad,'') as IdActividad,  
    ISNULL(AR.IdLabor,'') as IdLabor,  
    AP.DniSupervisor,  
    ISNULL(SU.ApellidosNombres,'DESCONOCIDO') as Supervisor,   
    AP.FechaHoraIngreso as FechaHoraIngreso,   
    AP.FechaHoraSalida as FechaHoraSalida,  
    MinTrabajadas = DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida),  
    MinutosRefrigerio = ((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +  
         (dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)),  
         
    HorasTrabajadas = Convert(decimal(17,2),(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) / 60.00 ),  
     
    HorasRefrigerio = Convert(decimal(17,2),((((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +  
         (dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)))/60.00)),  
      
    HorasTotalTrabajadas = Convert(decimal(17,2),((DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) -  
            (  
          ((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +  
          (dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida))  
          )) / 60.00),  
  
    AP.DetalleInconsistencia ,
	DiasTrabajados = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, 0, ISNULL(AP.IdArea,'0'), 'DIASP', '00', AP.DniTrabajador))
  FROM dbo.SJ_AsistenciaDetalle as AP  
    LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador  
    LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador  
    LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea  
  WHERE IdAsistencia = @IdAsistenciaInicio --and IdAsistencia <= @IdAsistenciaFin  
  --ORDER BY ISNULL(SU.ApellidosNombres,'DESCONOCIDO'),AP.IdArea--ISNULL(PP.ApellidosNombres,'DESCONOCIDO') ,AP.IdArea  
END  
  










--
----  exec SJ_ReporteAsistenciaPlantaDetallado '20110922'
--				
--ALTER PROCEDURE SJ_ReporteAsistenciaPlantaDetallado
--(
--	@IdAsistenciaInicio char(8)
--	--@IdAsistenciaFin char(8)
--)
--AS
--BEGIN
--		--2011 10 21
--		declare @Fecha varchar(20)
--		set @Fecha =	substring(@IdAsistenciaInicio,7,2) + '/' + 
--						substring(@IdAsistenciaInicio,5,2) + '/' + 
--						substring(@IdAsistenciaInicio,1,4) + ' 00:00:00'
--	
--		SELECT	AP.Item, AP.IdAsistencia, ISNULL(PP.IdCodigoGeneral,'') AS IdCodigoGeneral, 
--				AP.DniTrabajador, 
--				ISNULL(PP.ApellidosNombres,'DESCONOCIDO') AS ApellidosNombres,
--				ISNULL(AP.IdArea,'') as IdArea, ISNULL(AR.Descripcion,'') as Area,
--				AP.Fecha as FechaAsistencia,
--				ISNULL(AR.IdActividad,'') as IdActividad,
--				ISNULL(AR.IdLabor,'') as IdLabor,
--				AP.DniSupervisor,
--				ISNULL(SU.ApellidosNombres,'DESCONOCIDO') as Supervisor, 
--				AP.FechaHoraIngreso as FechaHoraIngreso, 
--				AP.FechaHoraSalida as FechaHoraSalida,
--				MinTrabajadas = DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida),
--				MinutosRefrigerio = ((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
--									(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)),
--							
--				HorasTrabajadas = Convert(decimal(17,2),(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) / 60.00 ),
--			
--				HorasRefrigerio = Convert(decimal(17,2),((((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
--									(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)))/60.00)),
--				
--				HorasTotalTrabajadas = Convert(decimal(17,2),((DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) -
--									   (
--										((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
--										(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(@IdAsistenciaInicio, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida))
--										)) / 60.00),
--
--				AP.DetalleInconsistencia,
--				DiasTrabajados = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, 0, ISNULL(AP.IdArea,'0'), 'DIAST', '00', AP.DniTrabajador))
--		FROM	dbo.SJ_AsistenciaDetalle as AP
--				LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
--				LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador
--				LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
--		WHERE	IdAsistencia = @IdAsistenciaInicio --and IdAsistencia <= @IdAsistenciaFin
--		--ORDER BY ISNULL(SU.ApellidosNombres,'DESCONOCIDO'),AP.IdArea--ISNULL(PP.ApellidosNombres,'DESCONOCIDO') ,AP.IdArea
--		
--
--END
--
GO
/****** Object:  View [dbo].[v_SJDetalleAsistencia]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_SJDetalleAsistencia]
AS
SELECT			AP.Item, AP.IdAsistencia, ISNULL(PP.IdCodigoGeneral,'') AS IdCodigoGeneral, 
				AP.DniTrabajador, 
				ISNULL(PP.ApellidosNombres,'DESCONOCIDO') AS ApellidosNombres,
				ISNULL(AP.IdArea,'') as IdArea, ISNULL(AR.Descripcion,'') as Area,
				AP.Fecha as FechaAsistencia,
				ISNULL(AR.IdCentroCosto,'') as IdCentroCosto,
				ISNULL(AR.IdActividad,'') as IdActividad,
				ISNULL(AR.IdLabor,'') as IdLabor,
				AP.DniSupervisor,
				ISNULL(SU.ApellidosNombres,'DESCONOCIDO') as Supervisor, 
				AP.FechaHoraIngreso as FechaHoraIngreso, 
				AP.FechaHoraSalida as FechaHoraSalida,
				MinTrabajadas = DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida),
				MinutosRefrigerio = ((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
									(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)),
							
				HorasTrabajadas = Convert(decimal(17,2),(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) / 60.00 ),
			
				HorasRefrigerio = Convert(decimal(17,2),((((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
									(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida)))/60.00)),
				
				HorasTotalTrabajadas = Convert(decimal(17,2),((DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) -
									   (
										((dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'HH', AP.FechaHoraIngreso, AP.FechaHoraSalida)) * 60) +
										(dbo.SJFU_ObtenerTiempoRefrigerioDetallado(AP.IdAsistencia, 'MM', AP.FechaHoraIngreso, AP.FechaHoraSalida))
										)) / 60.00),

				AP.DetalleInconsistencia
		FROM	dbo.SJ_AsistenciaDetalle as AP
				LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
				LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador
				LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
GO
/****** Object:  View [dbo].[v_SJAsistenciaDiaria]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_SJAsistenciaDiaria]
AS
SELECT	AP.IdAsistencia, Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral, 
			AP.DniTrabajador, 
			Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) AS ApellidosNombres,
			Max(AP.IdArea) as IdArea, Max(AR.Descripcion) as Area,
			Max(AP.Fecha) as FechaAsistencia,
			Max(AR.IdActividad) as IdActividad,
			Max(AR.IdLabor)as IdLabor,
			Max(AP.DniSupervisor) as DniSupervisor,
			Max(ISNULL(SU.ApellidosNombres,'DESCONOCIDO')) as Supervisor, 
			Min(AP.FechaHoraIngreso) as FechaHoraIngreso, 
			Max(AP.FechaHoraSalida) as FechaHoraSalida,
			--TOTAL DE TIEMPOS TRABAJADOS
			MinTrabajadas = SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)),
			MinRefrigerio = ((select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'HH', Max(AP.FechaHoraSalida))) * 60) +
									(select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'MM', Max(AP.FechaHoraSalida))),

			-- TOTAL HORAS TRABAJADAS Y HORAS REFRIGERIO
			HorasTrabajadas = Convert(Decimal(17,2),SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)) / 60.00),

			HorasRefrigerio = Convert(Decimal(17,2),(((select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'HH', Max(AP.FechaHoraSalida))) * 60) +
									(select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'MM', Max(AP.FechaHoraSalida)))) / 60.00),

			TotalHorasTrabajadas = Convert(Decimal(17,2),(((SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida))) - 
									 (((select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'HH', Max(AP.FechaHoraSalida))) * 60) + 
									   (select dbo.SJFU_ObtenerTiempoRefrigerio(AP.IdAsistencia, 'MM', Max(AP.FechaHoraSalida))))) / 60.00)),

			Min(AP.DetalleInconsistencia) as DetalleInconsistencia,
			Count(ISNULL(AP.DniTrabajador,0)) as NAreas
	FROM	dbo.SJ_AsistenciaDetalle as AP
			LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
			LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador
			LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
	WHERE AP.IdAsistencia >= '20101118'
	GROUP By AP.IdAsistencia, AP.DniTrabajador
GO
/****** Object:  UserDefinedFunction [dbo].[SJFU_ObtenerImporteAvance]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  select dbo.SJFU_ObtenerImporteAvance('29/10/2011 00:00:00', 160, '01', 0, '00', '')
--  select dbo.SJFU_ObtenerImporteAvance('29/10/2011 00:00:00', 150, '01', 1, '00', '')

	-- SELECT dbo.SJFU_ObtenerInformacionEstandares('17/10/2011 00:00:00', 0, '01', 'HRSTR', '00','')

CREATE FUNCTION [dbo].[SJFU_ObtenerImporteAvance]
(
	@Fecha varchar(20),
	@Cantidad decimal(17,6),
	@IdArea char(2),
	@EsExtra int,
	@IdFormato char(2),
	@DniTrabajador char(8)
)
RETURNS DECIMAL(17,2) AS 
BEGIN
	
	DECLARE	@FechaInicioProceso varchar(20)
	DECLARE	@FechaFinProceso varchar(20)
	DECLARE @HorasTrabajadas decimal(17,2)
	DECLARE @Estandar_x_HorasTrab decimal(17,2)

	SET @FechaInicioProceso = '21/09/2011 00:00:00'
	SET @FechaFinProceso = (SUBSTRING(@Fecha, 1, 10) + ' 23:59:59')

	DECLARE @RetValue decimal(17,2)
	DECLARE @CantEstandar decimal(17,6)
	DECLARE @CantEstandarExtra decimal(17,6)
	DECLARE	@PrecioEstandar decimal(17,6)

	DECLARE	@PrecioPrimerDia decimal(17,6)
	DECLARE	@PrecioSegundoDia decimal(17,6)
	
	DECLARE	@CantidadDias decimal(17,6)

	DECLARE @CantExtra decimal(17,6)
	DECLARE	@PrecioExtra decimal(17,6)

	SET @RetValue = 0
	
	--OBTENEMOS LA CANTIDAD DE HORAS TRABAJADAS x AREA
	SET @HorasTrabajadas = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, 0, @IdArea, 'HRSTR', @IdFormato, @DniTrabajador))
	
	--**************************************************************************************
	--CANTIDAD DE DIAS QUE TIENE TRABAJANDO
	--SI ES MAYOR A TRES DIAS NO SE CONSIDERA PORCENTAJE JORNAL ESPECIAL
	--MOF. EL DIA 04/11/2011 POR CHRISTIAN.
	--LA CANT. DE DIAS TRABAJADADOS EN EL AREA RESPECTIVA.
	------------------------------------------------------------------------------
	SET @CantidadDias = (SELECT  COUNT(Cont) as Cont
						 FROM	
									(SELECT	COUNT(IdAsistencia) as Cont
									 FROM	SJ_AsistenciaDetalle
									 WHERE	Fecha >= @FechaInicioProceso and Fecha <= @FechaFinProceso
											and DniTrabajador = @DniTrabajador
											and IdArea = @IdArea
									 GROUP	by IdAsistencia) AS T)

	SET @PrecioEstandar = (	SELECT	TOP 1 PrecioUnitario
							FROM	SJ_Estandar
							WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
									and IdArea = @IdArea
									and IdFormato = @IdFormato)

	--**************************************************************************************
	--CALCULA LOS JORNALES DE TODAS LAS PERSONAS
	--QUE TIENES MAS DE TRES DIAS TRABAJANDO
	--**************************************************************************************
	IF(@CantidadDias = 1)
	BEGIN
		SET @PrecioPrimerDia = (SELECT	TOP 1 PrecioPrimerDia
						        FROM	SJ_Estandar
						        WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
									    and IdArea = @IdArea
									    and IdFormato = @IdFormato)

		SET @PrecioEstandar = @PrecioPrimerDia
	END

	IF(@CantidadDias = 2)
	BEGIN
		SET @PrecioSegundoDia = (SELECT TOP 1 PrecioSegundoDia
						         FROM	SJ_Estandar
						         WHERE  @Fecha >= FechaInicio and @Fecha <= FechaFinal
										and IdArea = @IdArea
										and IdFormato = @IdFormato)
		SET @PrecioEstandar = @PrecioSegundoDia
	END

	--********************************************************************************
	--********************************************************************************

	SET @CantEstandar = (SELECT	TOP 1 Estandar
						 FROM	SJ_Estandar
						 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
								and IdArea = @IdArea
								and IdFormato = @IdFormato)

	--CALCULAMOS EL ESTANDAR POR LAS HORAS TRABAJADAS
	SET @Estandar_x_HorasTrab = ((@CantEstandar) * @HorasTrabajadas) / 8


--COMENTADO TEMPORALMENTE DESDE EL 06-12-11
--POR ENCARGO DE LUCERO
------------------------------------------------------------
--	IF(@HorasTrabajadas <= 8.0)
--		SET @Estandar_x_HorasTrab = @CantEstandar
------------------------------------------------------------
	
	SET @CantEstandarExtra = (SELECT	TOP 1 EstandarExtra
							  FROM		SJ_Estandar
							  WHERE		@Fecha >= FechaInicio and @Fecha <= FechaFinal
										and IdArea = @IdArea
										and IdFormato = @IdFormato)

	IF(@Cantidad > @Estandar_x_HorasTrab)
	BEGIN
		SET @CantExtra = @Cantidad - @Estandar_x_HorasTrab
		--SET @CantExtra = @Cantidad - @CantEstandarExtra
	END
	ELSE
		SET @CantExtra = 0
		

	SET @PrecioExtra =	(SELECT	TOP 1 PrecioUnitarioExtra
						 FROM	SJ_Estandar
						 WHERE	@Fecha >= FechaInicio and @Fecha <= FechaFinal
								and IdArea = @IdArea
								and IdFormato = @IdFormato)

	--CALCULO DE TOTAL DE HECTAREAS DE ACUERDO A UN PERIODO

	IF(@EsExtra >= 1)
	BEGIN
		IF(@CantExtra <= 0)
			SELECT @RetValue = 0
		ELSE
			SELECT @RetValue = @CantExtra * @PrecioExtra
	END
	ELSE
	BEGIN
		--IF(@Cantidad > @CantEstandar)
		IF(@Cantidad > @Estandar_x_HorasTrab)
			SELECT @RetValue = @Estandar_x_HorasTrab * @PrecioEstandar
		ELSE
			SELECT @RetValue = @Cantidad * @PrecioEstandar
	END

	--FIN DEL CALCULO PARA LAS PERSONAS CON MAS TRES DIAS TRABAJANDO
	--END
	
	
	RETURN @retValue

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ListarAsistenciaAgrupadaPorArea]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--EXEC SJ_ListarAsistenciaAgrupadaPorArea '20101129'


CREATE PROCEDURE [dbo].[SJ_ListarAsistenciaAgrupadaPorArea]
(
	@IdAsistencia char(8)
)
AS
BEGIN
	SELECT  IdAsistencia, 
			Max(IdCodigoGeneral) as IdCodigoGeneral, 
			DniTrabajador, 
			Max(ApellidosNombres) as ApellidosNombres,
			IdArea, Max(Area) as Area, 
			Max(IdCentroCosto) as IdCentroCosto, 
			Max(IdActividad) as IdActividad, Max(IdLabor) as IdLabor, 
			Max(DniSupervisor) as DniSupervisor, Max(Supervisor) as Supervisor, 
			Min(FechaHoraIngreso) as FechaHoraIngreso, Max(FechaHoraSalida) as FechaHoraSalida,
			Sum(MinTrabajadas) as MinTrabajadas, Sum(MinutosRefrigerio) as MinutosRefrigerio, 
			Sum(HorasTrabajadas) as HorasTrabajadas, Sum(HorasRefrigerio) as HorasRefrigerio, 
			Sum(HorasTotalTrabajadas) as HorasTotalTrabajadas, 
			Min(DetalleInconsistencia) as DetalleInconsistencia
	FROM	v_SJDetalleAsistencia as dt
	WHERE	IdAsistencia = @IdAsistencia
	GROUP BY IdAsistencia, DniTrabajador, IdArea

END
GO
/****** Object:  StoredProcedure [dbo].[SJ_ReporteAsistenciaPlantaAgrupado]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--  exec SJ_ReporteAsistenciaPlantaAgrupado '20101118','20101118'

CREATE PROCEDURE [dbo].[SJ_ReporteAsistenciaPlantaAgrupado]
(
	@IdAsistenciaInicio char(8),
	@IdAsistenciaFin char(8)
)
AS
BEGIN
	
	SELECT 	Max(IdAsistencia) as IdAsistencia, Max(IdCodigoGeneral) as IdCodigoGeneral,
			DniTrabajador, Max(ApellidosNombres) as ApellidosNombres, 
			Max(IdArea) as IdArea, Max(Area) as Area, Max(FechaAsistencia) as FechaAsistencia, 
			Max(IdActividad) as IdActividad, Max(IdLabor) as IdLabor, 
			Max(DniSupervisor) as DniSupervisor, Max(Supervisor) as Supervisor, 
			Max(FechaHoraIngreso) as FechaHoraIngreso, Max(FechaHoraSalida) as FechaHoraSalida, 
			Sum(MinTrabajadas) as MinTrabajadas, 
			Sum(MinRefrigerio) as MinRefrigerio,
			Sum(HorasTrabajadas) as HorasTrabajadas,
			Sum(HorasRefrigerio) as HorasRefrigerio,
			Sum(TotalHorasTrabajadas) as TotalHorasTrabajadas,
			Min(DetalleInconsistencia) as DetalleInconsistencia,
			Sum(NAreas) as NAreas,
			Count(DniTrabajador) as Dias
	FROM    v_SJAsistenciaDiaria
	WHERE   IdAsistencia >= @IdAsistenciaInicio AND IdAsistencia <= @IdAsistenciaFin
	GROUP BY DniTrabajador

END






--
--
-------   NOTA : LAS HORAS DE REFRIGERIO SOLO SE MOSTRARAN O SERAN VALIDAS
--	-----   CUANDO SE AGRUPEN POR IDASISTENCIA Y DNI TRABAJADOR
--	-----	MAS NO CUANDO SE AGRUPE SOLO POR DNI EN UN RANGO DE FECHAS
--	IF(@AgrupadoPorDni = 'NO')
--	BEGIN
--		SELECT	AP.IdAsistencia, Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral, 
--				AP.DniTrabajador, 
--				Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) AS ApellidosNombres,
--				Max(AP.IdArea) as IdArea, Max(AR.Descripcion) as Area,
--				Max(AP.Fecha) as FechaAsistencia,
--				Max(AR.IdActividad) as IdActividad,
--				Max(AR.IdLabor)as IdLabor,
--				Max(AP.DniSupervisor) as DniSupervisor,
--				Max(ISNULL(SU.ApellidosNombres,'DESCONOCIDO')) as Supervisor, 
--				Min(AP.FechaHoraIngreso) as FechaHoraIngreso, 
--				Max(AP.FechaHoraSalida) as FechaHoraSalida,
--				--TOTAL DE TIEMPOS TRABAJADOS
--				DiasTrabajados = SUM(DATEDIFF(day, AP.FechaHoraIngreso, AP.FechaHoraSalida)),
--				MinTrabajadas = SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)),
--				MinRefrigerio = ((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) +
--										(select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida))),
--				MinDescanso = 0,
--				-- TOTAL MINUTOS TRABAJADOS = MIN_TRABAJADOS - MIN_REFRIGERIO - (MIN_DESCNSO **FALTA**)
--				TotalMinutosTrabajados = (SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida))) - 
--										 (((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) + 
--										   (select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida)))),
--
--				TotalHorasTrabajadas = Convert(Decimal(17,2),(((SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida))) - 
--										 (((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) + 
--										   (select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida))))) / 60.00)),
--
--				Min(AP.DetalleInconsistencia) as DetalleInconsistencia,
--				Count(AP.DniTrabajador) as NAreas
--		FROM	dbo.SJ_AsistenciaDetalle as AP
--				LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
--				LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador
--				LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
--		WHERE	IdAsistencia >= @IdAsistenciaInicio and IdAsistencia <= @IdAsistenciaFin
--		GROUP By AP.IdAsistencia, AP.DniTrabajador
--		ORDER BY AP.IdAsistencia, Max(AP.IdArea), Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO'))
--	END
--	ELSE
--		SELECT	Max(AP.IdAsistencia) as IdAsistencia, Max(ISNULL(PP.IdCodigoGeneral,'')) AS IdCodigoGeneral, 
--				AP.DniTrabajador, 
--				Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO')) AS ApellidosNombres,
--				Max(AP.IdArea) as IdArea, Max(AR.Descripcion) as Area,
--				Max(AP.Fecha) as FechaAsistencia,
--				Max(AR.IdActividad) as IdActividad,
--				Max(AR.IdLabor)as IdLabor,
--				Max(AP.DniSupervisor) as DniSupervisor,
--				Max(ISNULL(SU.ApellidosNombres,'DESCONOCIDO')) as Supervisor, 
--				Min(AP.FechaHoraIngreso) as FechaHoraIngreso, 
--				Max(AP.FechaHoraSalida) as FechaHoraSalida,
--				--TOTAL DE TIEMPOS TRABAJADOS EN MINUTOS
--				MinTrabajadas = SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida)),
--				MinRefrigerio = ((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) +
--										(select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida))),
--				MinDescanso = 0,
--				-- TOTAL MINUTOS TRABAJADOS = MIN_TRABAJADOS - MIN_REFRIGERIO - (MIN_DESCNSO **FALTA**)
--				TotalMinutosTrabajados = (SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida))) - 
--										 (((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) + 
--										   (select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida)))),
--
--				TotalHorasTrabajadas = Convert(Decimal(17,2),(((SUM(DATEDIFF(minute, AP.FechaHoraIngreso, AP.FechaHoraSalida))) - 
--										 (((select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'HH', Max(AP.FechaHoraSalida))) * 60) + 
--										   (select dbo.SJFU_ObtenerTiempoRefrigerio(@IdAsistenciaInicio, 'MM', Max(AP.FechaHoraSalida))))) / 60.00)),
--
--				Min(AP.DetalleInconsistencia) as DetalleInconsistencia,
--				Count(AP.DniTrabajador) as NAreas
--		FROM	dbo.SJ_AsistenciaDetalle as AP
--				LEFT JOIN SJ_PersonalPlanta as PP on AP.DniTrabajador = PP.DniTrabajador
--				LEFT JOIN SJ_PersonalPlanta as SU on AP.DniSupervisor = SU.DniTrabajador
--				LEFT JOIN SJ_Area as AR on AP.IdArea = AR.IdArea
--		WHERE	IdAsistencia >= @IdAsistenciaInicio and IdAsistencia <= @IdAsistenciaFin
--		GROUP By AP.DniTrabajador
--		ORDER BY Max(AP.IdArea), Max(ISNULL(PP.ApellidosNombres,'DESCONOCIDO'))
GO
/****** Object:  StoredProcedure [dbo].[SJ_CalcularPagoEficiencias]    Script Date: 10/03/2012 09:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec SJ_CalcularPagoEficiencias '26/10/2011 00:00:00'

--*******************************************************
-- TRABAJADO EN CASA EL DIA 30/10/2011
-- TRABAJADO POR CHRISTIAN LL.

---*******************************************************

CREATE PROCEDURE [dbo].[SJ_CalcularPagoEficiencias]
(
	@Fecha varchar(20)
)
AS
BEGIN

	DECLARE @IdAsistencia varchar(20)
	SET @IdAsistencia = SUBSTRING(@Fecha, 7,4) + SUBSTRING(@Fecha, 4,2) + SUBSTRING(@Fecha, 1,2)
	
	--ELIMINAMOS LOS PAGOS YA GENERADOS EN ESTA FECHA
	--PARA VOLVER A GENERARLOS
	DELETE	FROM SJ_ControlPagosEficiencias
	WHERE	Fecha = @Fecha

	--ACTUALIZAMOS TODAS LAS EFICIENCIAS DE LIMPIEZA y SELECCION AL IDFORMATO 00
	--QUE ES UN FORMATO GENERAL
	UPDATE	SJ_EficienciaOperador SET IdFormato = '00'
	WHERE	IdAsistencia = @IdAsistencia and IdArea IN('01', '02')

	INSERT INTO SJ_ControlPagosEficiencias
	SELECT	ISNULL(EO.IdCodigoGeneral,'') AS IdCodigoGeneral,
			EO.DniTrabajador,
			ISNULL(EO.IdArea,'0') as IdArea,
			--CantidadesNormales = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'CANNN', EO.IdFormato, EO.DniTrabajador)),
			EO.Cantidad as CantidadesNormales,
			--------------------------------------------
			ImporteNormal = (SELECT dbo.SJFU_ObtenerImporteAvance(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 0, EO.IdFormato,EO.DniTrabajador)),
			CantidadesExtras = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'CANEX', EO.IdFormato,EO.DniTrabajador)),
			ImporteExtras = (SELECT dbo.SJFU_ObtenerImporteAvance(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 1, EO.IdFormato,EO.DniTrabajador)),
			PrecioEstandar = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'PREES', EO.IdFormato,EO.DniTrabajador)),
			PrecioExtra = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'PREEX', EO.IdFormato,EO.DniTrabajador)),
			ISNULL(EO.IdMedida,'') as IdMedida,
			Convert(DateTime,@Fecha) as Fecha,
			GetDate() as FechaCreacion,
			EO.IdFormato,
			HorasTrabajadas = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'HRSTR', EO.IdFormato,EO.DniTrabajador)),
			EstandarNormal = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'ESTES', EO.IdFormato,EO.DniTrabajador)),
			EstandarExtra = (SELECT dbo.SJFU_ObtenerInformacionEstandares(@Fecha, ISNULL((EO.Cantidad),0), ISNULL(EO.IdArea,''), 'ESTEX', EO.IdFormato,EO.DniTrabajador)),
			@IdAsistencia
			----MOSTRAR LINEA Y POSICIONES ULTIMAS
	FROM	dbo.v_EficienciasPlanta as EO
	WHERE	EO.IdAsistencia = @IdAsistencia and EO.IdArea IN ('01','02','03','04')
	--GROUP	BY EO.DniTrabajador, EO.IdArea, EO.IdFormato--, CO.InicialVariedad
	ORDER	BY ISNULL(EO.Cantidad,0), EO.IdArea

END
GO
/****** Object:  Default [DF_SJ_DeficienciaProducto_CantidadRacimos]    Script Date: 10/03/2012 09:44:46 ******/
ALTER TABLE [dbo].[SJ_DeficienciaProducto] ADD  CONSTRAINT [DF_SJ_DeficienciaProducto_CantidadRacimos]  DEFAULT ((0)) FOR [CantidadRacimos]
GO
