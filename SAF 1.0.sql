USE [SAF]
GO
/****** Object:  Table [dbo].[bdCiudades]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdCiudades](
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
/****** Object:  Table [dbo].[bdBodegas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdBodegas](
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
/****** Object:  Table [dbo].[bdAgentes]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdAgentes](
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
/****** Object:  Table [dbo].[bdConductores]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdConductores](
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
/****** Object:  Table [dbo].[bdListasPrecios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdListasPrecios](
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
/****** Object:  Table [dbo].[bdGruposElementos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdGruposElementos](
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
/****** Object:  Table [dbo].[bdParametros]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdParametros](
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
/****** Object:  Table [dbo].[bdEventosAuditorias]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdEventosAuditorias](
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
/****** Object:  Table [dbo].[bdPrivilegios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdPrivilegios](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](200) NOT NULL,
	[NombreGrupo] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
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
/****** Object:  Table [dbo].[bdProveedores]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdProveedores](
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
/****** Object:  Table [dbo].[bdUnidadesMedidas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdUnidadesMedidas](
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
/****** Object:  Table [dbo].[bdTiposDocumentos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdTiposDocumentos](
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
/****** Object:  Table [dbo].[bdRoles]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdRoles](
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
/****** Object:  Table [dbo].[bdUsuarios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdUsuarios](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idRol] [smallint] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Usuario] [varchar](15) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
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
/****** Object:  StoredProcedure [dbo].[SP_AGENTES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AGENTES]
(
	@ID SMALLINT,
	@NOMBRE AS VARCHAR,
	@ACTIVO AS BIT = null,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdAgentes	WHERE bdAgentes.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdAgentes where (@ACTIVO is null or Activo = @ACTIVO)
	ELSE IF @OPCION = 2
		INSERT INTO bdAgentes (Nombre,Activo) VALUES (@NOMBRE,@ACTIVO)
	ELSE IF @OPCION = 3
		UPDATE bdAgentes SET Nombre = @NOMBRE, Activo=@ACTIVO WHERE Id = @ID
	ELSE		
		DELETE FROM bdAgentes WHERE Id = @ID
END
GO
/****** Object:  Table [dbo].[bdPrivilegiosRoles]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdPrivilegiosRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idRol] [smallint] NOT NULL,
	[idPrivilegio] [smallint] NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Privilegios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdParametrosSistema]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdParametrosSistema](
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
/****** Object:  StoredProcedure [dbo].[SP_CIUDADES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CIUDADES]
(
	@ID SMALLINT,
	@NOMBRE AS VARCHAR,
	@ACTIVO AS BIT = null,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdCiudades WHERE bdCiudades.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdCiudades where (@ACTIVO is null or Activo = @ACTIVO)
	ELSE IF @OPCION = 2
		INSERT INTO bdCiudades (Nombre,Activo) VALUES (@NOMBRE,@ACTIVO)
	ELSE IF @OPCION = 3
		UPDATE bdCiudades SET Nombre = @NOMBRE, Activo=@ACTIVO WHERE Id = @ID
	ELSE		
		DELETE FROM bdCiudades WHERE Id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_BODEGAS]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BODEGAS]
(
	@ID SMALLINT,
	@NOMBRE AS VARCHAR,
	@ACTIVO AS BIT = null,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdBodegas	WHERE bdBodegas.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdBodegas where (@ACTIVO is null or Activo = @ACTIVO)
	ELSE IF @OPCION = 2
		INSERT INTO bdBodegas (Nombre,Activo) VALUES (@NOMBRE,@ACTIVO)
	ELSE IF @OPCION = 3
		UPDATE bdBodegas SET Nombre = @NOMBRE, Activo=@ACTIVO WHERE Id = @ID
	ELSE		
		DELETE FROM bdBodegas WHERE Id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CONDUCTORES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONDUCTORES]
(
	@ID SMALLINT,
	@NOMBRE AS VARCHAR,
	@ACTIVO AS BIT = null,
	@PLACA AS VARCHAR,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdConductores	WHERE bdConductores.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdConductores where (@ACTIVO is null or Activo = @ACTIVO)
	ELSE IF @OPCION = 2
		INSERT INTO bdConductores (Nombre,Activo,Placa) VALUES (@NOMBRE,@ACTIVO,@PLACA)
	ELSE IF @OPCION = 3
		UPDATE bdConductores SET Nombre=@NOMBRE, Activo=@ACTIVO, Placa=@PLACA WHERE Id = @ID
	ELSE		
		DELETE FROM bdConductores WHERE Id = @ID
END
GO
/****** Object:  Table [dbo].[bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdElementos](
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
/****** Object:  Table [dbo].[bdDocumentos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdDocumentos](
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
/****** Object:  Table [dbo].[bdClientes]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdClientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idCiudad] [smallint] NOT NULL,
	[Identificacion] [varchar](20) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
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
/****** Object:  Table [dbo].[bdDetallesDocumentos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesDocumentos](
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
/****** Object:  Table [dbo].[bdDetallesListasPrecios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesListasPrecios](
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
/****** Object:  Table [dbo].[bdAuditorias]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdAuditorias](
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
/****** Object:  StoredProcedure [dbo].[SP_CLIENTES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CLIENTES]
(
	@ID SMALLINT,
	@IDCIUDAD AS SMALLINT,
	@IDENTIFICACION AS VARCHAR(20),
	@NOMBRE AS VARCHAR(100),
	@DIRECCION AS VARCHAR(200),
	@TELEFONO AS VARCHAR(50),
	@CELULAR AS VARCHAR(50),
	@CORREO AS VARCHAR(100),
	@ACTIVO AS BIT = null,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdClientes WHERE bdClientes.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdClientes where (@ACTIVO is null or Activo = @ACTIVO)
	ELSE IF @OPCION = 2
		INSERT INTO bdClientes (idCiudad,Identificacion,Nombre,Direccion,Telefono,Celular,Correo,Activo) 
		VALUES (@IDCIUDAD,@IDENTIFICACION,@NOMBRE,@DIRECCION,@TELEFONO,@CELULAR,@CORREO,@ACTIVO)
	ELSE IF @OPCION = 3
		UPDATE bdClientes SET idCiudad=@IDCIUDAD,Identificacion=@IDENTIFICACION, Nombre=@NOMBRE,Direccion=@DIRECCION,
		Telefono=@TELEFONO, Celular=@CELULAR, Correo=@CORREO, Activo=@ACTIVO 
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdClientes WHERE Id = @ID
END
GO
/****** Object:  Table [dbo].[bdMovimientosBodegas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdMovimientosBodegas](
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
/****** Object:  Table [dbo].[bdProyectos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdProyectos](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idCiudad] [smallint] NOT NULL,
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
/****** Object:  Table [dbo].[bdProyectosVentas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdProyectosVentas](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idProyecto] [smallint] NOT NULL,
 CONSTRAINT [PK_bdProyectosVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bdProyectosAlquileres]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdProyectosAlquileres](
	[Id] [smallint] IDENTITY(1,1) NOT NULL,
	[idProyecto] [smallint] NOT NULL,
 CONSTRAINT [PK_bdProyectosAlquiler] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLESDOCUMENTOS]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLESDOCUMENTOS]
(
	@ID SMALLINT,
	@IDDOCUMENTO AS INT,
	@IDELEMENTO AS SMALLINT,
	@CANTIDAD AS INT,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdDetallesDocumentos WHERE bdDetallesDocumentos.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdDetallesDocumentos
	ELSE IF @OPCION = 2
		INSERT INTO bdDetallesDocumentos (idDocumento,idElemento,Cantidad) 
		VALUES (@IDDOCUMENTO,@IDELEMENTO,@CANTIDAD)
	ELSE IF @OPCION = 3
		UPDATE bdDetallesDocumentos SET idDocumento = @IDDOCUMENTO, idElemento=@IDELEMENTO, Cantidad=@CANTIDAD
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdDetallesDocumentos WHERE Id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_AUDITORIAS]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AUDITORIAS]
(
	@ID SMALLINT,
	@IDUSUARIO AS SMALLINT,
	@IDEVENTOSAUDITORIA AS SMALLINT,
	@FECHA AS DATETIME,
	@IPTERMINAL AS VARCHAR(15),
	@SECCION AS VARCHAR(50),
	@TITULO AS VARCHAR(50),
	@DETALLE AS TEXT,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdAuditorias	WHERE bdAuditorias.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdAuditorias
	ELSE IF @OPCION = 2
		INSERT INTO bdAuditorias (idUsuario,idEventosAuditoria, Fecha, IpTerminal, Seccion, Titulo, Detalle) 
		VALUES (@IDUSUARIO,@IDEVENTOSAUDITORIA, @FECHA, @IPTERMINAL, @SECCION, @TITULO, @DETALLE)
	ELSE IF @OPCION = 3
		UPDATE bdAuditorias SET idUsuario=@IDUSUARIO, idEventosAuditoria=@IDEVENTOSAUDITORIA, Fecha=@FECHA,
		IpTerminal=@IPTERMINAL, Seccion=@SECCION, Titulo=@TITULO, Detalle=@DETALLE
		WHERE Id=@ID
	ELSE		
		DELETE FROM bdAuditorias WHERE Id=@ID
END
GO
/****** Object:  Table [dbo].[bdContratos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdContratos](
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
/****** Object:  Table [dbo].[bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDevoluciones](
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
/****** Object:  Table [dbo].[bdCortes]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdCortes](
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
/****** Object:  StoredProcedure [dbo].[SP_CONTRATOS]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONTRATOS]
(
	@ID SMALLINT,
	@IDLISTAPRECIOS AS TINYINT,
	@IDAGENTE AS SMALLINT,
	@INFORMACIONBD AS BIT,
	@CONTRATOALQUILER AS BIT,
	@CARTAPAGARE AS BIT,
	@PAGARE AS BIT,
	@LETRACAMBIO AS BIT,
	@GARANTIASCONDICIONES AS BIT,
	@DEPOSITO AS BIT,
	@ANTICIPO AS BIT,
	@PERSONAJURIDICA AS BIT,
	@PERSONANATURAL AS BIT,
	@FOTOCOPIACEDULA AS BIT,
	@FOTOCOPIANIT AS BIT,
	@CAMARACOMERCIO AS BIT,
	@DESCUENTOALQUILER AS BIT,
	@DESCUENTOVENTA AS BIT,
	@DESCUENTOREPOSICION AS BIT,
	@DESCUENTOMANTENIMIENTO AS BIT,
	@DESCUENTOTRANSPORTE AS BIT,
	@PORCENTAJEAGENTE AS BIT,	
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdContratos	WHERE bdContratos.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdContratos 
	ELSE IF @OPCION = 2
		INSERT INTO bdContratos (idListaPrecios, idAgente,InformacionBD,ContratoAlquiler,CartaPagare,Pagare,
		LetraCambio, GarantiasCondiciones, Deposito, Anticipo, PersonaJuridica, PersonaNatural, FotoCopiaCedula, FotoCopiaNit, 
		CamaraComercio, DescuentoAlquiler, DescuentoVenta, DescuentoReposicion, DescuentoMantenimiento, DescuentoTransporte,
		PorcentajeAgente) 
		VALUES (@IDLISTAPRECIOS,@IDAGENTE,@INFORMACIONBD,@CONTRATOALQUILER,@CARTAPAGARE,@PAGARE, @LETRACAMBIO, 
		@GARANTIASCONDICIONES,@DEPOSITO, @ANTICIPO, @PERSONAJURIDICA, @PERSONANATURAL,
		@FOTOCOPIACEDULA, @FOTOCOPIANIT,@CAMARACOMERCIO,@DESCUENTOALQUILER, @DESCUENTOVENTA,
		@DESCUENTOREPOSICION, @DESCUENTOMANTENIMIENTO, @DESCUENTOTRANSPORTE, @PORCENTAJEAGENTE)
	ELSE IF @OPCION = 3
		UPDATE bdContratos SET idListaPrecioS=@IDLISTAPRECIOS, idAgente=@IDAGENTE, InformacionBD=@INFORMACIONBD,
		ContratoAlquiler = @CONTRATOALQUILER, CartaPagare=@CARTAPAGARE,Pagare=@PAGARE,LetraCambio=@LETRACAMBIO,
		GarantiasCondiciones=@GARANTIASCONDICIONES, Deposito=@DEPOSITO, Anticipo=@ANTICIPO, PersonaJuridica=@PERSONAJURIDICA,
		PersonaNatural=@PERSONANATURAL, FotoCopiaCedula=@FOTOCOPIACEDULA, FotoCopiaNit=@FOTOCOPIANIT, CamaraComercio=@CAMARACOMERCIO,
		DescuentoAlquiler=@DESCUENTOALQUILER, DescuentoVenta=@DESCUENTOVENTA, DescuentoReposicion=@DESCUENTOREPOSICION,
		DescuentoMantenimiento=@DESCUENTOMANTENIMIENTO,DescuentoTransporte=@DESCUENTOTRANSPORTE,PorcentajeAgente=@PORCENTAJEAGENTE		
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdContratos WHERE Id = @ID
END
GO
/****** Object:  Table [dbo].[bdRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdRemisiones](
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
/****** Object:  Table [dbo].[bdVentas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdVentas](
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
/****** Object:  Table [dbo].[bdReposiciones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdReposiciones](
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
/****** Object:  Table [dbo].[bdRepDevolucionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdRepDevolucionesServicios](
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
/****** Object:  Table [dbo].[bdMantenimientos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdMantenimientos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[idDevolucion] [int] NOT NULL,
	[Numero] [int] NOT NULL,
 CONSTRAINT [PK_bdMantenimientos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_CORTES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CORTES]
(
	@ID SMALLINT,
	@IDPROYECTOVENTA AS SMALLINT,
	@IDPROYECTOALQUILER AS SMALLINT,
	@NUMERO AS INT,
	@FECHA AS DATE,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdCortes WHERE bdCortes.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdCortes 
	ELSE IF @OPCION = 2
		INSERT INTO bdCortes (idProyectoVenta,idProyectoAlquiler,Numero,Fecha) 
		VALUES (@IDPROYECTOVENTA,@IDPROYECTOALQUILER,@NUMERO,@FECHA)
	ELSE IF @OPCION = 3
		UPDATE bdCortes SET idProyectoVenta=@IDPROYECTOVENTA, idProyectoAlquiler=@IDPROYECTOALQUILER,
		Numero = @NUMERO, Fecha=@FECHA WHERE Id = @ID
	ELSE		
		DELETE FROM bdCortes WHERE Id = @ID
END
GO
/****** Object:  Table [dbo].[bdDetallesDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesDevoluciones](
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
/****** Object:  Table [dbo].[bdDetallesCortes]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesCortes](
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
/****** Object:  Table [dbo].[bdDetallesRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesRemisiones](
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
/****** Object:  Table [dbo].[bdDevolucionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDevolucionesServicios](
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
/****** Object:  Table [dbo].[bdOrdenesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdOrdenesServicios](
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
/****** Object:  Table [dbo].[bdFacturas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdFacturas](
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
/****** Object:  Table [dbo].[bdDetallesVentas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesVentas](
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
/****** Object:  Table [dbo].[bdDetallesReposiciones]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesReposiciones](
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
/****** Object:  Table [dbo].[bdDetallesRepDevolusionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesRepDevolusionesServicios](
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
/****** Object:  Table [dbo].[bdDetallesOrdenesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesOrdenesServicios](
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
/****** Object:  Table [dbo].[bdDetallesMantenimientos]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesMantenimientos](
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
/****** Object:  Table [dbo].[bdDetallesFacturas]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bdDetallesFacturas](
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
/****** Object:  Table [dbo].[bdDetallesDevolucionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bdDetallesDevolucionesServicios](
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
/****** Object:  StoredProcedure [dbo].[SP_DETALLESDEVOLUCIONES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLESDEVOLUCIONES]
(
	@ID SMALLINT,
	@IDDEVOLUCION AS INT,
	@IDELEMENTO AS SMALLINT,
	@CANTIDAD AS INT,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdDetallesDevoluciones WHERE bdDetallesDevoluciones.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdDetallesDevoluciones
	ELSE IF @OPCION = 2
		INSERT INTO bdDetallesDevoluciones (idDevolucion,idElemento,Cantidad) 
		VALUES (@IDDEVOLUCION,@IDELEMENTO,@CANTIDAD)
	ELSE IF @OPCION = 3
		UPDATE bdDetallesDevoluciones SET idDevolucion = @IDDEVOLUCION, idElemento=@IDELEMENTO, Cantidad=@CANTIDAD
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdDetallesDevoluciones WHERE Id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLECORTES]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLECORTES]
(
	@ID SMALLINT,
	@IDCORTE AS INT,
	@IDELEMENTO AS SMALLINT,
	@IDREMISION AS INT,
	@IDPROVEEDOR AS SMALLINT,
	@CANTIDAD AS INT,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdDetallesCortes	WHERE bdDetallesCortes.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdDetallesCortes
	ELSE IF @OPCION = 2
		INSERT INTO bdDetallesCortes (idCorte,idElemento,idRemision,idProveedor,Cantidad) 
		VALUES (@IDCORTE,@IDELEMENTO,@IDREMISION,@IDPROVEEDOR,@CANTIDAD)
	ELSE IF @OPCION = 3
		UPDATE bdDetallesCortes SET idCorte = @IDCORTE, idElemento=@IDELEMENTO, idRemision=@IDREMISION,
		idProveedor=@IDPROVEEDOR,Cantidad=@CANTIDAD
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdDetallesCortes WHERE Id = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLESDEVOLUCIONESSERVICIOS]    Script Date: 03/16/2013 19:16:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLESDEVOLUCIONESSERVICIOS]
(
	@ID SMALLINT,
	@IDDEVOLUCIONSERVICIO AS INT,
	@IDELEMENTO AS SMALLINT,
	@CANTIDAD AS INT,
	@OPCION AS SMALLINT -- SELECCIONAR UNO = 0, SELECCIONAR VARIOS = 1, INSERTAR = 2, EDITAR = 3, ELIMINAR = 4
)
AS


BEGIN
	IF @OPCION = 0		
		SELECT * FROM bdDetallesDevolucionesServicios WHERE bdDetallesDevolucionesServicios.Id = @ID
	ELSE IF @OPCION = 1
		SELECT * FROM bdDetallesDevolucionesServicios
	ELSE IF @OPCION = 2
		INSERT INTO bdDetallesDevolucionesServicios (idDevolucionServicio,idElemento,Cantidad) 
		VALUES (@IDDEVOLUCIONSERVICIO,@IDELEMENTO,@CANTIDAD)
	ELSE IF @OPCION = 3
		UPDATE bdDetallesDevolucionesServicios SET idDevolucionServicio = @IDDEVOLUCIONSERVICIO, idElemento=@IDELEMENTO, Cantidad=@CANTIDAD
		WHERE Id = @ID
	ELSE		
		DELETE FROM bdDetallesDevolucionesServicios WHERE Id = @ID
END
GO
/****** Object:  ForeignKey [FK_A_bdEventosAuditorias]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdAuditorias]  WITH CHECK ADD  CONSTRAINT [FK_A_bdEventosAuditorias] FOREIGN KEY([idEventosAuditoria])
REFERENCES [dbo].[bdEventosAuditorias] ([Id])
GO
ALTER TABLE [dbo].[bdAuditorias] CHECK CONSTRAINT [FK_A_bdEventosAuditorias]
GO
/****** Object:  ForeignKey [FK_A_bdUsuarios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdAuditorias]  WITH CHECK ADD  CONSTRAINT [FK_A_bdUsuarios] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[bdUsuarios] ([Id])
GO
ALTER TABLE [dbo].[bdAuditorias] CHECK CONSTRAINT [FK_A_bdUsuarios]
GO
/****** Object:  ForeignKey [FK_bdC_bdCiudades]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdClientes]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdCiudades] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[bdCiudades] ([Id])
GO
ALTER TABLE [dbo].[bdClientes] CHECK CONSTRAINT [FK_bdC_bdCiudades]
GO
/****** Object:  ForeignKey [FK_bdC_bdAgentes]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdContratos]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdAgentes] FOREIGN KEY([idAgente])
REFERENCES [dbo].[bdAgentes] ([Id])
GO
ALTER TABLE [dbo].[bdContratos] CHECK CONSTRAINT [FK_bdC_bdAgentes]
GO
/****** Object:  ForeignKey [FK_bdC_bdListasPrecios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdContratos]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdListasPrecios] FOREIGN KEY([idListaPrecios])
REFERENCES [dbo].[bdListasPrecios] ([Id])
GO
ALTER TABLE [dbo].[bdContratos] CHECK CONSTRAINT [FK_bdC_bdListasPrecios]
GO
/****** Object:  ForeignKey [FK_bdC_bdProyectos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdContratos]  WITH CHECK ADD  CONSTRAINT [FK_bdC_bdProyectos] FOREIGN KEY([Id])
REFERENCES [dbo].[bdProyectos] ([Id])
GO
ALTER TABLE [dbo].[bdContratos] CHECK CONSTRAINT [FK_bdC_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdCortes_bdProyectosAlquileres]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdCortes_bdProyectosAlquileres] FOREIGN KEY([idProyectoAlquiler])
REFERENCES [dbo].[bdProyectosAlquileres] ([Id])
GO
ALTER TABLE [dbo].[bdCortes] CHECK CONSTRAINT [FK_bdCortes_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdCortes_bdProyectosVentas]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdCortes_bdProyectosVentas] FOREIGN KEY([idProyectoVenta])
REFERENCES [dbo].[bdProyectosVentas] ([Id])
GO
ALTER TABLE [dbo].[bdCortes] CHECK CONSTRAINT [FK_bdCortes_bdProyectosVentas]
GO
/****** Object:  ForeignKey [FK_bdDC_bdCortes]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdCortes] FOREIGN KEY([idCorte])
REFERENCES [dbo].[bdCortes] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesCortes] CHECK CONSTRAINT [FK_bdDC_bdCortes]
GO
/****** Object:  ForeignKey [FK_bdDC_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesCortes] CHECK CONSTRAINT [FK_bdDC_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDC_bdProveedores]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedores] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesCortes] CHECK CONSTRAINT [FK_bdDC_bdProveedores]
GO
/****** Object:  ForeignKey [FK_bdDC_bdRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesCortes]  WITH CHECK ADD  CONSTRAINT [FK_bdDC_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemisiones] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesCortes] CHECK CONSTRAINT [FK_bdDC_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_DD_bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDevoluciones]  WITH CHECK ADD  CONSTRAINT [FK_DD_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevoluciones] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDevoluciones] CHECK CONSTRAINT [FK_DD_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_DD_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDevoluciones]  WITH CHECK ADD  CONSTRAINT [FK_DD_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDevoluciones] CHECK CONSTRAINT [FK_DD_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDDS_bdDevolucionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDevolucionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDDS_bdDevolucionesServicios] FOREIGN KEY([idDevolucionServicio])
REFERENCES [dbo].[bdDevolucionesServicios] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDevolucionesServicios] CHECK CONSTRAINT [FK_bdDDS_bdDevolucionesServicios]
GO
/****** Object:  ForeignKey [FK_bdDDServicios_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDevolucionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDDServicios_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDevolucionesServicios] CHECK CONSTRAINT [FK_bdDDServicios_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDD_bdDocumentos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdDocumentos] FOREIGN KEY([idDocumento])
REFERENCES [dbo].[bdDocumentos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDocumentos] CHECK CONSTRAINT [FK_bdDD_bdDocumentos]
GO
/****** Object:  ForeignKey [FK_bdDD_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesDocumentos] CHECK CONSTRAINT [FK_bdDD_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDF_bdFacturas]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesFacturas]  WITH CHECK ADD  CONSTRAINT [FK_bdDF_bdFacturas] FOREIGN KEY([idFactura])
REFERENCES [dbo].[bdFacturas] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesFacturas] CHECK CONSTRAINT [FK_bdDF_bdFacturas]
GO
/****** Object:  ForeignKey [FK_bdDLP_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesListasPrecios]  WITH CHECK ADD  CONSTRAINT [FK_bdDLP_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesListasPrecios] CHECK CONSTRAINT [FK_bdDLP_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdDLP_bdListasPrecios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesListasPrecios]  WITH CHECK ADD  CONSTRAINT [FK_bdDLP_bdListasPrecios] FOREIGN KEY([idListaPrecios])
REFERENCES [dbo].[bdListasPrecios] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesListasPrecios] CHECK CONSTRAINT [FK_bdDLP_bdListasPrecios]
GO
/****** Object:  ForeignKey [FK_bdD_bdMantenimientos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesMantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdMantenimientos] FOREIGN KEY([idMantenimiento])
REFERENCES [dbo].[bdMantenimientos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesMantenimientos] CHECK CONSTRAINT [FK_bdD_bdMantenimientos]
GO
/****** Object:  ForeignKey [FK_bdDM_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesMantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_bdDM_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesMantenimientos] CHECK CONSTRAINT [FK_bdDM_bdElementos]
GO
/****** Object:  ForeignKey [FK_DOS_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesOrdenesServicios]  WITH CHECK ADD  CONSTRAINT [FK_DOS_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesOrdenesServicios] CHECK CONSTRAINT [FK_DOS_bdElementos]
GO
/****** Object:  ForeignKey [FK_DOS_dbOrdenesServicios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesOrdenesServicios]  WITH CHECK ADD  CONSTRAINT [FK_DOS_dbOrdenesServicios] FOREIGN KEY([idOrdenServicio])
REFERENCES [dbo].[bdOrdenesServicios] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesOrdenesServicios] CHECK CONSTRAINT [FK_DOS_dbOrdenesServicios]
GO
/****** Object:  ForeignKey [FK_DR_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesRemisiones]  WITH CHECK ADD  CONSTRAINT [FK_DR_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesRemisiones] CHECK CONSTRAINT [FK_DR_bdElementos]
GO
/****** Object:  ForeignKey [FK_DR_bdRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesRemisiones]  WITH CHECK ADD  CONSTRAINT [FK_DR_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemisiones] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesRemisiones] CHECK CONSTRAINT [FK_DR_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_bdDD_bdRepDevolucionesServicios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesRepDevolusionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDD_bdRepDevolucionesServicios] FOREIGN KEY([idRepDevolucionServicio])
REFERENCES [dbo].[bdRepDevolucionesServicios] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesRepDevolusionesServicios] CHECK CONSTRAINT [FK_bdDD_bdRepDevolucionesServicios]
GO
/****** Object:  ForeignKey [FK_bdDRDS_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesRepDevolusionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDRDS_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesRepDevolusionesServicios] CHECK CONSTRAINT [FK_bdDRDS_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDR_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesReposiciones]  WITH CHECK ADD  CONSTRAINT [FK_dbDR_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesReposiciones] CHECK CONSTRAINT [FK_dbDR_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDR_dbReposiciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesReposiciones]  WITH CHECK ADD  CONSTRAINT [FK_dbDR_dbReposiciones] FOREIGN KEY([idReposicion])
REFERENCES [dbo].[bdReposiciones] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesReposiciones] CHECK CONSTRAINT [FK_dbDR_dbReposiciones]
GO
/****** Object:  ForeignKey [FK_dbDV_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesVentas]  WITH CHECK ADD  CONSTRAINT [FK_dbDV_bdElementos] FOREIGN KEY([idElemento])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesVentas] CHECK CONSTRAINT [FK_dbDV_bdElementos]
GO
/****** Object:  ForeignKey [FK_dbDV_bdVentas]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDetallesVentas]  WITH CHECK ADD  CONSTRAINT [FK_dbDV_bdVentas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[bdVentas] ([Id])
GO
ALTER TABLE [dbo].[bdDetallesVentas] CHECK CONSTRAINT [FK_dbDV_bdVentas]
GO
/****** Object:  ForeignKey [FK_bdD_bdProyectosAlquileres]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDevoluciones]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdProyectosAlquileres] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyectosAlquileres] ([Id])
GO
ALTER TABLE [dbo].[bdDevoluciones] CHECK CONSTRAINT [FK_bdD_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdDevoluciones_bdConductores]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDevoluciones]  WITH CHECK ADD  CONSTRAINT [FK_bdDevoluciones_bdConductores] FOREIGN KEY([idConductor])
REFERENCES [dbo].[bdConductores] ([Id])
GO
ALTER TABLE [dbo].[bdDevoluciones] CHECK CONSTRAINT [FK_bdDevoluciones_bdConductores]
GO
/****** Object:  ForeignKey [FK_bdDS_bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDevolucionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDS_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevoluciones] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucionesServicios] CHECK CONSTRAINT [FK_bdDS_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_bdDS_bdProveedores]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDevolucionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdDS_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedores] ([Id])
GO
ALTER TABLE [dbo].[bdDevolucionesServicios] CHECK CONSTRAINT [FK_bdDS_bdProveedores]
GO
/****** Object:  ForeignKey [FK_bdD_bdTiposDocumentos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdDocumentos]  WITH CHECK ADD  CONSTRAINT [FK_bdD_bdTiposDocumentos] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[bdTiposDocumentos] ([Id])
GO
ALTER TABLE [dbo].[bdDocumentos] CHECK CONSTRAINT [FK_bdD_bdTiposDocumentos]
GO
/****** Object:  ForeignKey [FK_E_bdGruposElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdElementos]  WITH CHECK ADD  CONSTRAINT [FK_E_bdGruposElementos] FOREIGN KEY([idGruposElemento])
REFERENCES [dbo].[bdGruposElementos] ([Id])
GO
ALTER TABLE [dbo].[bdElementos] CHECK CONSTRAINT [FK_E_bdGruposElementos]
GO
/****** Object:  ForeignKey [FK_E_bdUnidadesMedidas]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdElementos]  WITH CHECK ADD  CONSTRAINT [FK_E_bdUnidadesMedidas] FOREIGN KEY([idUnidadMedida])
REFERENCES [dbo].[bdUnidadesMedidas] ([Id])
GO
ALTER TABLE [dbo].[bdElementos] CHECK CONSTRAINT [FK_E_bdUnidadesMedidas]
GO
/****** Object:  ForeignKey [FK_bdF_bdCortes]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdFacturas]  WITH CHECK ADD  CONSTRAINT [FK_bdF_bdCortes] FOREIGN KEY([idCorte])
REFERENCES [dbo].[bdCortes] ([Id])
GO
ALTER TABLE [dbo].[bdFacturas] CHECK CONSTRAINT [FK_bdF_bdCortes]
GO
/****** Object:  ForeignKey [FK_bdM_bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdMantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_bdM_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevoluciones] ([Id])
GO
ALTER TABLE [dbo].[bdMantenimientos] CHECK CONSTRAINT [FK_bdM_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_bdMB_bdBodegasDes]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdMovimientosBodegas]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdBodegasDes] FOREIGN KEY([idBodegaDestino])
REFERENCES [dbo].[bdBodegas] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientosBodegas] CHECK CONSTRAINT [FK_bdMB_bdBodegasDes]
GO
/****** Object:  ForeignKey [FK_bdMB_bdBodegasOri]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdMovimientosBodegas]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdBodegasOri] FOREIGN KEY([idBodegaOrigen])
REFERENCES [dbo].[bdBodegas] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientosBodegas] CHECK CONSTRAINT [FK_bdMB_bdBodegasOri]
GO
/****** Object:  ForeignKey [FK_bdMB_bdElementos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdMovimientosBodegas]  WITH CHECK ADD  CONSTRAINT [FK_bdMB_bdElementos] FOREIGN KEY([idElemeto])
REFERENCES [dbo].[bdElementos] ([Id])
GO
ALTER TABLE [dbo].[bdMovimientosBodegas] CHECK CONSTRAINT [FK_bdMB_bdElementos]
GO
/****** Object:  ForeignKey [FK_bdOS_bdProveedores]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdOrdenesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdOS_bdProveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[bdProveedores] ([Id])
GO
ALTER TABLE [dbo].[bdOrdenesServicios] CHECK CONSTRAINT [FK_bdOS_bdProveedores]
GO
/****** Object:  ForeignKey [FK_OS_bdRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdOrdenesServicios]  WITH CHECK ADD  CONSTRAINT [FK_OS_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemisiones] ([Id])
GO
ALTER TABLE [dbo].[bdOrdenesServicios] CHECK CONSTRAINT [FK_OS_bdRemisiones]
GO
/****** Object:  ForeignKey [FK_PS_bdParametros]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdParametrosSistema]  WITH CHECK ADD  CONSTRAINT [FK_PS_bdParametros] FOREIGN KEY([idParametro])
REFERENCES [dbo].[bdParametros] ([Id])
GO
ALTER TABLE [dbo].[bdParametrosSistema] CHECK CONSTRAINT [FK_PS_bdParametros]
GO
/****** Object:  ForeignKey [FK_PR_bdPrivilegios]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdPrivilegiosRoles]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdPrivilegios] FOREIGN KEY([idPrivilegio])
REFERENCES [dbo].[bdPrivilegios] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegiosRoles] CHECK CONSTRAINT [FK_PR_bdPrivilegios]
GO
/****** Object:  ForeignKey [FK_PR_bdRoles]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdPrivilegiosRoles]  WITH CHECK ADD  CONSTRAINT [FK_PR_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRoles] ([Id])
GO
ALTER TABLE [dbo].[bdPrivilegiosRoles] CHECK CONSTRAINT [FK_PR_bdRoles]
GO
/****** Object:  ForeignKey [FK_bdP_bdCiudades]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdProyectos]  WITH CHECK ADD  CONSTRAINT [FK_bdP_bdCiudades] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[bdCiudades] ([Id])
GO
ALTER TABLE [dbo].[bdProyectos] CHECK CONSTRAINT [FK_bdP_bdCiudades]
GO
/****** Object:  ForeignKey [FK_bdP_bdClientes]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdProyectos]  WITH CHECK ADD  CONSTRAINT [FK_bdP_bdClientes] FOREIGN KEY([idCliente])
REFERENCES [dbo].[bdClientes] ([Id])
GO
ALTER TABLE [dbo].[bdProyectos] CHECK CONSTRAINT [FK_bdP_bdClientes]
GO
/****** Object:  ForeignKey [FK_bdPA_bdProyectos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdProyectosAlquileres]  WITH CHECK ADD  CONSTRAINT [FK_bdPA_bdProyectos] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyectos] ([Id])
GO
ALTER TABLE [dbo].[bdProyectosAlquileres] CHECK CONSTRAINT [FK_bdPA_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdPV_bdProyectos]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdProyectosVentas]  WITH CHECK ADD  CONSTRAINT [FK_bdPV_bdProyectos] FOREIGN KEY([idProyecto])
REFERENCES [dbo].[bdProyectos] ([Id])
GO
ALTER TABLE [dbo].[bdProyectosVentas] CHECK CONSTRAINT [FK_bdPV_bdProyectos]
GO
/****** Object:  ForeignKey [FK_bdR_bdProyectosAlquileres]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdRemisiones]  WITH CHECK ADD  CONSTRAINT [FK_bdR_bdProyectosAlquileres] FOREIGN KEY([idProyectoAlquiler])
REFERENCES [dbo].[bdProyectosAlquileres] ([Id])
GO
ALTER TABLE [dbo].[bdRemisiones] CHECK CONSTRAINT [FK_bdR_bdProyectosAlquileres]
GO
/****** Object:  ForeignKey [FK_bdR_bdProyectosVentas]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdRemisiones]  WITH CHECK ADD  CONSTRAINT [FK_bdR_bdProyectosVentas] FOREIGN KEY([idProyectoVenta])
REFERENCES [dbo].[bdProyectosVentas] ([Id])
GO
ALTER TABLE [dbo].[bdRemisiones] CHECK CONSTRAINT [FK_bdR_bdProyectosVentas]
GO
/****** Object:  ForeignKey [FK_bdRemisiones_bdConductores]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdRemisiones]  WITH CHECK ADD  CONSTRAINT [FK_bdRemisiones_bdConductores] FOREIGN KEY([idConductor])
REFERENCES [dbo].[bdConductores] ([Id])
GO
ALTER TABLE [dbo].[bdRemisiones] CHECK CONSTRAINT [FK_bdRemisiones_bdConductores]
GO
/****** Object:  ForeignKey [FK_bdRDS_bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdRepDevolucionesServicios]  WITH CHECK ADD  CONSTRAINT [FK_bdRDS_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevoluciones] ([Id])
GO
ALTER TABLE [dbo].[bdRepDevolucionesServicios] CHECK CONSTRAINT [FK_bdRDS_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_dbR_bdDevoluciones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdReposiciones]  WITH CHECK ADD  CONSTRAINT [FK_dbR_bdDevoluciones] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[bdDevoluciones] ([Id])
GO
ALTER TABLE [dbo].[bdReposiciones] CHECK CONSTRAINT [FK_dbR_bdDevoluciones]
GO
/****** Object:  ForeignKey [FK_U_bdRoles]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_U_bdRoles] FOREIGN KEY([idRol])
REFERENCES [dbo].[bdRoles] ([Id])
GO
ALTER TABLE [dbo].[bdUsuarios] CHECK CONSTRAINT [FK_U_bdRoles]
GO
/****** Object:  ForeignKey [FK_bdVentas_bdRemisiones]    Script Date: 03/16/2013 19:16:38 ******/
ALTER TABLE [dbo].[bdVentas]  WITH CHECK ADD  CONSTRAINT [FK_bdVentas_bdRemisiones] FOREIGN KEY([idRemision])
REFERENCES [dbo].[bdRemisiones] ([Id])
GO
ALTER TABLE [dbo].[bdVentas] CHECK CONSTRAINT [FK_bdVentas_bdRemisiones]
GO
