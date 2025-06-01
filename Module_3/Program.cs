using System;

class Program
{
    static void Main()
    {       
        // Create an instance of the Bunny class
        Bunny myBunny = new Bunny()
        {
            Name = "Bugs",
            FavoriteFood = BunnyFood.Carrots,
            Age = 3
        };

        // Display bunny information
        Console.WriteLine($"{myBunny.Name} is {myBunny.Age} years old.");
        Console.WriteLine($"{myBunny.Name} loves to eat {myBunny.FavoriteFood}.");
        // Feed the bunny
        myBunny.Eat();
    }
}

// Class definition for Bunny
public class Bunny
{
    public string Name = "";
    public BunnyFood FavoriteFood;
    public int Age;

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating {FavoriteFood}.");
        Console.WriteLine("Bunny is happy!");
    }
}

// Enum for Bunny's favorite food
public enum BunnyFood
{
    Carrots,
    Lettuce,
    Cabbage,
    Kale
}