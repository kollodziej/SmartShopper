CREATE TABLE [ShoppingPlanning].[ListItems]
(
	[Id] INT Identity(1,1) NOT NULL PRIMARY KEY, 
    [Quantity] INT NOT NULL, 
    [IsChecked] BIT NOT NULL, 
    [FK_ProductId] INT NOT NULL, 
    [FK_ShoppingListId] INT NOT NULL, 
    CONSTRAINT [FK_ListItems_ToShoppingLists] FOREIGN KEY ([FK_ShoppingListId]) REFERENCES [ShoppingPlanning].[ShoppingLists]([Id]),
    CONSTRAINT [FK_ListItems_ToProducts] FOREIGN KEY ([FK_ProductId]) REFERENCES [ShoppingPlanning].[Products]([Id])
)
