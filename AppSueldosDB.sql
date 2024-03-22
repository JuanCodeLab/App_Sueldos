CREATE DATABASE AppSueldosDB /* CREACION DE DATABASE */
GO
USE DATABASE AppSueldosDB /* INSERCION Y USO DE DATABASE */
GO

CREATE TABLE Usuario  /* CREACION DE TABLA USUARIOS */
(
	Id UNIQUEIDENTIFIER primary Key default NEWID(),
	Username varchar (30) unique not null,
	Pass varchar (100) not null,
	Nombre varchar (30) not null,
	Apellido varchar (30) not null,
	Email varchar (100) not null,
	UserType varchar (10) not null
)
GO
INSERT INTO Usuario 
values 
(NEWID(), 'admin', '1234', 'Juan', 'Diaz', 'jdiazpalma1@gmail.com', 'Admin'),
(NEWID(), 'user', '1234', 'Docente', 'Aiep', 'docente@AIEP.cl', 'User')
GO

SELECT * FROM Usuario /* REVISION DE DATOS INSERTADOS */


CREATE TABLE Empleado  /* CREACION DE TABLA USUARIOS */
(
	Rut varchar (65) primary Key not null,
	Nombre varchar (65) unique not null,
	Apellido varchar (65) not null,
	Direccion varchar (100) not null,
	Telefono varchar (65) not null,
    Correo varchar (65),
	ValorHora varchar (65) not null,
    ValorExtra varchar (65) not null,
	SueldoLiquido varchar (65),
	SueldoBruto varchar (65)
)

GO
INSERT INTO Empleado (Rut, Nombre, Apellido, Direccion, Telefono, Correo, ValorHora, ValorExtra, SueldoLiquido, SueldoBruto)
VALUES
('12.345.678-9', 'Juan', 'Perez', 'Calle Alegre 123', '+56987654321', 'juan.perez@email.com', '7500', '10200', NULL, NULL),
('16.456.789-0', 'Ana', 'Gomez', 'Avenida Principal 456', '+56976543210', 'ana.gomez@email.com', '6500', '9500', NULL, NULL),
('16.567.890-1', 'Pedro', 'Rodriguez', 'Calle Central 789', '+56965432109', 'pedro.rodriguez@email.com', '8000', '12000', NULL, NULL),
('17.678.901-2', 'Isabel', 'Lopez', 'Calle Principal 234', '+56954321098', 'isabel.lopez@email.com', '7000', '10500', NULL, NULL),
('18.789.012-3', 'Maria', 'Torres', 'Avenida Central 567', '+56943210987', 'maria.torres@email.com', '7200', '11000', NULL, NULL),
('15.890.123-4', 'Luis', 'Martinez', 'Calle Tranquila 890', '+56932109876', 'luis.martinez@email.com', '6800', '10000', NULL, NULL),
('11.901.234-5', 'Carla', 'Sanchez', 'Avenida Tranquila 123', '+56921098765', 'carla.sanchez@email.com', '7600', '11500', NULL, NULL),
('12.012.345-6', 'Pablo', 'Fernandez', 'Calle Soleada 456', '+56910987654', 'pablo.fernandez@email.com', '7100', '10500', NULL, NULL),
('23.123.456-7', 'Elena', 'Diaz', 'Avenida del Sol 789', '+56909876543', 'elena.diaz@email.com', '7300', '10700', NULL, NULL),
('12.234.567-8', 'Sergio', 'Garcia', 'Calle del Mar 123', '+56998765432', 'sergio.garcia@email.com', '7900', '11900', NULL, NULL),
('12.345.678-0', 'Camila', 'Hernandez', 'Avenida Maritima 234', '+56987654321', 'camila.hernandez@email.com', '7200', '11000', NULL, NULL),
('23.456.789-1', 'Miguel', 'Lopez', 'Calle del Rio 567', '+56976543210', 'miguel.lopez@email.com', '6800', '10000', NULL, NULL),
('20.567.890-2', 'Fernanda', 'Ramirez', 'Avenida del Lago 890', '+56965432109', 'fernanda.ramirez@email.com', '7500', '10500', NULL, NULL),
('15.678.901-3', 'Jorge', 'Gonzalez', 'Calle del Bosque 123', '+56954321098', 'jorge.gonzalez@email.com', '7100', '10500', NULL, NULL),
('16.789.012-4', 'Laura', 'Silva', 'Avenida del Parque 456', '+56943210987', 'laura.silva@email.com', '6900', '10300', NULL, NULL),
('17.890.123-5', 'Ricardo', 'Molina', 'Calle del Jardin 789', '+56932109876', 'ricardo.molina@email.com', '7300', '10700', NULL, NULL),
('18.901.234-6', 'Gabriela', 'Vargas', 'Avenida de la Montana 123', '+56921098765', 'gabriela.vargas@email.com', '7700', '12000', NULL, NULL),
('19.012.345-7', 'Hector', 'Ortega', 'Calle de la Playa 456', '+56910987654', 'hector.ortega@email.com', '7300', '10700', NULL, NULL),
('21.123.456-8', 'Silvana', 'Valenzuela', 'Avenida del Bosque 789', '+56909876543', 'silvana.valenzuela@email.com', '7200', '11000', NULL, NULL)
GO
SELECT * FROM Empleado /* REVISION DE DATOS INSERTADOS */
