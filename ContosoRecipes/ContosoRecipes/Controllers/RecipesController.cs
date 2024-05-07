using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoRecipes.Controllers
{
    [Route("api/recipes")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet("listAll")]
        public ActionResult GetRecipes() {
            string[] recipes = { "Oxtail", "Curry Chicken", "Dumplings"};

            if(recipes.Any())
                return NotFound();
            return Ok(recipes);
        }
      

        [HttpDelete("{id}")]
        public ActionResult DeleteRecipes(string id) {
            bool badThingsHappended = false;

            if (badThingsHappended)
                return BadRequest();
            return NoContent();
        }
    }
}
