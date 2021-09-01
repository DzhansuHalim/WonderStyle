--
-- Create table lengths
--

USE WonderStyle
GO

CREATE TABLE Lengths
(
	LengthId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	LengthName nvarchar(100)	
)
GO