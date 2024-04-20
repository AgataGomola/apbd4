using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/visits-controller")]
public class VisitsController : ControllerBase
{
    [HttpGet("animal/{id:int}")]
    public IActionResult GetAnimalVisit(int id)
    {
        var animalsVisit = StaticData.visits.Where(a => a.Animal.Id == id);
        return Ok(animalsVisit);
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        StaticData.visits.Add(visit);
        return StatusCode(StatusCodes.Status201Created);
    }
}