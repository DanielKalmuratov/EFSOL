--Create database
CREATE DATABASE WareHouse 
ON							  
(
	NAME = 'WareHouseDB',				
	FILENAME = 'C:\WareHouseDB.mdf',	
	SIZE = 30MB,                    
	MAXSIZE = 100MB,				
	FILEGROWTH = 10MB				
)
LOG ON						 
( 
	NAME = 'WareHouseDB',		       
	FILENAME = 'F:\WareHouseDB.ldf',      
	SIZE = 5MB,                        
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB               
)               
COLLATE Cyrillic_General_CI_AS

USE WareHouse
--Create Tables
CREATE TABLE Supplier
(                                      
	SupplierID int IDENTITY NOT NULL 
    PRIMARY KEY,				  
	SupplierName varchar(30) NOT NULL
)


CREATE TABLE Employees
(                                      
	EmployeesID int IDENTITY NOT NULL 
    PRIMARY KEY,				  
	FullName varchar(25) NOT NULL,
	BirthDate date NOT NULL,
	Address1 varchar(25) NOT NULL,
	PhoneNumber char(12) NOT NULL,
	SupplierID int NOT NULL						                        
    FOREIGN KEY REFERENCES Supplier(SupplierID)
)

CREATE TABLE Customers
(                                      
	CustomersID int IDENTITY NOT NULL 
    PRIMARY KEY,				  
	FullName varchar(25) NOT NULL,
	Address1 varchar(25) NOT NULL,
	PhoneNumber char(12) NOT NULL,
	SupplierID int NOT NULL						                        
    FOREIGN KEY REFERENCES Supplier(SupplierID)
)
--Add Supliers || Employees || Customers
INSERT INTO Supplier																			   
VALUES
('Склад телефонов'),
('Склад ноутбуков');


INSERT INTO Employees																			   
(FullName, BirthDate, Address1, PhoneNumber, SupplierID)
VALUES
('Kalmuratov Daniel', '1994-05-12', 'Pishpek 1', 996702343121, 2),
('Adiletov Adilet', '1989-02-14', 'MKR 4', 996702123456, 1),
('Asanov Marat', '1991-08-09', 'Dzhal 1', 996702435465, 1),
('Muratov Kanat', '1984-11-15', 'Asanbai 1', 996702344556, 2)

INSERT INTO Customers																			   
(FullName, Address1, PhoneNumber, SupplierID)
VALUES
('Kalmuratov Daniel', 'Pishpek 1', 996702343121, 2),
('Adiletov Adilet', 'MKR 4', 996702123456, 1),
('Asanov Marat', 'Dzhal 1', 996702435465, 1),
('Muratov Kanat', 'Asanbai 1', 996702344556, 2)


--Get data from tables
SELECT * FROM Supplier
SELECT * FROM Customers
SELECT * FROM Employees
SELECT * FROM Employees WHERE SupplierID = 1
SELECT * FROM Employees WHERE SupplierID = 2
SELECT * FROM Customers WHERE SupplierID = 1
SELECT * FROM Customers WHERE SupplierID = 2
