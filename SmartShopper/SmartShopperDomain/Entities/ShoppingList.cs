using System;
using System.Collections.Generic;

public class ShoppingList
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public int UserId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public IList <ListItem> ListItems { get; private set; }

    public ShoppingList(string name, int userId)
    {
        Name = name;
        UserId = userId;
        CreatedAt = DateTime.UtcNow;
    }
}