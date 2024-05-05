using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes() {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings"};

            if(recipes.Any())
                return NotFound();
            return Ok(recipes);
        }
      

        [HttpDelete]
        public ActionResult DeleteRecipes() {
            bool badThingsHappended = false;

            if (badThingsHappended)
                return BadRequest();
            return NoContent();
        }
    }
}
