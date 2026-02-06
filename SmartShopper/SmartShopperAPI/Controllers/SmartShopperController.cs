using Microsoft.AspNetCore.Mvc;
using SmartShopperDomain.Repository;

namespace SmartShopperAPI.Controllers
{
    [Route("api/SmartShopper/[controller]")]
    [ApiController]
    public class SmartShopperController : ControllerBase
    {
        private readonly IShoppingListRepository _shoppingListRepository;

        public SmartShopperController(IShoppingListRepository shoppingListRepository)
        {
            _shoppingListRepository = shoppingListRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetShoppingListById(int id, CancellationToken cancellationToken)
        {
            var list = await _shoppingListRepository.GetShoppingListById(id, cancellationToken);

            if (list == null)
            {
                return NotFound(new
                {
                    Message = $"Shopping list with ID {id} was not found."
                });
            }

            return Ok(list);
        }
    }
}


//ENDPOIT ktory wyciaga shopping listy
//uzupełnic baze
//testty czy lokalnie działają
//dodać swagger
//Azure zrobić resource bazy danych i api - potem się podłączymy do azure
//projekt UI w tej samej solucji
//