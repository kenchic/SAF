USE [master]
GO
/****** Object:  Database [SAF]    Script Date: 09/19/2015 00:31:22 ******/
CREATE DATABASE [SAF] ON  PRIMARY 
( NAME = N'SAF', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER2008\MSSQL\DATA\SAF.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SAF_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER2008\MSSQL\DATA\SAF_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SAF] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAF] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SAF] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SAF] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SAF] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SAF] SET ARITHABORT OFF
GO
ALTER DATABASE [SAF] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SAF] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SAF] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SAF] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SAF] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SAF] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SAF] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SAF] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SAF] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SAF] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SAF] SET  DISABLE_BROKER
GO
ALTER DATABASE [SAF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SAF] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SAF] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SAF] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SAF] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SAF] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SAF] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SAF] SET  READ_WRITE
GO
ALTER DATABASE [SAF] SET RECOVERY FULL
GO
ALTER DATABASE [SAF] SET  MULTI_USER
GO
ALTER DATABASE [SAF] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SAF] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'SAF', N'ON'
GO
USE [SAF]
GO
/****** Object:  User [saf]    Script Date: 09/19/2015 00:31:22 ******/
CREATE USER [saf] FOR LOGIN [saf] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[bdUnidadMedida]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdUnidadMedida](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdUnidadesMedidas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdTipoDocumento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdTipoDocumento](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Operacion] [varchar](1) NOT NULL,
 CONSTRAINT [PK_bdTiposDocumentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdCiudad]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdCiudad](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdCiudades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdCiudades_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdBodega]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdBodega](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdBodegas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdAgente]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdAgente](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdAgentes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdAgentes_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdConductor]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdConductor](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Placa] [varchar](50) NOT NULL,
 CONSTRAINT [PK_bdConductores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdConductores_Placa] UNIQUE NONCLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdListaPrecio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdListaPrecio](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdListasPrecios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdListasPrecios_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdGrupoElemento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdGrupoElemento](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdGruposElementos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdParametro]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdParametro](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TipoParametro] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdProveedor]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdProveedor](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Identificacion] [varchar](20) NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Iniciales] [char](5) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Direccion] [varchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdProveedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdProveedores_Iniciales] UNIQUE NONCLUSTERED 
(
	[Iniciales] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdProveedores_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdParametroSistema]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdParametroSistema](
	[Codigo] [char](10) NOT NULL,
	[idParametro] [smallint] NOT NULL,
	[Valor] [varchar](200) NOT NULL,
 CONSTRAINT [PK_ParametroSistema] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdElemento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdElemento](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idGruposElemento] [tinyint] NOT NULL,
	[idUnidadMedida] [tinyint] NOT NULL,
	[Referencia] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Mt2] [float] NOT NULL,
	[Peso] [float] NOT NULL,
	[Rotacion] [bit] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdElementos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdElementos_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdElementos_Referencia] UNIQUE NONCLUSTERED 
(
	[Referencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdDocumento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdDocumento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idTipoDocumento] [tinyint] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Descripcion] [varchar](1000) NULL,
	[Anulado] [bit] NOT NULL,
 CONSTRAINT [PK_bdMovimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdCliente]    Script Date: 09/19/2015 00:31:24 ******/
SET ARITHABORT ON
GO
SET CONCAT_NULL_YIELDS_NULL ON
GO
SET ANSI_NULLS ON
GO
SET ANSI_PADDING ON
GO
SET ANSI_WARNINGS ON
GO
SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
SET ARITHABORT ON
GO
CREATE TABLE [dbo].[bdCliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idCiudad] [smallint] NOT NULL,
	[Identificacion] [varchar](20) NOT NULL,
	[Nombre1] [varchar](25) NOT NULL,
	[Nombre2] [varchar](25) NOT NULL,
	[Apellido1] [varchar](25) NOT NULL,
	[Apellido2] [varchar](25) NOT NULL,
	[Nombre]  AS (((((([Nombre1]+' ')+[Nombre2])+' ')+[Apellido1])+' ')+[Apellido2]),
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Correo] [varchar](100) NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdClientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdClientes_Identificacion] UNIQUE NONCLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdClientes_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdDetalleDocumento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleDocumento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[idDocumento] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bd] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleListaPrecio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleListaPrecio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idListaPrecios] [tinyint] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[PrecioAlquiler] [int] NOT NULL,
	[PrecioVenta] [int] NOT NULL,
	[PrecioPerdida] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesListasPrecios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdMovimientoBodega]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdMovimientoBodega](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idElemeto] [smallint] NOT NULL,
	[idBodegaOrigen] [tinyint] NOT NULL,
	[idBodegaDestino] [tinyint] NOT NULL,
	[Documento] [varchar](20) NOT NULL,
	[Numero] [varchar](20) NOT NULL,
	[Operacion] [varchar](20) NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdMovimientosBodegas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdProyecto]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdProyecto](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idCiudad] [smallint] NOT NULL,
	[NombreCliente] [varchar](100) NOT NULL,
	[NombreCiudad] [varchar](100) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Tipo] [varchar](100) NOT NULL,
	[Direccion] [varchar](100) NULL,
	[Telefono] [varchar](50) NULL,
	[Observacion] [varchar](500) NULL,
	[Fecha] [date] NOT NULL,
	[FormaContacto] [varchar](10) NULL,
	[SistemaMedida] [varchar](10) NULL,
	[IdentificacionResponsable] [varchar](15) NULL,
	[NombreResponsable] [varchar](50) NULL,
	[TelResponsable] [varchar](50) NULL,
	[Activo] [bit] NOT NULL,
	[Estado] [tinyint] NOT NULL,
 CONSTRAINT [PK_bdProyectos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdContrato]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdContrato](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idListaPrecios] [tinyint] NOT NULL,
	[idAgente] [smallint] NULL,
	[InformacionBD] [bit] NOT NULL,
	[ContratoAlquiler] [bit] NOT NULL,
	[CartaPagare] [bit] NOT NULL,
	[Pagare] [bit] NOT NULL,
	[LetraCambio] [bit] NOT NULL,
	[GarantiasCondiciones] [bit] NOT NULL,
	[Deposito] [bit] NOT NULL,
	[Anticipo] [bit] NOT NULL,
	[PersonaJuridica] [bit] NOT NULL,
	[PersonaNatural] [bit] NOT NULL,
	[FotoCopiaCedula] [bit] NOT NULL,
	[FotoCopiaNit] [bit] NOT NULL,
	[CamaraComercio] [bit] NOT NULL,
	[DescuentoAlquiler] [tinyint] NOT NULL,
	[DescuentoVenta] [tinyint] NOT NULL,
	[DescuentoReposicion] [tinyint] NOT NULL,
	[DescuentoMantenimiento] [tinyint] NOT NULL,
	[DescuentoTransporte] [tinyint] NOT NULL,
	[PorcentajeAgente] [tinyint] NULL,
 CONSTRAINT [PK_bdContratos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdProyectoVenta]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdProyectoVenta](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idProyecto] [smallint] NOT NULL,
 CONSTRAINT [PK_bdProyectosVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdProyectoAlquiler]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdProyectoAlquiler](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idProyecto] [smallint] NOT NULL,
 CONSTRAINT [PK_bdProyectosAlquiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDevolucion]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDevolucion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idProyecto] [smallint] NOT NULL,
	[idConductor] [smallint] NULL,
	[Numero] [int] NOT NULL,
	[FechaAnunciada] [date] NULL,
	[FechaRecogida] [date] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[EntregaCliente] [bit] NULL,
	[EntregaParcial] [bit] NULL,
	[TipoMantenimiento] [tinyint] NULL,
	[Hora] [time](7) NULL,
	[Anulado] [bit] NULL,
	[ValorTransporte] [numeric](8, 0) NULL,
	[PesoEquipo] [numeric](6, 2) NULL,
	[ValorEquipo] [numeric](10, 0) NULL,
 CONSTRAINT [PK_bdDevoluciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdDevoluciones_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdCorte]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdCorte](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idProyectoVenta] [smallint] NULL,
	[idProyectoAlquiler] [smallint] NULL,
	[Numero] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
 CONSTRAINT [PK_bdCortes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdCortes_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdRemision]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdRemision](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idProyectoAlquiler] [smallint] NULL,
	[idProyectoVenta] [smallint] NULL,
	[idConductor] [smallint] NULL,
	[Numero] [int] NOT NULL,
	[FechaPedido] [date] NULL,
	[FechaEntrega] [date] NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Hora] [time](7) NULL,
	[Anulado] [bit] NULL,
	[Transporte] [bit] NULL,
	[ValorTransporte] [numeric](8, 0) NULL,
	[Despachado] [bit] NULL,
	[EquipoAdecuado] [bit] NULL,
	[PesoEquipo] [numeric](6, 2) NULL,
	[ValorEquipo] [numeric](10, 0) NULL,
 CONSTRAINT [PK_bdRemisiones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdRemisiones_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdVenta]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRemision] [int] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_bdVentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdVentas_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdReposicion]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdReposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_dbReposiciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_dbReposiciones_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdRepDevolucionServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdRepDevolucionServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_bdRepDevolucionesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdRepDevServicios_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDevolucionServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDevolucionServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[idProveedor] [smallint] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_bdDevolucionesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdDevolucionesServicios_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleDevolucion]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleDevolucion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesDevoluciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleCorte]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleCorte](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idCorte] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[idRemision] [int] NULL,
	[idProveedor] [smallint] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_bdDetallesCortes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdOrdenServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdOrdenServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRemision] [int] NULL,
	[idProveedor] [smallint] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_dbOrdenesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_dbOrdenesServicios_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdFactura]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdFactura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idCorte] [int] NULL,
	[Numero] [int] NOT NULL,
	[FechaEmision] [date] NOT NULL,
	[FechaVencimiento] [date] NOT NULL,
	[Son] [nvarchar](4000) NOT NULL,
	[ParcialTotal] [numeric](10, 2) NOT NULL,
	[Dcto] [tinyint] NOT NULL,
	[SubTotal] [numeric](10, 2) NOT NULL,
	[Iva] [tinyint] NOT NULL,
	[Total] [numeric](10, 2) NOT NULL,
	[Anulada] [bit] NOT NULL,
	[idTipoFactura] [tinyint] NOT NULL,
 CONSTRAINT [PK_bdFacturas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdFacturas_Numero] UNIQUE NONCLUSTERED 
(
	[Numero] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdMantenimiento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdMantenimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_bdMantenimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleRemision]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleRemision](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRemision] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesRemisiones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleOrdenServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleOrdenServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idOrdenServicio] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_dbDetallesOrdenesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleMantenimiento]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleMantenimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idMantenimiento] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[TipoMantenimiento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesMantenimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleVenta]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[idVenta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_dbDetallesVentas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleReposicion]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleReposicion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idReposicion] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_dbDetallesReposiciones] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleRepDevolucionServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleRepDevolucionServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRepDevolucionServicio] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesRepDevolucionesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdDetalleFactura]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdDetalleFactura](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[idFactura] [int] NOT NULL,
	[Detalle] [varchar](4000) NOT NULL,
	[Dias] [tinyint] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Valor] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesFacturas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdDetalleDevolucionServicio]    Script Date: 09/19/2015 00:31:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetalleDevolucionServicio](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucionServicio] [int] NOT NULL,
	[idElemento] [smallint] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_bdDetallesDevolucionesServicios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_PS_bdParametros]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdParametroSistema]  WITH CHECK ADD  CONSTRAINT [FK_PS_bdParametros] FOREIGN KEY([idParametro])
REFERENCES [dbo].[bdParametro] ([Id])
GO
ALTER TABLE [dbo].[bdParametroSistema] CHECK CONSTRAINT [FK_PS_bdParametros]
GO
/****** Object:  ForeignKey [FK_E_bdGruposElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdElemento]  WITH CHECK ADD  CONSTRAINT [FK_E_bdGruposElementos] FOREIGN KEY([idGruposElemento])
REFERENCES [dbo].[bdGrupoElemento] ([Id])
GO
ALTER TABLE [dbo].[bdElemento] CHECK CONSTRAINT [FK_E_bdGruposElementos]
GO
/****** Object:  ForeignKey [FK_E_bdUnidadesMedidas]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdElemento]  WITH CHECK ADD  CONSTRAINT [FK_E_bdUnidadesMedidas] FOREIGN KEY([idUnidadMedida])
REFERENCES [dbo].[bdUnidadMedida] ([Id])
GO
ALTER TABLE [dbo].[bdElemento] CHECK CONSTRAINT [FK_E_bdUnidadesMedidas]
GO
/****** Object:  ForeignKey [FK_bdD_bdTiposDocumentos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDocumento]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdTiposDocumentos] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[bdTipoDocumento] ([Id])
GO
ALTER TABLE [dbo].[bdDocumento] CHECK CONSTRAINT [FK_bdD_bdTiposDocumentos]
GO
/****** Object:  ForeignKey [FK_bdC_bdCiudades]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdCliente]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdCiudades] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[bdCiudad] ([Id])
GO
ALTER TABLE [dbo].[bdCliente] CHECK CONSTRAINT [FK_bdC_bdCiudades]
GO
/****** Object:  ForeignKey [FK_bdDD_bdDocumentos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDocumento]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdDocumentos] FOREIGN KEY([idDocumento])
REFERENCES [dbo].[bdDocumento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDocumento] CHECK CONSTRAINT [FK_bdDD_bdDocumentos]
GO
/****** Object:  ForeignKey [FK_bdDD_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDocumento]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDocumento] CHECK CONSTRAINT [FK_bdDD_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDLP_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleListaPrecio]  WITH CHECK ADD  CONSTRAINT [FK_bdDLP_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleListaPrecio] CHECK CONSTRAINT [FK_bdDLP_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDLP_bdListasPrecios]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleListaPrecio]  WITH CHECK ADD  CONSTRAINT [FK_bdDLP_bdListasPrecios] FOREIGN KEY([idListaPrecios])
REFERENCES [dbo].[bdListaPrecio] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleListaPrecio] CHECK CONSTRAINT [FK_bdDLP_bdListasPrecios]
GO
/****** Object:  ForeignKey [FK_bdMB_bdBodegasDes]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdMovimientoBodega]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdBodegasDes] FOREIGN KEY([idBodegaDestino])
REFERENCES [dbo].[bdBodega] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientoBodega] CHECK CONSTRAINT [FK_bdMB_bdBodegasDes]
GO
/****** Object:  ForeignKey [FK_bdMB_bdBodegasOri]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdMovimientoBodega]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdBodegasOri] FOREIGN KEY([idBodegaOrigen])
REFERENCES [dbo].[bdBodega] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientoBodega] CHECK CONSTRAINT [FK_bdMB_bdBodegasOri]
GO
/****** Object:  ForeignKey [FK_bdMB_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdMovimientoBodega]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdElementos] FOREIGN KEY([idElemeto])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientoBodega] CHECK CONSTRAINT [FK_bdMB_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdP_bdCiudades]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdProyecto]  WITH CHECK ADD  CONSTRAINT [FK_bdP_bdCiudades] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[bdCiudad] ([Id])
GO
ALTER TABLE [dbo].[bdProyecto] CHECK CONSTRAINT [FK_bdP_bdCiudades]
GO
/****** Object:  ForeignKey [FK_bdP_bdClientes]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdProyecto]  WITH CHECK ADD  CONSTRAINT [FK_bdP_bdClientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[bdCliente] ([Id])
GO
ALTER TABLE [dbo].[bdProyecto] CHECK CONSTRAINT [FK_bdP_bdClientes]
GO
/****** Object:  ForeignKey [FK_bdC_bdAgentes]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdContrato]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdAgentes] FOREIGN KEY([idAgente])
REFERENCES [dbo].[bdAgente] ([Id])
GO
ALTER TABLE [dbo].[bdContrato] CHECK CONSTRAINT [FK_bdC_bdAgentes]
GO
/****** Object:  ForeignKey [FK_bdC_bdListasPrecios]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdContrato]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdListasPrecios] FOREIGN KEY([idListaPrecios])
REFERENCES [dbo].[bdListaPrecio] ([Id])
GO
ALTER TABLE [dbo].[bdContrato] CHECK CONSTRAINT [FK_bdC_bdListasPrecios]
GO
/****** Object:  ForeignKey [FK_bdC_bdProyectos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdContrato]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdProyectos] FOREIGN KEY([Id])
REFERENCES [dbo].[bdProyecto] ([Id])
GO
ALTER TABLE [dbo].[bdContrato] CHECK CONSTRAINT [FK_bdC_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdPV_bdProyectos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdProyectoVenta]  WITH CHECK ADD  CONSTRAINT [FK_bdPV_bdProyectos] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyecto] ([Id])
GO
ALTER TABLE [dbo].[bdProyectoVenta] CHECK CONSTRAINT [FK_bdPV_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdPA_bdProyectos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdProyectoAlquiler]  WITH CHECK ADD  CONSTRAINT [FK_bdPA_bdProyectos] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyecto] ([Id])
GO
ALTER TABLE [dbo].[bdProyectoAlquiler] CHECK CONSTRAINT [FK_bdPA_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdD_bdProyectosAlquileres]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDevolucion]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdProyectosAlquileres] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyectoAlquiler] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucion] CHECK CONSTRAINT [FK_bdD_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdDevoluciones_bdConductores]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDevolucion]  WITH CHECK ADD  CONSTRAINT [FK_bdDevoluciones_bdConductores] FOREIGN KEY([idConductor])
REFERENCES [dbo].[bdConductor] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucion] CHECK CONSTRAINT [FK_bdDevoluciones_bdConductores]
GO
/****** Object:  ForeignKey [FK_bdCortes_bdProyectosAlquileres]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdCortes_bdProyectosAlquileres] FOREIGN KEY([idProyectoAlquiler])
REFERENCES [dbo].[bdProyectoAlquiler] ([Id])
GO
ALTER TABLE [dbo].[bdCorte] CHECK CONSTRAINT [FK_bdCortes_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdCortes_bdProyectosVentas]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdCortes_bdProyectosVentas] FOREIGN KEY([idProyectoVenta])
REFERENCES [dbo].[bdProyectoVenta] ([Id])
GO
ALTER TABLE [dbo].[bdCorte] CHECK CONSTRAINT [FK_bdCortes_bdProyectosVentas]
GO
/****** Object:  ForeignKey [FK_bdR_bdProyectosAlquileres]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdRemision]  WITH CHECK ADD  CONSTRAINT [FK_bdR_bdProyectosAlquileres] FOREIGN KEY([idProyectoAlquiler])
REFERENCES [dbo].[bdProyectoAlquiler] ([Id])
GO
ALTER TABLE [dbo].[bdRemision] CHECK CONSTRAINT [FK_bdR_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdR_bdProyectosVentas]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdRemision]  WITH CHECK ADD  CONSTRAINT [FK_bdR_bdProyectosVentas] FOREIGN KEY([idProyectoVenta])
REFERENCES [dbo].[bdProyectoVenta] ([Id])
GO
ALTER TABLE [dbo].[bdRemision] CHECK CONSTRAINT [FK_bdR_bdProyectosVentas]
GO
/****** Object:  ForeignKey [FK_bdRemisiones_bdConductores]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdRemision]  WITH CHECK ADD  CONSTRAINT [FK_bdRemisiones_bdConductores] FOREIGN KEY([idConductor])
REFERENCES [dbo].[bdConductor] ([Id])
GO
ALTER TABLE [dbo].[bdRemision] CHECK CONSTRAINT [FK_bdRemisiones_bdConductores]
GO
/****** Object:  ForeignKey [FK_bdVentas_bdRemisiones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdVenta]  WITH CHECK ADD  CONSTRAINT [FK_bdVentas_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemision] ([Id])
GO
ALTER TABLE [dbo].[bdVenta] CHECK CONSTRAINT [FK_bdVentas_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_dbR_bdDevoluciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdReposicion]  WITH CHECK ADD  CONSTRAINT [FK_dbR_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevolucion] ([Id])
GO
ALTER TABLE [dbo].[bdReposicion] CHECK CONSTRAINT [FK_dbR_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_bdRDS_bdDevoluciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdRepDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdRDS_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevolucion] ([Id])
GO
ALTER TABLE [dbo].[bdRepDevolucionServicio] CHECK CONSTRAINT [FK_bdRDS_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_bdDS_bdDevoluciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDS_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevolucion] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucionServicio] CHECK CONSTRAINT [FK_bdDS_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_bdDS_bdProveedores]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDS_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedor] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucionServicio] CHECK CONSTRAINT [FK_bdDS_bdProveedores]
GO
/****** Object:  ForeignKey [FK_DD_bdDevoluciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDevolucion]  WITH CHECK ADD  CONSTRAINT [FK_DD_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevolucion] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDevolucion] CHECK CONSTRAINT [FK_DD_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_DD_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDevolucion]  WITH CHECK ADD  CONSTRAINT [FK_DD_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDevolucion] CHECK CONSTRAINT [FK_DD_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDC_bdCortes]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdCortes] FOREIGN KEY([idCorte])
REFERENCES [dbo].[bdCorte] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleCorte] CHECK CONSTRAINT [FK_bdDC_bdCortes]
GO
/****** Object:  ForeignKey [FK_bdDC_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleCorte] CHECK CONSTRAINT [FK_bdDC_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDC_bdProveedores]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedor] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleCorte] CHECK CONSTRAINT [FK_bdDC_bdProveedores]
GO
/****** Object:  ForeignKey [FK_bdDC_bdRemisiones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleCorte]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemision] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleCorte] CHECK CONSTRAINT [FK_bdDC_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_bdOS_bdProveedores]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdOS_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedor] ([Id])
GO
ALTER TABLE [dbo].[bdOrdenServicio] CHECK CONSTRAINT [FK_bdOS_bdProveedores]
GO
/****** Object:  ForeignKey [FK_OS_bdRemisiones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_OS_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemision] ([Id])
GO
ALTER TABLE [dbo].[bdOrdenServicio] CHECK CONSTRAINT [FK_OS_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_bdF_bdCortes]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdFactura]  WITH CHECK ADD  CONSTRAINT [FK_bdF_bdCortes] FOREIGN KEY([idCorte])
REFERENCES [dbo].[bdCorte] ([Id])
GO
ALTER TABLE [dbo].[bdFactura] CHECK CONSTRAINT [FK_bdF_bdCortes]
GO
/****** Object:  ForeignKey [FK_bdM_bdDevoluciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_bdM_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevolucion] ([Id])
GO
ALTER TABLE [dbo].[bdMantenimiento] CHECK CONSTRAINT [FK_bdM_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_DR_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleRemision]  WITH CHECK ADD  CONSTRAINT [FK_DR_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleRemision] CHECK CONSTRAINT [FK_DR_bdElementos]
GO
/****** Object:  ForeignKey [FK_DR_bdRemisiones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleRemision]  WITH CHECK ADD  CONSTRAINT [FK_DR_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemision] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleRemision] CHECK CONSTRAINT [FK_DR_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_DOS_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_DOS_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleOrdenServicio] CHECK CONSTRAINT [FK_DOS_bdElementos]
GO
/****** Object:  ForeignKey [FK_DOS_dbOrdenesServicios]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleOrdenServicio]  WITH CHECK ADD  CONSTRAINT [FK_DOS_dbOrdenesServicios] FOREIGN KEY([idOrdenServicio])
REFERENCES [dbo].[bdOrdenServicio] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleOrdenServicio] CHECK CONSTRAINT [FK_DOS_dbOrdenesServicios]
GO
/****** Object:  ForeignKey [FK_bdD_bdMantenimientos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdMantenimientos] FOREIGN KEY([idMantenimiento])
REFERENCES [dbo].[bdMantenimiento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleMantenimiento] CHECK CONSTRAINT [FK_bdD_bdMantenimientos]
GO
/****** Object:  ForeignKey [FK_bdDM_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_bdDM_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleMantenimiento] CHECK CONSTRAINT [FK_bdDM_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDV_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_dbDV_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleVenta] CHECK CONSTRAINT [FK_dbDV_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDV_bdVentas]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_dbDV_bdVentas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[bdVenta] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleVenta] CHECK CONSTRAINT [FK_dbDV_bdVentas]
GO
/****** Object:  ForeignKey [FK_dbDR_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleReposicion]  WITH CHECK ADD  CONSTRAINT [FK_dbDR_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleReposicion] CHECK CONSTRAINT [FK_dbDR_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDR_dbReposiciones]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleReposicion]  WITH CHECK ADD  CONSTRAINT [FK_dbDR_dbReposiciones] FOREIGN KEY([idReposicion])
REFERENCES [dbo].[bdReposicion] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleReposicion] CHECK CONSTRAINT [FK_dbDR_dbReposiciones]
GO
/****** Object:  ForeignKey [FK_bdDD_bdRepDevolucionesServicios]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleRepDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdRepDevolucionesServicios] FOREIGN KEY([idRepDevolucionServicio])
REFERENCES [dbo].[bdRepDevolucionServicio] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleRepDevolucionServicio] CHECK CONSTRAINT [FK_bdDD_bdRepDevolucionesServicios]
GO
/****** Object:  ForeignKey [FK_bdDRDS_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleRepDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDRDS_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleRepDevolucionServicio] CHECK CONSTRAINT [FK_bdDRDS_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDF_bdFacturas]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_bdDF_bdFacturas] FOREIGN KEY([idFactura])
REFERENCES [dbo].[bdFactura] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleFactura] CHECK CONSTRAINT [FK_bdDF_bdFacturas]
GO
/****** Object:  ForeignKey [FK_bdDDS_bdDevolucionesServicios]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDDS_bdDevolucionesServicios] FOREIGN KEY([idDevolucionServicio])
REFERENCES [dbo].[bdDevolucionServicio] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDevolucionServicio] CHECK CONSTRAINT [FK_bdDDS_bdDevolucionesServicios]
GO
/****** Object:  ForeignKey [FK_bdDDServicios_bdElementos]    Script Date: 09/19/2015 00:31:24 ******/
ALTER TABLE [dbo].[bdDetalleDevolucionServicio]  WITH CHECK ADD  CONSTRAINT [FK_bdDDServicios_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElemento] ([Id])
GO
ALTER TABLE [dbo].[bdDetalleDevolucionServicio] CHECK CONSTRAINT [FK_bdDDServicios_bdElementos]
GO
