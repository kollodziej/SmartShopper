using SmartShopperDomain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SmartShopperDomain.Repository
{
    public interface IShoppingListRepository
    {
        Task<ShoppingList> GetShoppingListById(int id, CancellationToken cancellationToken);
        Task<IEnumerable<ShoppingList>> GetAllShoppingLists(CancellationToken cancellationToken);
    }
}
