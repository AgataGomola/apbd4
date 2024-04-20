using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal{Id = 1, Name = "Goofy", Category = "dog", Weight = 5, Color = "black"},
        new Animal { Id = 2, Name = "Fluffy", Category = "cat", Weight = 3, Color = "white" },
        new Animal { Id = 3, Name = "Buddy", Category = "dog", Weight = 7, Color = "brown" }
    };

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit { DateOfVist = DateTime.Now, Animal = animals[0], Description = "Routine", Price = 50.0 },
        new Visit { DateOfVist = DateTime.Now.AddDays(-14), Animal = animals[0], Description = "Vaccination", Price = 30.0 },
        new Visit { DateOfVist = DateTime.Now.AddDays(-21), Animal = animals[2], Description = "Injury", Price = 80.0 }
    };
}