namespace SmartShopperUI.Models;

public class ShoppingListDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int UserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<ListItemDto> ListItems { get; set; } = [];
}

public class ListItemDto
{
    public int Id { get; set; }
    public ProductDto? Product { get; set; }  // Zmiana: obiekt zamiast string
    public int Quantity { get; set; }
    public bool IsChecked { get; set; }
}

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Category { get; set; }
}