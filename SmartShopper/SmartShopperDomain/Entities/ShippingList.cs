using System;

public class ShoppingList
{
    public Guid Id { get; private set; }
    public ListName Name { get; private set; }
    public Guid UserId { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public ShoppingList(ListName name, Guid userId)
    {
        Id = Guid.NewGuid();
        Name = name;
        UserId = userId;
        CreatedAt = DateTime.UtcNow;
    }
}