using SmartShopperDomain.Entities;

namespace SmartShopperDomain.ValueObjects
{
    public class ListItem
    {
        public int Id { get; private set; }
        public int ShoppingListId { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public bool IsChecked { get; private set; }

        public ListItem(int quantity)
        {
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
}