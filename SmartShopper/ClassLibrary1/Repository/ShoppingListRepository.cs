using Microsoft.EntityFrameworkCore;
using SmartShopperDomain.Entities;
using SmartShopperDomain.Repository;

namespace SmartShopperInfrastructure.Repository
{
    public class ShoppingListRepository(SmartShopperContext context) : IShoppingListRepository
    {
        public async Task<ShoppingList?> GetShoppingListById(int id, CancellationToken cancellationToken)
        {
            return await context.ShoppingLists
                .Include(s => s.ListItems)
                    .ThenInclude(li => li.Product)
                .FirstOrDefaultAsync(i => i.Id == id, cancellationToken);
        }

        public async Task<IEnumerable<ShoppingList>> GetAllShoppingLists(CancellationToken cancellationToken)
        {
            return await context.ShoppingLists.ToListAsync(cancellationToken);
        }
    }
}
