USE [SAFseg]
GO
/****** Object:  Table [dbo].[bdParametro]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdEventoAuditoria]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdRol]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdPrivilegio]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdUsuario]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdParametroSistema]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdPrivilegioRol]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  Table [dbo].[bdAuditoria]    Script Date: 09/05/2015 12:07:49 ******/
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
/****** Object:  ForeignKey [FK_A_bdEventosAuditorias]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdEventosAuditorias] FOREIGN KEY([idEventosAuditoria])
REFERENCES [dbo].[bdEventoAuditoria] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdEventosAuditorias]
GO
/****** Object:  ForeignKey [FK_A_bdUsuarios]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdAuditoria]  WITH CHECK ADD  CONSTRAINT [FK_A_bdUsuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[bdUsuario] ([Id])
GO
ALTER TABLE [dbo].[bdAuditoria] CHECK CONSTRAINT [FK_A_bdUsuarios]
GO
/****** Object:  ForeignKey [FK_PS_bdParametros]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdParametroSistema]  WITH CHECK ADD  CONSTRAINT [FK_PS_bdParametros] FOREIGN KEY([idParametro])
REFERENCES [dbo].[bdParametro] ([Id])
GO
ALTER TABLE [dbo].[bdParametroSistema] CHECK CONSTRAINT [FK_PS_bdParametros]
GO
/****** Object:  ForeignKey [FK_bdPrivilegios_bdPrivilegios]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdPrivilegio]  WITH CHECK ADD  CONSTRAINT [FK_bdPrivilegios_bdPrivilegios] FOREIGN KEY([IdPrivilegioPadre])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegio] CHECK CONSTRAINT [FK_bdPrivilegios_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_PR_bdPrivilegios]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdPrivilegios] FOREIGN KEY([idPrivilegio])
REFERENCES [dbo].[bdPrivilegio] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_PR_bdRoles]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdPrivilegioRol]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegioRol] CHECK CONSTRAINT [FK_PR_bdRoles]
GO
/****** Object:  ForeignKey [FK_U_bdRoles]    Script Date: 09/05/2015 12:07:49 ******/
ALTER TABLE [dbo].[bdUsuario]  WITH CHECK ADD  CONSTRAINT [FK_U_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRol] ([Id])
GO
ALTER TABLE [dbo].[bdUsuario] CHECK CONSTRAINT [FK_U_bdRoles]
GO
