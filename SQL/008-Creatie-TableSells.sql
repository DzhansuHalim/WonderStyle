--
-- Create table sells
--

USE WonderStyle
GO

CREATE TABLE Sells
(
	SellId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	DressId int,
	CustomerId nvarchar(100),
	SellDate DateTime	
)
GO