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
id	bigint primary key not null identity(1,1),
nombre varchar(50) null,
apellido varchar(50) null,
sexo char check(sexo='M' or sexo='F'),
)

go
CREATE TABLE personal(
legajo	bigint primary key not null identity(1,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
dni varchar(8) not null,
sexo char check(sexo='M' or sexo='F'),
idCargo int foreign key references cargos(id)
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
descripcion varchar(50) not null unique
)

go
CREATE TABLE comidas(
id	bigint primary key not null identity(1,1),
nombre varchar(50) not null,
descripcion varchar(255) not null,
precio decimal(10,2) not null,
idTipo int foreign key references tiposPlatos(id)
)

go
CREATE TABLE bebidas(
id	bigint primary key not null identity(1,1),
nombre varchar(50) not null,
descripcion varchar(255) not null,
contineAlcohol bit not null,
precio decimal(10,2) not null,
idMarca int foreign key references marcas(id),
idCategoriaBebida int foreign key references categoriasBebidas(id)
)

go
CREATE TABLE estadosMesas(
id int primary key not null identity(1,1),
descripcion varchar(20) not null unique
)

go
CREATE TABLE mesas(
id	int primary key not null identity(1,1),
idEstadoMesa int not null foreign key references EstadosMesas(id), 
cantidadComensales int not null,
idMesero bigint not null foreign key references personal(legajo)
)

go
CREATE TABLE estadosPedidos(
id int primary key not null identity(1,1),
descripcion varchar(20) not null unique
)

go
CREATE TABLE pedidos(
id	bigint primary key not null identity(1,1),
fecha date not null default getdate(),
idMesa int not null foreign key references mesas(id),
idMesero bigint not null foreign key references personal(legajo),
idEstado int not null foreign key references estadosPedidos(id),
)

go
CREATE TABLE detalesPedidosComida(
idPedido bigint not null foreign key references pedidos(id),
idComida  bigint not null foreign key references comidas(id),
cantidad  int not null,
precioUnit decimal(10,2) not null
constraint pk_detallePedidoComida primary key(idPedido,idComida),
)

go
CREATE TABLE detalesPedidosBebida(
idPedido bigint not null foreign key references pedidos(id),
idBebida  bigint not null foreign key references Bebidas(id),
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
id	bigint primary key not null identity(1,1),
fecha date not null default getdate(),
idMesa int not null foreign key references mesas(id),
idCliente bigint not null foreign key references clientes(id),
idEstado int not null foreign key references franjasHorarias(id),
)
go
create table usuarios(
id		bigint not null primary key identity(1,1),
nombre  varchar(20) not null,
pass varchar(255) not null,
idPermiso int not null foreign key references permisos(id)
)

go
insert into estadosPedidos(descripcion) values('Abierto'),('Cerrado')

insert into estadosMesas(descripcion) values ('libre'),('reservado'),('ocupada')
go
insert into  Cargos(descripcion) values('Gerente'),('mesero')
go
insert into tiposInsumos(descripcion) values('bebida'),('comida')
go
insert into tiposPlatos(descripcion) values('Plato principal'),('Entrada'),('Postre')
go 
insert into categoriasBebidas(descripcion) values('Jugo'),('Vino'),('Gaseosa'),('Licor'),('Agua')
go
insert into marcas (descripcion) values ('Coca-Cola'),('Norton'),('Absolut'),('Del valle')
go 
insert into permisos(descripcion) values('total'),('mesero'),('cliente')
