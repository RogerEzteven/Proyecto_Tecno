create database IU_TecVII_GA1 

use IU_TecVII_GA1 

create table Login(

	Nombre Varchar (50) PRIMARY KEY  NOT NULL,
	Contrasena varchar (50) NOT NULL,
	Roll Varchar (50) not null

);



INSERT INTO Login VALUES('Roger','12345','Administrador')
INSERT INTO Login VALUES('Lourdes','12345','Secretaria')
INSERT INTO Login VALUES('Manuel','12345','Usuario')

select *from login 


CREATE TABLE usuarios(

	ID INT PRIMARY KEY NOT NULL,
	Nombre varchar (50)NOT NULL,
	Correo varchar (50) not null,
	Pais varchar (50) not null,
	Numero int  

);

INSERT INTO Usuarios values (1,'Marcos','Marcos@gmail.com','Guatemala',89567432);





