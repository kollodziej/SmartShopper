using SmartShopperDomain.Enums;

public class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public ProductCategory Category { get; private set; }

    public Product(int id, string name, ProductCategory category)
    {
        Id = id;
        Name = name;
        Category = category;
    }
}
