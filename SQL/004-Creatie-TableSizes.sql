--
-- Create table sizes
--

USE WonderStyle
GO

CREATE TABLE Sizes
(
	SizeId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	SizeName nvarchar(100)	
)
GO