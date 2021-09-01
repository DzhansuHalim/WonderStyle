--
-- Create table customers
--

USE WonderStyle
GO

CREATE TABLE Customers
(
	CustomerId nvarchar(100) PRIMARY KEY NOT NULL,
	ContactName nvarchar(100),
	CompanyName nvarchar(100),
	City nvarchar(100)
)
GO