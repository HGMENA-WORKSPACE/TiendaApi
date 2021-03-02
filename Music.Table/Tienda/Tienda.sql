CREATE DATABASE [TiendaDb];
GO

USE [TiendaDb]
GO

/******  Schema [tienda]   ******/
CREATE SCHEMA [tienda]
GO

/******  Table [tienda].[DetalleOrden]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tienda].[DetalleOrden](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrdenId] [int] NOT NULL,
	[ProductoId] [int] NOT NULL,
	[Cantidad] [decimal](18, 2) NOT NULL,
	[PrecioUnitario] [decimal](18, 2) NOT NULL,
	[Total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_DetalleOrden] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/******  Table [tienda].[Orden]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tienda].[Orden](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CantidadArticulos] [decimal](18, 2) NOT NULL,
	[Importe] [decimal](18, 2) NOT NULL,
	[FechaRegistro] [datetime2](7) NOT NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[UsuarioId] [int] NOT NULL,
	[EstatusOrden] [int] NOT NULL,
 CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/******  Table [tienda].[Perfil]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tienda].[Perfil](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/******  Table [tienda].[Producto]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tienda].[Producto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](256) NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Estatus] [int] NOT NULL,
	[FechaRegistro] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/******  Table [tienda].[Usuario]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [tienda].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellidos] [nvarchar](256) NULL,
	[Email] [nvarchar](100) NULL,
	[Username] [nvarchar](25) NULL,
	[Password] [nvarchar](512) NULL,
	[Estatus] [int] NOT NULL,
	[PerfilId] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [tienda].[Perfil] ON 

INSERT [tienda].[Perfil] ([Id], [Nombre]) VALUES (1, N'Administrador')
INSERT [tienda].[Perfil] ([Id], [Nombre]) VALUES (2, N'Vendedor')
INSERT [tienda].[Perfil] ([Id], [Nombre]) VALUES (3, N'Cliente')
SET IDENTITY_INSERT [tienda].[Perfil] OFF
SET IDENTITY_INSERT [tienda].[Producto] ON 

INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (1, N'Guitarra Eléctrica PRS SE Custom 24', CAST(15000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (2, N'Guitarra Eléctrica Yamaha Pacifica 112V', CAST(6000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (3, N'Guitarra Eléctrica Ibanez 550G', CAST(20000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (4, N'Saxofón Yamaha YAS-62', CAST(45000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (5, N'Saxofón Selmer AS-42', CAST(60000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (6, N'Saxofón Selmer TS-44 ', CAST(50000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (7, N'Guitarra Electroacústica Gibson-J200', CAST(80000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (8, N'Guitarra Electroacústica Taylor 614-ce', CAST(80000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (9, N'Guitarra Electroacústica Phoenix Luna', CAST(20000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (10, N'Piano Yamaha YDP143B Arius', CAST(20000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (11, N'Piano Controlador Komplete Control S88', CAST(25000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
INSERT [tienda].[Producto] ([Id], [Nombre], [Precio], [Estatus], [FechaRegistro]) VALUES (12, N'Korg B1SP 88 Weighted Key Digital Piano', CAST(12000.00 AS Decimal(18, 2)), 1, CAST(0x070000000000233F0B AS DateTime2))
SET IDENTITY_INSERT [tienda].[Producto] OFF
SET IDENTITY_INSERT [tienda].[Usuario] ON 

INSERT [tienda].[Usuario] ([Id], [Nombre], [Apellidos], [Email], [Username], [Password], [Estatus], [PerfilId]) VALUES (1, N'Admin', N'Admin', N'admin@correo.com', N'admin', N'123456', 1, 1)
INSERT [tienda].[Usuario] ([Id], [Nombre], [Apellidos], [Email], [Username], [Password], [Estatus], [PerfilId]) VALUES (2, N'Vendedor', N'Vendedor', N'vendedor@correo.com', N'vendedor', N'123456', 1, 2)
INSERT [tienda].[Usuario] ([Id], [Nombre], [Apellidos], [Email], [Username], [Password], [Estatus], [PerfilId]) VALUES (3, N'Cliente', N'Cliente', N'cliente@correo.com', N'cliente', N'123456', 1, 3)
SET IDENTITY_INSERT [tienda].[Usuario] OFF

SET IDENTITY_INSERT [tienda].[Orden] ON 

INSERT [tienda].[Orden] ([Id], [CantidadArticulos], [Importe], [FechaRegistro], [FechaActualizacion], [UsuarioId], [EstatusOrden]) VALUES (1, CAST(2.00 AS Decimal(18, 2)), CAST(35000.00 AS Decimal(18, 2)), CAST(0x07A257C9661CBC3F0B AS DateTime2), NULL, 1, 1)
INSERT [tienda].[Orden] ([Id], [CantidadArticulos], [Importe], [FechaRegistro], [FechaActualizacion], [UsuarioId], [EstatusOrden]) VALUES (2, CAST(2.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)), CAST(0x07ACE2ED831CBC3F0B AS DateTime2), NULL, 1, 1)
INSERT [tienda].[Orden] ([Id], [CantidadArticulos], [Importe], [FechaRegistro], [FechaActualizacion], [UsuarioId], [EstatusOrden]) VALUES (3, CAST(1.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), CAST(0x070C76E9AB1CBC3F0B AS DateTime2), NULL, 1, 1)
SET IDENTITY_INSERT [tienda].[Orden] OFF

SET IDENTITY_INSERT [tienda].[DetalleOrden] ON 

INSERT [tienda].[DetalleOrden] ([Id], [OrdenId], [ProductoId], [Cantidad], [PrecioUnitario], [Total]) VALUES (1, 1, 1, CAST(1.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)))
INSERT [tienda].[DetalleOrden] ([Id], [OrdenId], [ProductoId], [Cantidad], [PrecioUnitario], [Total]) VALUES (2, 1, 3, CAST(1.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
INSERT [tienda].[DetalleOrden] ([Id], [OrdenId], [ProductoId], [Cantidad], [PrecioUnitario], [Total]) VALUES (3, 2, 7, CAST(2.00 AS Decimal(18, 2)), CAST(80000.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)))
INSERT [tienda].[DetalleOrden] ([Id], [OrdenId], [ProductoId], [Cantidad], [PrecioUnitario], [Total]) VALUES (4, 3, 5, CAST(1.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)), CAST(60000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [tienda].[DetalleOrden] OFF

/******  Index [IX_DetalleOrden_OrdenId]    ******/
CREATE NONCLUSTERED INDEX [IX_DetalleOrden_OrdenId] ON [tienda].[DetalleOrden]
(
	[OrdenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/******  Index [IX_DetalleOrden_ProductoId]    ******/
CREATE NONCLUSTERED INDEX [IX_DetalleOrden_ProductoId] ON [tienda].[DetalleOrden]
(
	[ProductoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/******  Index [IX_Orden_UsuarioId]    ******/
CREATE NONCLUSTERED INDEX [IX_Orden_UsuarioId] ON [tienda].[Orden]
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/******  Index [IX_Usuario_PerfilId]    ******/
CREATE NONCLUSTERED INDEX [IX_Usuario_PerfilId] ON [tienda].[Usuario]
(
	[PerfilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [tienda].[DetalleOrden]  WITH CHECK ADD  CONSTRAINT [FK_DetalleOrden_Orden_OrdenId] FOREIGN KEY([OrdenId])
REFERENCES [tienda].[Orden] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [tienda].[DetalleOrden] CHECK CONSTRAINT [FK_DetalleOrden_Orden_OrdenId]
GO
ALTER TABLE [tienda].[DetalleOrden]  WITH CHECK ADD  CONSTRAINT [FK_DetalleOrden_Producto_ProductoId] FOREIGN KEY([ProductoId])
REFERENCES [tienda].[Producto] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [tienda].[DetalleOrden] CHECK CONSTRAINT [FK_DetalleOrden_Producto_ProductoId]
GO
ALTER TABLE [tienda].[Orden]  WITH CHECK ADD  CONSTRAINT [FK_Orden_Usuario_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [tienda].[Usuario] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [tienda].[Orden] CHECK CONSTRAINT [FK_Orden_Usuario_UsuarioId]
GO
ALTER TABLE [tienda].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil_PerfilId] FOREIGN KEY([PerfilId])
REFERENCES [tienda].[Perfil] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [tienda].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil_PerfilId]
GO
ALTER DATABASE [TiendaDb] SET  READ_WRITE 
GO
