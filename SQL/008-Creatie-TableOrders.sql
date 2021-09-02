USE WonderStyle
GO

CREATE TABLE [dbo].[Orders] (
    [OrderID]        INT           IDENTITY (1, 1) NOT NULL,
    [CustomerID]     NVARCHAR (100)     NULL,
    [OrderDate]      DATETIME      NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED ([OrderID] ASC),
    CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID]),
);


GO
CREATE NONCLUSTERED INDEX [CustomerID]
    ON [dbo].[Orders]([CustomerID] ASC);


GO
CREATE NONCLUSTERED INDEX [CustomersOrders]
    ON [dbo].[Orders]([CustomerID] ASC);


GO
CREATE NONCLUSTERED INDEX [OrderDate]
    ON [dbo].[Orders]([OrderDate] ASC);
