using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

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
            var animals = StaticData.animals;
            return Ok(animals);
        }
        
        [HttpGet("{id:int}")]
        public IActionResult GetAnimal(int id)
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return NotFound($"Animal with id: {id} was not found.");
            }
            return Ok(animal);
        }
        
        [HttpPost]
        public IActionResult AddAnimal(Animal animal)
        {
            StaticData.animals.Add(animal);
            return StatusCode(StatusCodes.Status201Created);
        }
        
        [HttpPut("{id:int}")]
        public IActionResult EditAnimal(int id, Animal animal)
        {
            var animalToEdit = StaticData.animals.FirstOrDefault(a=> a.Id == id);
            if (animalToEdit == null)
            {
                return NotFound($"Animal with id: {id} was not found.");
            }

            StaticData.animals.Remove(animalToEdit);
            StaticData.animals.Add(animal);
            
            return NoContent();
        }
        
        [HttpDelete("{id:int}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animalToDelete = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animalToDelete == null)
            {
                return NoContent();
            }

            StaticData.animals.Remove(animalToDelete);
            return NoContent();
        }
    }
}