using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints
{
    public static class AnimalEndpoints
    {
        public static void MapAnimalEndpoints(this WebApplication app)
        {
            app.MapGet("/animals", () =>
            {
                var animals = StaticData.animals;
                return Results.Ok(animals);
            });

            app.MapGet("/animals/{id}", (int id) =>
            {
                return Results.Ok(id);
            });

            app.MapPost("/animals", (Animal animal) =>
            {
                return Results.Created("", animal);
            });
        }
    }
}