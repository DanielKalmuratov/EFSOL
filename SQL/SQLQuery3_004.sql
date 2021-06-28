CREATE DATABASE Army 
ON							  
(
	NAME = 'ArmyDB',				
	FILENAME = 'C:\ArmyDB.mdf',	
	SIZE = 30MB,                    
	MAXSIZE = 100MB,				
	FILEGROWTH = 10MB				
)
LOG ON						 
( 
	NAME = 'ArmyDB',		       
	FILENAME = 'F:\ArmyDB.ldf',      
	SIZE = 5MB,                        
	MAXSIZE = 50MB,                    
	FILEGROWTH = 5MB               
)               
COLLATE Cyrillic_General_CI_AS

USE Army


CREATE TABLE Officer
(
	OfficerID int IDENTITY NOT NULL
	PRIMARY KEY,
	OfficerFullName varchar(30) NOT NULL,
	Rank1 varchar(30) NOT NULL
)

CREATE TABLE Soldiers 
(
	SoldierID int IDENTITY NOT NULL 
    PRIMARY KEY,				  
	SoldierFullName varchar(30) NOT NULL,
	Gun varchar(30) NULL,
	Group1 varchar(10) NULL,
	Squad int NOT NULL,
	OfficerID int NOT NULL
	FOREIGN KEY REFERENCES Officer(OfficerID)
)


INSERT INTO Officer
(OfficerFullName, Rank1)
VALUES 
('Буров О.С.','майор'),
('Рыбаков Н.Г.','майор'),
('Деребанов В.Я.','подполковник')


INSERT INTO Soldiers
(SoldierFullName, Group1, Gun, Squad, OfficerID)
VALUES
('Петров В.А.', 'оф.205', 'АК-47', 222, 1),
('Петров В.А.', 'оф.205', 'Глок20', 222, 2),
('Лодарев П.С.', 'оф.221', 'АК-47', 232, 3),
('Лодарев П.С.', 'оф.221', 'Глок20', 232, 2),
('Леонтьев К.В.', 'оф.201', 'АК-47', 212, 1),
('Петров В.А.', 'оф.205', 'АК-47', 212, 2),
('Духов Р.М.', NULL, 'АК-47', 200, 1)

SELECT * FROM Soldiers