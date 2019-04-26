CREATE DATABASE resto
GO
USE resto
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
idPermiso int foreign key references permisos(id)
)

go
CREATE TABLE personal(
legajo	bigint primary key not null identity(1,1),
nombre varchar(50) not null,
apellido varchar(50) not null,
dni varchar(8) not null,
sexo char check(sexo='M' or sexo='F'),
idCargo int foreign key references cargos(id),
idPermiso int foreign key references permisos(id)
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
cantidad int not null,
precio money,
idTipo int foreign key references tiposPlatos(id)
)

go
CREATE TABLE bebidas(
id	bigint primary key not null identity(1,1),
nombre varchar(50) not null,
descripcion varchar(255) not null,
contineAlcohol bit not null,
cantidad int not null,
precio money,
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
CREATE TABLE detalesPedidos(
idPedido bigint not null foreign key references pedidos(id),
idComida  bigint null foreign key references comidas(id),
idBebida  bigint null foreign key references bebidas(id),
constraint pk_detallePedido unique(idPedido,idComida,idBebida),
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