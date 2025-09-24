using System;

public class SuggestedListItem
{
    public Guid Id { get; private set; }
    public string ProductName { get; private set; }
    public string CategoryName { get; private set; }

    public SuggestedListItem(string productName, string categoryName)
    {
        Id = Guid.NewGuid();
        ProductName = productName;
        CategoryName = categoryName;
    }
}