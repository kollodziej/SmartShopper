using SmartShopperDomain.ValueObjects;
using System;

public class ListItem
{
    public int ProductId { get; private set; }
    public Product Product { get; private set; }
    public Quantity Quantity { get; private set; }
    public bool IsChecked { get; private set; }

    public ListItem(int productId, Quantity quantity)
    {
        ProductId = productId;
        Quantity = quantity;
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