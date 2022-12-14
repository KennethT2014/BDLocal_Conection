Create database Productos
go
use Productos
go
Create table Producto
(IdProducto int primary key identity(1,1),
IdCategoria int,
NombreProducto varchar(50),
CantidadExistente int,
Precio int,
estado varchar(50))

Create table Categoria
(IdCategoria int primary key identity(1,1),
NombreCategoria varchar(50))

Alter table Categoria
add foreign key (IdCategoria) references Categoria(IdCategoria)

Insert into
Producto(NombreProducto, CantidadExistente, Precio, estado) values
('MacBookProM1', 20, 1500, 'Habilitado')

Select * from Producto

Insert into
Categoria(NombreCategoria) values ('Computadora Laptop')

Select * from Categoria
