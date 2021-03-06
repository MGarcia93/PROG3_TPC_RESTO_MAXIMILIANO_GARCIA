

use master 
go
 drop database [Garcia_Maximiliano_DB]
 go
 CREATE DATABASE Garcia_Maximiliano_DB
GO
USE Garcia_Maximiliano_DB
go
SET DATEFORMAT dmy;
go
CREATE TABLE permisos(
id	int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
estado bit not null default 1
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
estado bit not null default 1
)

go
CREATE TABLE personal(
legajo	int primary key not null identity(000001,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
dni varchar(8) not null,
sexo char check(sexo='M' or sexo='F'),
cargo varchar(15) not null check(cargo='mesero' or cargo='gerente'),
fechaNacimiento date not null,
estado bit not null default 1
)

go
CREATE TABLE usuarios(
	userName varchar(20) not null primary key,
	pass varchar(30) not null,
	idPermiso int not null foreign key references permisos(id),
	create_at date default getdate(),
	updated_at date,
	deleted bit default 0
)

go
CREATE TABLE tiposInsumos(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
estado bit not null default 1
)
go
CREATE TABLE insumos(
id int primary key not null identity(1,1),
idTipo int not null foreign key references tiposInsumos(id)
)
go
CREATE TABLE tiposPlatos(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
estado bit not null default 1
)

go
CREATE TABLE categoriasBebidas(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
estado bit not null default 1
)

go
CREATE TABLE marcas(
id int primary key not null identity(1,1),
descripcion varchar(50) not null unique,
estado bit not null default 1
)

CREATE TABLE marcasXcategorias(
idCategoria int not null foreign key references categoriasBebidas(id),
idMarca int not null foreign key references Marcas(id),
constraint pk_marcaxcategoria primary key(idCategoria,idMarca)
)

go
CREATE TABLE comidas(
id	int primary key not null foreign key references insumos(id),
nombre varchar(50) not null,
descripcion varchar(255) not null,
precio decimal(10,2) not null,
idTipo int foreign key references tiposPlatos(id),
estado bit not null default 1
)

go
CREATE TABLE bebidas(
id	int primary key not null foreign key references insumos(id),
descripcion varchar(50) not null,
contieneAlcohol bit not null,
precio decimal(10,2) not null,
idMarca int foreign key references marcas(id),
idCategoriaBebida int foreign key references categoriasBebidas(id),
estado bit not null default 1
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
idMesero int null foreign key references personal(legajo),
estado bit not null default 1
)

go
CREATE TABLE estadosPedidos(
id int primary key not null identity(1,1),
descripcion varchar(20) not null unique,
estado bit not null default 1
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
CREATE TABLE jornadas(
id			int not null primary key identity(1,1),
dia			date default getdate()
)
go
CREATE TABLE inventarios(
idJornada	int not null foreign key references jornadas(id),
idInsumo	int null foreign key references insumos(id),
cantidad	int not null default 5
)

go
CREATE TABLE pedidos(
id	int primary key not null identity(1,1),
fecha date not null default getdate(),
idMesa int not null foreign key references mesas(id),
idMesero int not null foreign key references personal(legajo),
idEstado int not null  foreign key references estadosPedidos(id) default 1,
idJornada int not null foreign key references jornadas(id),
estado bit not null default 1
)
go

CREATE TABLE detallesPedidos(
id int not null identity(1,1),
idPedido int not null foreign key references pedidos(id),
idInsumo  int not null foreign key references insumos(id),
cantidad  int not null,
precioUnit decimal(10,2) not null
constraint pk_detallePedidoComida primary key(idPedido,idInsumo),
)
go 


CREATE TRIGGER tr_insert_personal on personal
after insert
as 
begin
	declare @idPermiso int
	select @idPermiso=id from permisos where descripcion=(select cargo from inserted)
	insert into usuarios(userName,pass,idPermiso) select legajo,dni,@idPermiso from inserted
end

go
create trigger tr_insert_insumo on insumos
after insert
as 
begin
	insert inventarios(idJornada,idInsumo)
	select 0,id from inserted
end
go
create trigger tr_delete_comida on comidas
instead of delete
as 
begin
	declare @id int
	select @id=id from deleted
	if((select estado from deleted)=1)
	begin
		update comidas set estado=0 where id=@id
		delete from inventarios where idInsumo=@id
	end
end
go
create trigger tr_delete_bebida on bebidas
instead of delete
as 
begin
	declare @id int
	select @id=id from deleted
	if((select estado from deleted)=1)
	begin
		update bebidas set estado=0 where id=@id
		delete from inventarios where idInsumo=@id
		
 	end
end

go
create trigger tr_insert_comida on comidas
instead of insert
as
begin
	insert into insumos(idTipo) values(2)
	declare @id int
	select @id=max(id) from insumos
	insert into comidas(id,[nombre], [descripcion], [precio], [idTipo])
	select @id,nombre,descripcion,precio,idTipo from inserted
end

go
create trigger tr_insert_bebida on bebidas
instead of insert
as
begin
	insert into insumos(idTipo) values(1)
	declare @id int
	select @id=max(id) from Insumos
	insert into bebidas(id,descripcion, contieneAlcohol, precio, idMarca,idCategoriaBebida)
	select @id,descripcion, contieneAlcohol, precio, idMarca,idCategoriaBebida from inserted
end


GO
SET IDENTITY_INSERT [dbo].[permisos] ON 

INSERT [dbo].[permisos] ([id], [descripcion], [estado]) VALUES (1, N'gerente', 1)
INSERT [dbo].[permisos] ([id], [descripcion], [estado]) VALUES (2, N'mesero', 1)
INSERT [dbo].[permisos] ([id], [descripcion], [estado]) VALUES (3, N'cliente', 1)
SET IDENTITY_INSERT [dbo].[permisos] OFF
SET IDENTITY_INSERT [dbo].[personal] ON 

INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento], [estado]) VALUES (0, N'joaquin', N'ledesma', N'admin', N'M', N'gerente', CAST(N'2000-02-08' AS Date), 1)
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento], [estado]) VALUES (1, N'maximiliano', N'Garcia', N'37358816', N'M', N'mesero', CAST(N'2019-05-07' AS Date), 1)
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento], [estado]) VALUES (3, N'Florencia ', N'Carambu', N'12312312', N'F', N'gerente', CAST(N'2019-05-02' AS Date), 1)
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento], [estado]) VALUES (4, N'Nicolas', N'Ruarte', N'23451232', N'M', N'mesero', CAST(N'2019-02-13' AS Date), 1)
INSERT [dbo].[personal] ([legajo], [nombre], [apellido], [dni], [sexo], [cargo], [fechaNacimiento], [estado]) VALUES (5, N'joaquin', N'ledesma', N'1231412', N'M', N'mesero', CAST(N'2000-02-08' AS Date), 1)
SET IDENTITY_INSERT [dbo].[personal] OFF
SET IDENTITY_INSERT [dbo].[marcas] ON 

INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (1, N'Coca-Cola', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (2, N'Norton', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (3, N'Absolut', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (4, N'villa del sur', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (10, N'Cepita', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (11, N'AltaMora', 1)
INSERT [dbo].[marcas] ([id], [descripcion], [estado]) VALUES (12, N'Pepsi', 1)
SET IDENTITY_INSERT [dbo].[marcas] OFF

SET IDENTITY_INSERT [dbo].[categoriasBebidas] ON 

INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (1, N'Jugo', 1)
INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (2, N'Vino', 1)
INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (3, N'Gaseosa', 1)
INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (4, N'Licor', 1)
INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (5, N'Agua', 1)
INSERT [dbo].[categoriasBebidas] ([id], [descripcion], [estado]) VALUES (6, N'coctel', 1)
SET IDENTITY_INSERT [dbo].[categoriasBebidas] OFF


INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (1, 10)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (2, 2)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (2, 4)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (2, 11)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (3, 1)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (3, 12)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (4, 3)
INSERT [dbo].[marcasXcategorias] ([idCategoria], [idMarca]) VALUES (5, 4)
SET IDENTITY_INSERT [dbo].[tiposPlatos] ON 

INSERT [dbo].[tiposPlatos] ([id], [descripcion], [estado]) VALUES (1, N'Plato principal', 1)
INSERT [dbo].[tiposPlatos] ([id], [descripcion], [estado]) VALUES (2, N'Entrada', 1)
INSERT [dbo].[tiposPlatos] ([id], [descripcion], [estado]) VALUES (3, N'Postre', 1)
INSERT [dbo].[tiposPlatos] ([id], [descripcion], [estado]) VALUES (4, N'ensalada', 1)
SET IDENTITY_INSERT [dbo].[tiposPlatos] OFF


SET IDENTITY_INSERT [dbo].[jornadas] ON 

INSERT [dbo].[jornadas] ([id], [dia]) VALUES (0, NULL)
INSERT [dbo].[jornadas] ([id], [dia]) VALUES (1, CAST(N'2019-06-21' AS Date))
INSERT [dbo].[jornadas] ([id], [dia]) VALUES (2, CAST(N'2019-06-26' AS Date))
SET IDENTITY_INSERT [dbo].[jornadas] OFF

SET IDENTITY_INSERT [dbo].[Cargos] ON 

INSERT [dbo].[Cargos] ([id], [descripcion]) VALUES (1, N'Gerente')
INSERT [dbo].[Cargos] ([id], [descripcion]) VALUES (2, N'mesero')
SET IDENTITY_INSERT [dbo].[Cargos] OFF

sET IDENTITY_INSERT [dbo].[tiposInsumos] ON 

INSERT [dbo].[tiposInsumos] ([id], [descripcion], [estado]) VALUES (1, N'bebida', 1)
INSERT [dbo].[tiposInsumos] ([id], [descripcion], [estado]) VALUES (2, N'comida', 1)
SET IDENTITY_INSERT [dbo].[tiposInsumos] OFF

INSERT [dbo].[bebidas] ([id], [descripcion], [contieneAlcohol], [precio], [idMarca], [idCategoriaBebida], [estado]) VALUES (9, N'coca 600ml', 0, CAST(80.00 AS Decimal(10, 2)), 1, 3, 1)
INSERT [dbo].[bebidas] ([id], [descripcion], [contieneAlcohol], [precio], [idMarca], [idCategoriaBebida], [estado]) VALUES (10, N'bot 600ml', 0, CAST(50.00 AS Decimal(10, 2)), 4, 5, 1)
INSERT [dbo].[bebidas] ([id], [descripcion], [contieneAlcohol], [precio], [idMarca], [idCategoriaBebida], [estado]) VALUES (11, N'Cosacha tardia 750ml', 1, CAST(150.00 AS Decimal(10, 2)), 2, 2, 1)

INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (1, N'Teque�os', N'aperitivo venezolano que consiste de una barra de queso envuelto en una masa de harina y fritos hasta quedar crujiente', CAST(100.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (2, N'Gazpacho', N'Sopa fr�a de tomate', CAST(125.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (3, N'Ceviche de pescado', N'pescado marinado en jugo de lim�n con aj�es o chiles picantes y ajo, y luego se mezcla con cebolla colorada, tomate, pimientos, y cilantro', CAST(120.00 AS Decimal(10, 2)), 2, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (4, N'calzone pugliese', N'masa de cerrada sobre s� misma, como si fuera una empanadilla, Rellena con tomate y mozzarella', CAST(200.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (5, N'Shakshuka con Chorizo', N'platillo t�pico del Medio Oriente y del norte de �frica, a base de huevos cocidos o escalfados (pochados) en una salsa espesa de tomate, cebolla, pimientos, y especias.', CAST(200.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (6, N'Lomo saltado de cerdo', N'Ingredientes: lomo de cerdo o chancho, cebolla, ajo, pimientos, aj�es, tomates, comino, vinagre, salsa de soya, cilantro y cebollita verde', CAST(220.00 AS Decimal(10, 2)), 1, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (7, N'Pionono deluxe', N'una larga l�mina de bizcocho relleno con crema, dulce de leche enrollado hasta formar una especie de cilindro.', CAST(150.00 AS Decimal(10, 2)), 3, 1)
INSERT [dbo].[comidas] ([id], [nombre], [descripcion], [precio], [idTipo], [estado]) VALUES (8, N'Panqueques Fantasia', N'una fina l�mina de masa a base de harina, cocinados en una sart�n. Untando dulce de leche y enrollando. Con un poco de crema como acompa�ante', CAST(130.00 AS Decimal(10, 2)), 3, 1)


INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (0, N'inactivo')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (1, N'libre')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (2, N'ocupada')
INSERT [dbo].[estadosMesas] ([id], [descripcion]) VALUES (3, N'reservado')
SET IDENTITY_INSERT [dbo].[estadosPedidos] ON 

INSERT [dbo].[estadosPedidos] ([id], [descripcion], [estado]) VALUES (1, N'Abierto', 1)
INSERT [dbo].[estadosPedidos] ([id], [descripcion], [estado]) VALUES (2, N'Cerrado', 1)
SET IDENTITY_INSERT [dbo].[estadosPedidos] OFF

SET IDENTITY_INSERT [dbo].[mesas] ON 

INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero], [estado]) VALUES (1, 1, 0, 2, NULL, 1)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero], [estado]) VALUES (2, 2, 0, 2, NULL, 1)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero], [estado]) VALUES (3, 3, 0, 6, NULL, 1)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero], [estado]) VALUES (4, 4, 0, 2, NULL, 1)
INSERT [dbo].[mesas] ([id], [numero], [idEstadoMesa], [cantidadComensales], [idMesero], [estado]) VALUES (5, 5, 0, 6, NULL, 1)
SET IDENTITY_INSERT [dbo].[mesas] OFF
SET IDENTITY_INSERT [dbo].[pedidos] ON 

INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (1, CAST(N'2019-06-21' AS Date), 1, 1, 2, 1, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (2, CAST(N'2019-06-26' AS Date), 3, 1, 2, 2, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (3, CAST(N'2019-06-26' AS Date), 1, 1, 2, 2, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (4, CAST(N'2019-06-26' AS Date), 1, 1, 2, 2, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (5, CAST(N'2019-06-26' AS Date), 4, 1, 2, 2, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (6, CAST(N'2019-06-26' AS Date), 3, 1, 2, 2, 1)
INSERT [dbo].[pedidos] ([id], [fecha], [idMesa], [idMesero], [idEstado], [idJornada], [estado]) VALUES (7, CAST(N'2019-06-26' AS Date), 3, 1, 2, 2, 1)
SET IDENTITY_INSERT [dbo].[pedidos] OFF


INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 1, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 2, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 3, 25)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 4, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 5, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 6, 25)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 7, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 8, 25)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 9, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 10, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (0, 11, 20)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 1, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 2, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 3, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 4, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 5, 10)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 6, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 7, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 8, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 9, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 10, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (1, 11, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 1, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 2, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 3, 2)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 4, 1)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 5, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 6, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 7, 5)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 8, 3)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 9, 3)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 10, 0)
INSERT [dbo].[inventarios] ([idJornada], [idInsumo], [cantidad]) VALUES (2, 11, 4)



SET IDENTITY_INSERT [dbo].[detallesPedidos] ON 

INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (2, 1, 2, 1, CAST(125.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (1, 1, 10, 2, CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (4, 2, 4, 3, CAST(200.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (5, 3, 9, 2, CAST(80.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (6, 4, 11, 1, CAST(150.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (7, 5, 3, 3, CAST(120.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (8, 6, 10, 3, CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (9, 7, 4, 1, CAST(200.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (10, 7, 8, 2, CAST(130.00 AS Decimal(10, 2)))
INSERT [dbo].[detallesPedidos] ([id], [idPedido], [idInsumo], [cantidad], [precioUnit]) VALUES (11, 7, 10, 2, CAST(50.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[detallesPedidos] OFF