using SmartShopperDomain.ValueObjects;
using System;

public class ListItem
{
    public Guid Id { get; private set; }
    public ProductName ProductName { get; private set; }
    public Quantity Quantity { get; private set; }
    public Category Category { get; private set; }
    public bool IsChecked { get; private set; }

    public ListItem(ProductName productName, Quantity quantity, Category category)
    {
        Id = Guid.NewGuid();
        ProductName = productName;
        Quantity = quantity;
        Category = category;
        IsChecked = false;
    }

    public void Check()
    {
        IsChecked = true;
    }

    public void Uncheck()
    {
        IsChecked = false;
    }
}