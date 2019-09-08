use master
go

create database TPII_ProgIII
go

use TPII_ProgIII
go

create table Articulos
(
ID int identity (1,1),
Descripcion varchar(255),
Imagen varchar(255),
Nombre varchar(255),
)
go

create table Marcas
(
ID int identity (1,1),
Logo varchar(255),
Nombre varchar(255)
)
go

create table Categorias
(
ID int identity (1,1),
Codigo varchar(255)
)
go