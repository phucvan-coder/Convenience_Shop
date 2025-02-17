﻿CREATE DATABASE ConvenienceShop
GO
USE ConvenienceShop
GO
CREATE TABLE TypeOfProduct(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TypeName NVARCHAR(50) NULL
)

/*--Insert
go
insert into TypeOfProduct values('A1'),('A2'), ('A3')
go
--end*/

GO
CREATE TABLE Producer(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	ProducerName NVARCHAR(50) NULL,
	Address NVARCHAR(50) NULL,
	Phone NVARCHAR(11) NULL
)
GO
/*
insert into Producer values ('P1','add1','phone1'),('P2','add2','phone2')
*/

CREATE TABLE Product(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TypeID INT NOT NULL,
	ProductName NVARCHAR(50) NULL,
	ProducerID INT NOT NULL,
	Price FLOAT NULL,
	Amount int NULL,
	Date DATETIME null,
	Status NVARCHAR(50) NULL,
	CONSTRAINT FK_TypeID FOREIGN KEY(TypeID) REFERENCES TypeOfProduct(Id),
	CONSTRAINT FK_ProducerID FOREIGN KEY(ProducerID) REFERENCES Producer(Id)
)
GO
/*
insert into Product values (1,'pro1',1,12.0,10, '2000-12-18','Status1'),(1,'pro2',2,22.0,0,'2019-12-12','Status2')
*/

CREATE TABLE Staff(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name NVARCHAR(50) NULL,
	DateOfBirth DATETIME NULL,
	Gender NVARCHAR(10) NULL,
	Email NVARCHAR(50) NULL,
	Address NVARCHAR(50) NULL,
	Phone NVARCHAR(11) NULL
)
GO
CREATE TABLE Account(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	AccountName NVARCHAR(30) NULL,
	Password NVARCHAR(30) NULL,
	Rank NVARCHAR(30) NULL
)
GO
/*
insert into Account values ('acc1','pass1', N'Quản Lý'),('acc2','pass2', N'Quản Lý')
delete from Account where AccountName = 'acc1' or AccountName = 'acc2' 
*/

CREATE TABLE Bill(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	DateOfSale DATETIME NULL
)	
GO
CREATE TABLE BillInfo(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	BillID INT NOT NULL,
	TypeID INT NOT NULL,
	ProductID INT NOT NULL,
	Amount INT NULL,
	Discount INT NULL,
	TotalPrice FLOAT NULL,
	CONSTRAINT FK_BillID FOREIGN KEY(BillID) REFERENCES Bill(Id),
	CONSTRAINT FK_Type_ID FOREIGN KEY(TypeID) REFERENCES TypeOfProduct(Id),
	CONSTRAINT FK_ProductID FOREIGN KEY(ProductID) REFERENCES Product(Id)
)
GO
/*
use master
drop database ConvenienceShop
*/