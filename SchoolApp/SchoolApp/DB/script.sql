create database SchoolApp
use SchoolApp

--Tabla Curso
create table Curso(
ID_curso int primary key identity (1,1),
Grado varchar(15),
Seccion varchar(5),
Cant_de_Estudiantes int,
Profesor_encargado varchar(30) 
)

--Tabla Materias
create table Materias(
ID_materias int primary key identity(1,1),
ID_curso int not null,
Profesor varchar(25), 
Materia varchar(15),
Horario varchar(15),
Duracion varchar(15),
constraint fk_cursos foreign key(ID_curso) references Curso(ID_curso)
)

--Tabla Estudiantes
create table Estudiantes(
ID_estudiantes int primary key identity(1,1),
ID_curso int not null,
Nombre varchar(15),
Apellido varchar(15),
Sexo varchar(10),
Edad int,
Codigo varchar(15),
Telefono varchar(15),
Direccion varchar(40),
constraint fk_curso foreign key(ID_curso) references Curso(ID_curso)
)
--Registros

insert into Curso(Grado,Seccion,Cant_de_Estudiantes,Profesor_encargado) values ('8vo','A','25','Juan Perez')
insert into Curso(Grado,Seccion,Cant_de_Estudiantes,Profesor_encargado) values ('8vo','B','30','Maria Torres')

insert into Materias(ID_curso,Profesor,Materia,Horario,Duracion) values (1,'Juan Garcia','Sociales','Matutino','un año')
insert into Materias(ID_curso,Profesor,Materia,Horario,Duracion) values (2,'Kenia Sanchez','Matematicas','Vespertino','un año')

insert into Estudiantes(ID_curso,Nombre,Apellido,Sexo,Edad,Codigo,Telefono,Direccion) values (1,'Saul','Pinales','M',17,'102030','809-000-4545','El Luperon #95')
insert into Estudiantes(ID_curso,Nombre,Apellido,Sexo,Edad,Codigo,Telefono,Direccion) values (2,'Yerelin','Castro','F',16,'102031','809-000-1212','El Capotillo #11')
