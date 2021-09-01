--
-- Create table style
--

USE WonderStyle
GO

CREATE TABLE Styles
(
	StyleId int NOT NULL PRIMARY KEY IDENTITY(1,1),
	StyleName nvarchar(100)	
)
GO