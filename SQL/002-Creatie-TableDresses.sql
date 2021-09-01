--
-- Create table dersses
--

USE WonderStyle
GO

CREATE TABLE Dresses
(
	DressId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	ColorId int,
	StyleId int,
	LengthId int,
	SizeId int,
	UnitsInStoc int,
	UnitPrice float(53),
	DressName nvarchar(100)	
)
GO