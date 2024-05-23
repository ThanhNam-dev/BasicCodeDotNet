create database BaseCode
go
use BaseCode
go

create table Categories
(
	Id	uniqueidentifier primary key,
	Name	nvarchar(100)
)

create table Product
(
	Id	uniqueidentifier primary key,
	Name	nvarchar(100),
	Category uniqueidentifier foreign key references Categories(Id)
)