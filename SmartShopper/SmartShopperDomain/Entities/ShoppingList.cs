using System;

public class ShoppingList
{
    public int Id { get; private set; }
    public ListName Name { get; private set; }
    public int UserId { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public ShoppingList(ListName name, int userId)
    {
        Name = name;
        UserId = userId;
        CreatedAt = DateTime.UtcNow;
    }
}