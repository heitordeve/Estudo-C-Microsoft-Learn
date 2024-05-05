using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public string[] GetDishes() {
            string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings"};
            return dishes;
        }
    }
}
