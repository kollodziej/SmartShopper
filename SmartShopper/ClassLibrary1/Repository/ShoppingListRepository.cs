using Microsoft.EntityFrameworkCore;
using SmartShopperDomain.Entities;
using SmartShopperDomain.Repository;

namespace SmartShopperInfrastructure.Repository
{
    public class ShoppingListRepository(SmartShopperContext context) : IShoppingListRepository
    {
        public async Task<ShoppingList?> GetShoppingListById(int id, CancellationToken cancellationToken)
        {
            return await context.ShoppingLists.FirstOrDefaultAsync(i => i.Id == id, cancellationToken);
        }
    }
}
