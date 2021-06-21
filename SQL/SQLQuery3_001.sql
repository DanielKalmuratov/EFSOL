CREATE DATABASE MyDb

ON
(
	NAME = 'MyDb',
	FILENAME = 'C:\MyDb.mdf',
	SIZE = 10MB, 
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'MyDb',
	FILENAME = 'C:\MyDb.ldf',
	SIZE = 5MB, 
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

USE MyDb

CREATE TABLE Employee
(
		EmployeeID SmallInt IDENTITY NOT NULL,
		FirstName Varchar(20) NOT NULL,
		PhoneNumber int NULL
)
CREATE TABLE EmployeeInfo
(
		Position Varchar(20) NOT NULL,
		Salary int NOT NULL
)
CREATE TABLE EmployeeFamily
(
		Family Varchar(20) NOT NULL,
		Addres Varchar(20) NOT NULL,
		BirthDate date NULL
)
