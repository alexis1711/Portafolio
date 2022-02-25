--Creamos la BD
USE master; 
DROP DATABASE IF EXISTS SCE_DB;
CREATE DATABASE SCE_DB;
--Seleccionamos la BD
USE SCE_DB;

--Creamos las Tablas
 --Tabla Área
DROP TABLE IF EXISTS Area;
CREATE TABLE Area
(
	id_area int NOT NULL Identity(1, 1) PRIMARY KEY Clustered,
	area varchar(50) UNIQUE NOT NULL
);

--Tabla Puesto
DROP TABLE IF EXISTS Puesto;
CREATE TABLE Puesto
(
	id_puesto int NOT NULL Identity(1, 1) PRIMARY KEY Clustered,
	puesto varchar(250) UNIQUE NOT NULL
);

--Tabla Administradores
DROP TABLE IF EXISTS Administradores;
CREATE TABLE Administradores
(
	id_admin varchar(50) PRIMARY KEY NOT NULL,
	nombre varchar(250) NOT NULL,
	apellido varchar(250) NOT NULL,
	usuario varchar(50) UNIQUE NOT NULL,
	contrasena varchar(50) NOT NULL,
	id_area int REFERENCES Area(id_area) NOT NULL,
	id_puesto int REFERENCES Puesto(id_puesto) NOT NULL,
	incapacidad bit NOT NULL,
	estado bit NOT NULL,
);

--Tabla Empleados
DROP TABLE IF EXISTS Empleados;
CREATE TABLE Empleados 
(
	id_empleado varchar(50) PRIMARY KEY NOT NULL,
	nombre varchar(250) NOT NULL,
	apellido varchar(250) NOT NULL,
	fecha_nacimiento datetime NOT NULL,
	genero varchar(15) NOT NULL,
	usuario varchar(50) UNIQUE NOT NULL,
	contrasena varchar(50) NOT NULL,
	id_area int REFERENCES Area(id_area) NOT NULL,
	id_puesto int REFERENCES Puesto(id_puesto)NOT NULL,
	incapacidad bit NULL,
	estado bit NOT NULL
);

--Tabla Horario de los empleados
DROP TABLE IF EXISTS Horarios_Empleados;
CREATE TABLE Horarios_Empleados
(
	id_horario int NOT NULL Identity(1, 1) PRIMARY KEY Clustered,
	id_empleado varchar(50) REFERENCES Empleados(id_empleado) NOT NULL,
	dia varchar(20) NOT NULL,
	hora_inicial time NOT NULL,
	hora_final time NOT NULL,
	estado bit NOT NULL,
	especial bit NULL,
	caja int NULL
);

--Tabla Asistencias
DROP TABLE IF EXISTS Asistencia;
CREATE TABLE Asistencia
(
	id_horario int REFERENCES Horarios_Empleados(id_horario) NOT NULL,
	hora time NOT NULL,
	asistencia varchar(30) NOT NULL,
	fecha datetime NOT NULL
);
--Tabla Solicitudes
DROP TABLE IF EXISTS Solicitudes;
CREATE TABLE Solicitudes
(
	id_solicitud int NOT NULL Identity(1, 1) PRIMARY KEY Clustered,
	id_empleado varchar(50) REFERENCES Empleados(id_empleado) NOT NULL,
	motivo varchar(max) NOT NULL,
	fecha_pedido datetime NOT NULL,
	id_admin varchar(50) REFERENCES Administradores(id_admin) NULL,
	accion varchar(10) NULL,
	fecha_accion datetime NULL
);

--Inserts predeterminados
INSERT INTO Area (area) VALUES ('Informatica')
INSERT INTO Area (area) VALUES ('Recursos Humanos')
INSERT INTO Puesto (puesto) VALUES ('Jefe')
INSERT INTO Puesto (puesto) VALUES ('Empleado')
--
INSERT INTO Empleados 
(id_empleado, nombre, apellido, fecha_nacimiento, genero, usuario, contrasena, id_area, id_puesto, incapacidad, estado) VALUES
('Barrera2020', 'Edgard', 'Barrera', 01-10-1999, 'Masculino', 'Usuario', '123',1,2, 0, 1)
INSERT INTO Empleados 
(id_empleado, nombre, apellido, fecha_nacimiento, genero, usuario, contrasena, id_area, id_puesto, incapacidad, estado) VALUES
('Flores2020', 'Miguel', 'Flores', 03-05-1987, 'Masculino', 'Usuario1', '123',2,2, 0, 1)
--
INSERT INTO Administradores 
(id_admin, nombre, apellido, usuario, contrasena, id_area, id_puesto, incapacidad, estado) VALUES
('Bonilla2020', 'Maria', 'Bonilla', 'User', '123', 2,1, 0, 1)

INSERT INTO Administradores 
(id_admin, nombre, apellido, usuario, contrasena, id_area, id_puesto, incapacidad, estado) VALUES
('Gonzales2020', 'Rene', 'Gonzales', 'User1', '123', 1,1, 0, 1)