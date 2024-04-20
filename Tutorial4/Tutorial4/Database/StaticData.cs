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
    

}