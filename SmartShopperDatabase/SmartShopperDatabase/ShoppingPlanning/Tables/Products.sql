CREATE TABLE [ShoppingPlanning].[Products]
(
	[Id] INT Identity(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL UNIQUE,
    [Category] NVARCHAR(50) NOT NULL 
)
