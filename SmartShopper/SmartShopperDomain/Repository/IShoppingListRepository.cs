using SmartShopperDomain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace SmartShopperDomain.Repository
{
    public interface IShoppingListRepository
    {
        Task<ShoppingList> GetShoppingListById(int id, CancellationToken cancellationToken);
    }
}
