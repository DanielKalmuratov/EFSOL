CREATE DATABASE HomeWork

ON
(
	NAME = 'HomeWork',
	FILENAME = 'C:\HomeWork.mdf',
	SIZE = 10MB, 
	MAXSIZE = 100MB,
	FILEGROWTH = 10MB
)
LOG ON
(
	NAME = 'HomeWork',
	FILENAME = 'C:\HomeWork.ldf',
	SIZE = 5MB, 
	MAXSIZE = 50MB,
	FILEGROWTH = 5MB
)

USE HomeWork

CREATE TABLE Product --не правильно созданнная таблтица
(
	ProductId int IDENTITY NOT NULL,
	Name VARCHAR(20) NOT NULL,
	ProductNumber VARCHAR(20) NOT NULL,
	Cost int NOT NULL,-- для кост указан тип int нужно было money
	Count int NULL,
	SellStartDay date NULL
)

DROP TABLE Product

CREATE TABLE Product --используйте эту таблицу
(
	ProductId int IDENTITY NOT NULL,
	Name VARCHAR(20) NOT NULL,
	ProductNumber VARCHAR(20) NOT NULL,
	Cost money NOT NULL,
	Count int NULL,
	SellStartDay date NULL
)

INSERT INTO Product 
(Name, ProductNumber, Cost, Count, SellStartDay)
VALUES 
('Корона', 'AK-53818', $5, 50, '08/15/2011'),
('Милка', 'AM-51122', $6.1, 50, '07/15/2011'),
('Аленка', 'AA-52211', $2.5, 20, '06/15/2011'),
('Snickers', 'BS-32118', $2.8, 50, '08/15/2011'),
('Snickers', 'BSL-3818', $5, 100, '08/20/2011'),
('Bounty', 'BB-38218', $3, 100, '08/01/2011'),
('Nuts', 'BN-37818', $3, 100, '08/21/2011'),
('Mars', 'BM-3618', $2.5, 50, '08/24/2011'),
('Свиточ', 'AS-54181', $5, 100, '08/12/2011'),
('Свиточ', 'AS-54182', $5, 100, '08/12/2011')

SELECT * From Product

SELECT * from Product 
where Count > 59  --Cделайте выборку для продукции количество которой больше 59 шт.

SELECT * from Product
WHERE Cost > 3 AND (SellStartDay >= '2011-08-20')--Сделайте выборку для продукции цена которой больше 3$ и поступили на продажу c 20/08/2011.