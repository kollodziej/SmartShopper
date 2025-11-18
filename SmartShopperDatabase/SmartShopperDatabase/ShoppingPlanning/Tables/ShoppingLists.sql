CREATE TABLE [ShoppingPlanning].[ShoppingLists]
(
	[Id] INT Identity(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [UserId] INT NOT NULL, 
    [CreatedAt] TIMESTAMP NOT NULL 
)
