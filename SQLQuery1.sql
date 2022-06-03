use FormSQL
create table Cliente
(
	NombreCliente varchar(40) NOT NULL,
	ApellidosCliente varchar(40) NOT NULL,
	DNIcliente char(8) PRIMARY KEY,
	TelefonoCliente char(9) NOT NULL,
	DireccionCliente varchar(100) NOT NULL,
	CorreoCliente varchar(40) NOT NULL
)

create table Empleado
(
	NombreEmpleado varchar(60) NOT NULL,
	DNIempleado char(8) PRIMARY KEY,
	DireccionEmpleado varchar(100) NOT NULL,
	HijosEmpleados int NOT NULL,
	ExperienciaLaboralEmpleado char(2) NOT NULL,
	SueldoFijoEmpleado float NOT NULL
)

create table Proveedor
(
	NombreProveedor varchar(60) NOT NULL,
	IDproveedor char(5) PRIMARY KEY,
	TelefonoProveedor char(9) NOT NULL,
	CorreoCliente varchar(40) NOT NULL
)
drop table if exists Producto
create table Producto
(
	IDproducto char(5) PRIMARY KEY,
	IDproveedor char(5) NOT NULL,
	NombreProducto varchar(20) NOT NULL,
	PrecioProducto float NOT NULL
)
drop table if exists ComprarProductos
create table ComprarProductos
(
	IDcompra char(5) PRIMARY KEY,
	DNIcliente char(8) NOT NULL,
	DNIempleado char(8)NOT NULL,
	CostoTotal float NOT NULL
)

create table SalarioTrabajador
(
	IDsalario char(5) PRIMARY KEY,
	DNIcliente char(8) FOREIGN KEY(DNIcliente) references Cliente(DNIcliente),
	ComisionPorVenta float NOT NULL,
	CantidadVentas int NOT NULL
)

create table GananciaProducto
(
	IDganancia char(5) PRIMARY KEY,
	GananciaProducto float NOT NULL,
	CostoProducto float NOT NULL
)

Select *From Empleado
Select *From Producto