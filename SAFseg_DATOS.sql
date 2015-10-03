USE [master]
GO
/****** Object:  Database [SAFseg]    Script Date: 10/03/2015 11:29:44 ******/
CREATE DATABASE [SAFseg] ON  PRIMARY 
( NAME = N'SAFseg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER2008\MSSQL\DATA\SAFseg.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SAFseg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER2008\MSSQL\DATA\SAFseg_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SAFseg] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SAFseg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SAFseg] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SAFseg] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SAFseg] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SAFseg] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SAFseg] SET ARITHABORT OFF
GO
ALTER DATABASE [SAFseg] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SAFseg] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SAFseg] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SAFseg] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SAFseg] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SAFseg] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SAFseg] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SAFseg] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SAFseg] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SAFseg] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SAFseg] SET  DISABLE_BROKER
GO
ALTER DATABASE [SAFseg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SAFseg] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SAFseg] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SAFseg] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SAFseg] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SAFseg] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SAFseg] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SAFseg] SET  READ_WRITE
GO
ALTER DATABASE [SAFseg] SET RECOVERY FULL
GO
ALTER DATABASE [SAFseg] SET  MULTI_USER
GO
ALTER DATABASE [SAFseg] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SAFseg] SET DB_CHAINING OFF
GO
USE [SAFseg]
GO
/****** Object:  User [saf]    Script Date: 10/03/2015 11:29:44 ******/
CREATE USER [saf] FOR LOGIN [saf] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[bdParametro]    Script Date: 10/03/2015 11:29:45 ******/
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
/****** Object:  Table [dbo].[bdMenuRol]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdMenuRol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idMenu] [int] NOT NULL,
	[idRol] [int] NOT NULL,
 CONSTRAINT [PK_bdMenuRol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bdMenuRol] ON
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (1, 2, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (2, 3, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (3, 5, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (4, 6, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (5, 8, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (6, 9, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (7, 11, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (8, 12, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (10, 14, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (11, 15, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (12, 16, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (13, 18, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (14, 19, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (15, 21, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (16, 22, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (17, 23, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (18, 24, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (19, 25, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (20, 26, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (21, 27, 1)
INSERT [dbo].[bdMenuRol] ([Id], [idMenu], [idRol]) VALUES (22, 28, 1)
SET IDENTITY_INSERT [dbo].[bdMenuRol] OFF
/****** Object:  Table [dbo].[bdMenu]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idMenuNivel1] [int] NOT NULL,
	[idMenuNivel2] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Url] [varchar](100) NOT NULL,
	[Orden] [smallint] NOT NULL,
	[Imagen] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[bdMenu] ON
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (2, 0, 0, N'Sistema', N'frmMenuModulos.aspx?ModuloID=2', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (3, 0, 0, N'Proyectos', N'frmMenuModulos.aspx?ModuloID=3', 3, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (5, 3, 0, N'Proyectos', N'', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (6, 3, 5, N'Crear / Modificar', N'~/SAFcore/frmProyectoList.aspx', 1, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (8, 2, 0, N'Ubicación', N'', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (9, 2, 8, N'Ciudad', N'~/SAFcore/frmCiudadList.aspx', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (11, 0, 0, N'Clientes', N'frmMenuModulos.aspx?ModuloID=11', 2, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (12, 11, 0, N'Clientes', N'', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (14, 11, 12, N'Crear/Modificar', N'~/SAFcore/frmClienteList.aspx', 2, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (15, 11, 12, N'Ciudad', N'~/SAFcore/frmCiudadForm.aspx', 1, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (16, 0, 0, N'Inventario', N'frmMenuModulos.aspx?ModuloID=16', 1, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (18, 2, 0, N'Inventario', N'', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (19, 2, 18, N'Unidad de Medida', N'~/SAFcore/frmUnidadMedidaList.aspx', 1, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (21, 2, 18, N'Grupos', N'~/SAFcore/frmGrupoElementoList.aspx', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (22, 16, 0, N'Inventario', N'', 0, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (23, 16, 22, N'Crear/Modificar', N'~/SAFcore/frmElementoList.aspx', 1, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (24, 16, 0, N'Tablas Básicas', N'', 2, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (25, 16, 24, N'Grupos', N'~/SAFcore/frmGrupoElementoForm.aspx', 3, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (26, 16, 24, N'Unida de Medida', N'~/SAFcore/frmUnidadMedidaForm.aspx', 4, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (27, 16, 24, N'Bodega', N'~/SAFcore/frmBodegaForm.aspx', 5, N'', 1)
INSERT [dbo].[bdMenu] ([Id], [idMenuNivel1], [idMenuNivel2], [Nombre], [Url], [Orden], [Imagen], [Activo]) VALUES (28, 2, 18, N'Bodega', N'~/SAFcore/frmBodegaList.aspx', 2, N'', 1)
SET IDENTITY_INSERT [dbo].[bdMenu] OFF
/****** Object:  Table [dbo].[bdEventoAuditoria]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdEventoAuditoria](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdEventoAuditoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdEventoAuditoria_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdRol]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdRol](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdRoles_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[bdRol] ON
INSERT [dbo].[bdRol] ([Id], [Nombre], [Activo]) VALUES (1, N'admin', 1)
SET IDENTITY_INSERT [dbo].[bdRol] OFF
/****** Object:  Table [dbo].[bdPrivilegio]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdPrivilegio](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[Activo] [bit] NOT NULL,
	[IdPrivilegioPadre] [smallint] NULL,
 CONSTRAINT [PK_TipoPrivilegio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_bdPrivilegios_Nombre] UNIQUE NONCLUSTERED 
(
	[Nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdUsuario]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdUsuario](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idRol] [smallint] NULL,
	[Identificacion] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](100) NOT NULL,
	[Usuario] [varchar](15) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Activo] [bit] NOT NULL,
	[Admin] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Usuario_Usuario] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[bdUsuario] ON
INSERT [dbo].[bdUsuario] ([Id], [idRol], [Identificacion], [Nombre], [Apellido], [Usuario], [Clave], [Correo], [Activo], [Admin]) VALUES (1, 1, N'admin', N'admin', N'admin', N'admin', N'1', N'admin', 1, 1)
INSERT [dbo].[bdUsuario] ([Id], [idRol], [Identificacion], [Nombre], [Apellido], [Usuario], [Clave], [Correo], [Activo], [Admin]) VALUES (2, 1, N'2', N'2', N'', N'2', N'2', N'correo 2', 1, 0)
INSERT [dbo].[bdUsuario] ([Id], [idRol], [Identificacion], [Nombre], [Apellido], [Usuario], [Clave], [Correo], [Activo], [Admin]) VALUES (3, 1, N'3', N'3', N'3', N'3', N'3', N'3', 0, 0)
SET IDENTITY_INSERT [dbo].[bdUsuario] OFF
/****** Object:  Table [dbo].[bdParametroSistema]    Script Date: 10/03/2015 11:29:45 ******/
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
/****** Object:  Table [dbo].[bdPrivilegioRol]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdPrivilegioRol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRol] [smallint] NOT NULL,
	[idPrivilegio] [smallint] NOT NULL,
	[Valor] [smallint] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Privilegios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdAuditoria]    Script Date: 10/03/2015 11:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdAuditoria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idUsuario] [smallint] NOT NULL,
	[idEventosAuditoria] [smallint] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IpTerminal] [varchar](15) NULL,
	[Seccion] [varchar](50) NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Detalle] [text] NOT NULL,
 CONSTRAINT [PK_bdAuditoria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_bdMenu_idMenuPadre]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdMenu] ADD  CONSTRAINT [DF_bdMenu_idMenuPadre]  DEFAULT ((0)) FOR [idMenuNivel1]
GO
/****** Object:  ForeignKey [FK_bdPrivilegios_bdPrivilegios]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdPrivilegio]  WITH CHECK ADD  CONSTRAINT [FK_bdPrivilegios_bdPrivilegios] FOREIGN KEY([IdPrivilegioPadre])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegio] CHECK CONSTRAINT [FK_bdPrivilegios_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_U_bdRoles]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdUsuario]  WITH CHECK ADD  CONSTRAINT [FK_U_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdUsuario] CHECK CONSTRAINT [FK_U_bdRoles]
GO
/****** Object:  ForeignKey [FK_PS_bdParametros]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdParametroSistema]  WITH CHECK ADD  CONSTRAINT [FK_PS_bdParametros] FOREIGN KEY([idParametro])
REFERENCES [dbo].[bdParametro] ([Id])
GO
ALTER TABLE [dbo].[bdParametroSistema] CHECK CONSTRAINT [FK_PS_bdParametros]
GO
/****** Object:  ForeignKey [FK_PR_bdPrivilegios]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdPrivilegios] FOREIGN KEY([idPrivilegio])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_PR_bdRoles]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdRoles]
GO
/****** Object:  ForeignKey [FK_A_bdEventosAuditorias]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdEventosAuditorias] FOREIGN KEY([idEventosAuditoria])
REFERENCES [dbo].[bdEventoAuditoria] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdEventosAuditorias]
GO
/****** Object:  ForeignKey [FK_A_bdUsuarios]    Script Date: 10/03/2015 11:29:45 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdUsuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[bdUsuario] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdUsuarios]
GO
