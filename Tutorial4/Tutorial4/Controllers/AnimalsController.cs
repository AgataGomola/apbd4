using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;

namespace Tutorial4.Controllers
{
    [ApiController]
    [Route("/animals-controller")]
    public class AnimalsController : ControllerBase
    {
        // Metody kontrolera
        [HttpGet]
        public IActionResult GetAnimals()
        {
            var animals = new MockDb().Animals;
            return Ok(animals);
        }
        
        [HttpGet("{id}")]
        public IActionResult GetAnimal(int id)
        {
            return Ok(id);
        }
        
        [HttpPost]
        public IActionResult AddAnimal()
        {
            return Created();
        }
        [HttpPut]
        public IActionResult EditAnimal()
        {
            return Created();
        }
        [HttpDelete]
        public IActionResult DeleteAnimal()
        {
            return Created();
        }
    }
}