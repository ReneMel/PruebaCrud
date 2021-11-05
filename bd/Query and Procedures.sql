create database pruebaCRUD
use pruebaCRUD


create  table client (
	client_id int primary key identity not null,
	client_name varchar(50) not null,
	client_lastname varchar(50) not null,
	dui varchar(10) not null, 
	birthday date not null
);


--Procedimientos almacenados

--create
create or alter procedure client_create
@clientName varchar(50),
@clientLastname varchar(50),
@dui varchar(10),
@date date
as
insert into client(client_name, client_lastname, dui, birthday)
values(@clientName,@clientLastname, @dui,@date);
go;


-- delete
create or alter procedure client_delete 
@id int
as
delete from client  where client_id=@id;
go;

--update
create or alter procedure client_update
@clientName varchar(50),
@clientLastname varchar(50),
@dui varchar(10),
@date date,
@id int
as
update client 
set
client_name= @clientName, client_lastname=@clientLastname, dui=@dui, birthday=@date
where client_id=@id
go;

--read
create or alter procedure client_list
as
select c.client_lastname as 'Apellidos', c.client_name as 'Nombre', c.dui as 'DUI', c.birthday as 'Fecha Cumpleaños' from client c
go;


--insert
insert  into client (client_name, client_lastname, dui, birthday)
values('rene', 'melendez', '00000000-1', '2021-10-11')