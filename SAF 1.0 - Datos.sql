GO
SET IDENTITY_INSERT [dbo].[bdRoles] ON 

INSERT [dbo].[bdRoles] ([Id], [Nombre], [Activo]) VALUES (1, N'Administrador', 1)
SET IDENTITY_INSERT [dbo].[bdRoles] OFF
SET IDENTITY_INSERT [dbo].[bdUsuarios] ON 

INSERT [dbo].[bdUsuarios] ([Id], [idRol], [Identificacion], [Nombre], [Apellido], [Usuario], [Clave], [Correo], [Activo]) VALUES (2, 1, N'admin', N'admin', N'admin', N'admin', N'admin', N'admin', 1)
SET IDENTITY_INSERT [dbo].[bdUsuarios] OFF
SET ANSI_PADDING ON