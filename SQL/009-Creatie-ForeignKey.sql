--
-- Create references
--

USE WonderStyle
GO


ALTER TABLE Dresses
	ADD CONSTRAINT fk_colorid
		FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)


ALTER TABLE Dresses
	ADD CONSTRAINT fk_styleid
		FOREIGN KEY (StyleId) REFERENCES Styles(StyleId)


ALTER TABLE Dresses 
	ADD CONSTRAINT fk_lengthid
		FOREIGN KEY (LengthId) REFERENCES Lengths(LengthId)

ALTER TABLE Dresses 
	ADD CONSTRAINT fk_sizeid
		FOREIGN KEY (SizeId) REFERENCES Sizes(SizeId)

ALTER TABLE Orders
	ADD CONSTRAINT fk_customerid
		FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)

ALTER TABLE Order_Details
	ADD CONSTRAINT fk_dressid
		FOREIGN KEY (DressId) REFERENCES Dresses(DressId)


ALTER TABLE UserOperationClaims 
	ADD CONSTRAINT fk_userRegisterId
		FOREIGN KEY (UserId) REFERENCES Users(Id)



ALTER TABLE UserOperationClaims 
	ADD CONSTRAINT fk_operationClaimId
		FOREIGN KEY (OperationClaimId) REFERENCES OperationClaims(Id)