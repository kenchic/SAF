USE [master]
GO
/****** Object:  Database [SAFseg]    Script Date: 09/08/2015 23:35:22 ******/
CREATE DATABASE [SAFseg] ON  PRIMARY 
( NAME = N'SAFseg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER2008\MSSQL\DATA\SAFseg.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SAFseg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER2008\MSSQL\DATA\SAFseg_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
EXEC sys.sp_db_vardecimal_storage_format N'SAFseg', N'ON'
GO
USE [SAFseg]
GO
/****** Object:  User [saf]    Script Date: 09/08/2015 23:35:22 ******/
CREATE USER [saf] FOR LOGIN [saf] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[bdParametro]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdMenuRol]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdMenu]    Script Date: 09/08/2015 23:35:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdMenu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idMenuPadre] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Url] [varchar](100) NOT NULL,
	[Orden] [smallint] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_bdMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[bdEventoAuditoria]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdRol]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdPrivilegio]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdUsuario]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdParametroSistema]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdPrivilegioRol]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Table [dbo].[bdAuditoria]    Script Date: 09/08/2015 23:35:23 ******/
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
/****** Object:  Default [DF_bdMenu_idMenuPadre]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdMenu] ADD  CONSTRAINT [DF_bdMenu_idMenuPadre]  DEFAULT ((0)) FOR [idMenuPadre]
GO
/****** Object:  ForeignKey [FK_bdPrivilegios_bdPrivilegios]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdPrivilegio]  WITH CHECK ADD  CONSTRAINT [FK_bdPrivilegios_bdPrivilegios] FOREIGN KEY([IdPrivilegioPadre])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegio] CHECK CONSTRAINT [FK_bdPrivilegios_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_U_bdRoles]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdUsuario]  WITH CHECK ADD  CONSTRAINT [FK_U_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdUsuario] CHECK CONSTRAINT [FK_U_bdRoles]
GO
/****** Object:  ForeignKey [FK_PS_bdParametros]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdParametroSistema]  WITH CHECK ADD  CONSTRAINT [FK_PS_bdParametros] FOREIGN KEY([idParametro])
REFERENCES [dbo].[bdParametro] ([Id])
GO
ALTER TABLE [dbo].[bdParametroSistema] CHECK CONSTRAINT [FK_PS_bdParametros]
GO
/****** Object:  ForeignKey [FK_PR_bdPrivilegios]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdPrivilegios] FOREIGN KEY([idPrivilegio])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_PR_bdRoles]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdRoles]
GO
/****** Object:  ForeignKey [FK_A_bdEventosAuditorias]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdEventosAuditorias] FOREIGN KEY([idEventosAuditoria])
REFERENCES [dbo].[bdEventoAuditoria] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdEventosAuditorias]
GO
/****** Object:  ForeignKey [FK_A_bdUsuarios]    Script Date: 09/08/2015 23:35:23 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdUsuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[bdUsuario] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdUsuarios]
GO
