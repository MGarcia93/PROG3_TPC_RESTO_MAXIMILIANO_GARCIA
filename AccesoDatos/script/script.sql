

use master 
go
 drop database if exists [TPC_Garcia_Maximiliano]
 go
 CREATE DATABASE TPC_Garcia_Maximiliano
GO
USE TPC_Garcia_Maximiliano
go
CREATE TABLE permisos(
id	int primary key not null identity(1,1),
descripcion varchar(50) not null unique
)
go
CREATE TABLE Cargos(
id	int primary key not null identity(1,1),
descripcion varchar(50) not null unique
)

go
CREATE TABLE clientes(
id	int primary key not null identity(1,1),
nombre varchar(50) null,
apellido varchar(50) null,
sexo char check(sexo='M' or sexo='F'),
)

go
CREATE TABLE personal(
legajo	int primary key not null identity(1,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
dni varchar(8) not null,
sexo char check(sexo='M' or sexo='F'),
cargo varchar(15) not null check(cargo='mesero' or cargo='encargado'),
fechaNacimiento date not null
)

go
CREATE TABLE tiposInsumos(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique
)

go
CREATE TABLE tiposPlatos(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique
)

go
CREATE TABLE categoriasBebidas(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique
)

go
CREATE TABLE marcas(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
)

CREATE TABLE marcasXcategorias(
idCategoria int not null foreign key references categoriasBebidas(id),
idMarca int not null foreign key references Marcas(id),
constraint pk_marcaxcategoria primary key(idCategoria,idMarca)
)

go
CREATE TABLE comidas(
id	int primary key not null identity(1,1),
nombre varchar(50) not null,
descripcion varchar(255) not null,
precio decimal(10,2) not null,
idTipo int foreign key references tiposPlatos(id)
)

go
CREATE TABLE bebidas(
id	int primary key not null identity(1,1),
nombre varchar(50) not null,
contieneAlcohol bit not null,
precio decimal(10,2) not null,
idMarca int foreign key references marcas(id),
idCategoriaBebida int foreign key references categoriasBebidas(id)
)

go
CREATE TABLE estadosMesas(
id int primary key not null,
descripcion varchar(20) not null unique
)

go
CREATE TABLE mesas(
id	int primary key not null identity(1,1),
numero int not null,
idEstadoMesa int not null foreign key references EstadosMesas(id), 
cantidadComensales int not null,
idMesero int null foreign key references personal(legajo)
)

go
CREATE TABLE estadosPedidos(
id int primary key not null identity(1,1),
descripcion varchar(20) not null unique
)

go
CREATE TABLE pedidos(
id	int primary key not null identity(1,1),
fecha date not null default getdate(),
idMesa int not null foreign key references mesas(id),
idMesero int not null foreign key references personal(legajo),
idEstado int not null foreign key references estadosPedidos(id),
)

go
CREATE TABLE detallesPedidosComida(
idPedido int not null foreign key references pedidos(id),
idComida  int not null foreign key references comidas(id),
cantidad  int not null,
precioUnit decimal(10,2) not null
constraint pk_detallePedidoComida primary key(idPedido,idComida),
)

go
CREATE TABLE detallesPedidosBebida(
idPedido int not null foreign key references pedidos(id),
idBebida  int not null foreign key references Bebidas(id),
cantidad  int not null,
precioUnit decimal(10,2) not null
constraint pk_detallePedidoBebida primary key(idPedido,idBebida),
)

go
CREATE TABLE franjasHorarias(
id int primary key not null identity(1,1),
descripcion varchar(20) not null unique
)

go

CREATE TABLE reservas(
id	int primary key not null identity(1,1),
fecha date not null default getdate(),
idMesa int not null foreign key references mesas(id),
idCliente int not null foreign key references clientes(id),
idEstado int not null foreign key references franjasHorarias(id),
)
go
create table usuarios(
id		int not null primary key identity(1,1),
nombre  varchar(20) not null,
pass varchar(255) not null,
idPermiso int not null foreign key references permisos(id)
)
go
insert into estadosPedidos(descripcion) values('Abierto'),('Cerrado')

insert into estadosMesas(id,descripcion) values (0,'inactivo'),(1,'libre'),(2,'reservado'),(3,'ocupada')
go
insert into  Cargos(descripcion) values('Gerente'),('mesero')
go
insert into tiposInsumos(descripcion) values('bebida'),('comida')
go
insert into tiposPlatos(descripcion) values('Plato principal'),('Entrada'),('Postre')
go 
insert into categoriasBebidas(descripcion) values('Jugo'),('Vino'),('Gaseosa'),('Licor'),('Agua')
go
insert into marcas (descripcion) values ('Coca-Cola'),('Norton'),('Absolut'),('villa del sur')
go 
insert into permisos(descripcion) values('total'),('mesero'),('cliente')
go 
insert into marcasXcategorias(idCategoria,idMarca) values (3,1),(2,2),(4,3),(2,4),(5,4)

SET IDENTITY_INSERT [dbo].[permisos] ON 
INSERT [dbo].[permisos] ([id], [descripcion]) VALUES (3, N'cliente')
INSERT [dbo].[permisos] ([id], [descripcion]) VALUES (2, N'mesero')
INSERT [dbo].[permisos] ([id], [descripcion]) VALUES (1, N'total')
SET IDENTITY_INSERT [dbo].[permisos] OFF
SET IDENTITY_INSERT [dbo].[personal] ON 

INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento]) VALUES (1, N'maximiliano', N'Garcia', N'37358816', N'M', N'mesero', CAST(N'2019-05-07' AS Date))
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento]) VALUES (3, N'Florencia ', N'Carambu', N'12312312', N'F', N'encargado', CAST(N'2019-05-02' AS Date))
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento]) VALUES (4, N'Nicolas', N'Ruarte', N'23451232', N'M', N'mesero', CAST(N'2019-02-13' AS Date))
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento]) VALUES (5, N'joaquin', N'ledesma', N'1231412', N'M', N'mesero', CAST(N'2000-02-08' AS Date))
SET IDENTITY_INSERT [dbo].[personal] OFF
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (0, N'inactivo')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (1, N'libre')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (3, N'ocupada')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (2, N'reservado')
SET IDENTITY_INSERT [dbo].[mesas] ON 

INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero]) VALUES (1, 1, 0, 2, NULL)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero]) VALUES (2, 2, 0, 2, NULL)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero]) VALUES (3, 3, 0, 6, NULL)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero]) VALUES (4, 4, 0, 2, NULL)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero]) VALUES (5, 5, 0, 6, NULL)
SET IDENTITY_INSERT [dbo].[mesas] OFF
SET IDENTITY_INSERT [dbo].[estadosPedidos] ON 

INSERT [dbo].[estadosPedidos] ([id], [descripcion]) VALUES (1, N'Abierto')
INSERT [dbo].[estadosPedidos] ([id], [descripcion]) VALUES (2, N'Cerrado')
SET IDENTITY_INSERT [dbo].[estadosPedidos] OFF
SET IDENTITY_INSERT [dbo].[tiposPlatos] ON 

INSERT [dbo].[tiposPlatos] ([id], [descripcion]) VALUES (2, N'Entrada')
INSERT [dbo].[tiposPlatos] ([id], [descripcion]) VALUES (1, N'Plato principal')
INSERT [dbo].[tiposPlatos] ([id], [descripcion]) VALUES (3, N'Postre')
SET IDENTITY_INSERT [dbo].[tiposPlatos] OFF
SET IDENTITY_INSERT [dbo].[comidas] ON 

INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (1, N'Tequeños', N'aperitivo venezolano que consiste de una barra de queso envuelto en una masa de harina y fritos hasta quedar crujiente', CAST(100.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (2, N'Gazpacho', N'Sopa fría de tomate', CAST(125.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (3, N'Ceviche de pescado', N'pescado marinado en jugo de limón con ajíes o chiles picantes y ajo, y luego se mezcla con cebolla colorada, tomate, pimientos, y cilantro', CAST(120.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (4, N'calzone pugliese', N'masa de cerrada sobre sí misma, como si fuera una empanadilla, Rellena con tomate y mozzarella', CAST(200.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (5, N'Shakshuka con Chorizo', N'platillo típico del Medio Oriente y del norte de África, a base de huevos cocidos o escalfados (pochados) en una salsa espesa de tomate, cebolla, pimientos, y especias.', CAST(200.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (6, N'Lomo saltado de cerdo', N'Ingredientes: lomo de cerdo o chancho, cebolla, ajo, pimientos, ajíes, tomates, comino, vinagre, salsa de soya, cilantro y cebollita verde', CAST(220.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (7, N'Pionono deluxe', N'una larga lámina de bizcocho relleno con crema, dulce de leche enrollado hasta formar una especie de cilindro.', CAST(150.00 AS Decimal(10, 2)), 3)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo]) VALUES (8, N'Panqueques Fantasia', N'una fina lámina de masa a base de harina, cocinados en una sartén. Untando dulce de leche y enrollando. Con un poco de crema como acompañante', CAST(130.00 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[comidas] OFF
SET IDENTITY_INSERT [dbo].[categoriasBebidas] ON 

INSERT [dbo].[categoriasBebidas] ([id], [descripcion]) VALUES (5, N'Agua')
INSERT [dbo].[categoriasBebidas] ([id], [descripcion]) VALUES (3, N'Gaseosa')
INSERT [dbo].[categoriasBebidas] ([id], [descripcion]) VALUES (1, N'Jugo')
INSERT [dbo].[categoriasBebidas] ([id], [descripcion]) VALUES (4, N'Licor')
INSERT [dbo].[categoriasBebidas] ([id], [descripcion]) VALUES (2, N'Vino')
SET IDENTITY_INSERT [dbo].[categoriasBebidas] OFF
SET IDENTITY_INSERT [dbo].[marcas] ON 

INSERT [dbo].[marcas] ([id], [descripcion]) VALUES (3, N'Absolut')
INSERT [dbo].[marcas] ([id], [descripcion]) VALUES (1, N'Coca-Cola')
INSERT [dbo].[marcas] ([id], [descripcion]) VALUES (2, N'Norton')
INSERT [dbo].[marcas] ([id], [descripcion]) VALUES (4, N'villa del sur')
SET IDENTITY_INSERT [dbo].[marcas] OFF
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (2, 2)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (2, 4)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (3, 1)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (4, 3)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (5, 4)
SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([id], [descripcion]) VALUES (1, N'Gerente')
INSERT [dbo].[Cargos] ([id], [descripcion]) VALUES (2, N'mesero')
SET IDENTITY_INSERT [dbo].[Cargos] OFF
SET IDENTITY_INSERT [dbo].[tiposInsumos] ON 

INSERT [dbo].[tiposInsumos] ([id], [descripcion]) VALUES (1, N'bebida')
INSERT [dbo].[tiposInsumos] ([id], [descripcion]) VALUES (2, N'comida')
SET IDENTITY_INSERT [dbo].[tiposInsumos] OFF