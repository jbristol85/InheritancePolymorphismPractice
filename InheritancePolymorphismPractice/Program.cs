using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphismPractice
{

    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name="Whiskers",
                Sound = "Meow"
            };

            Dog mongo = new Dog()
            {
                Name = "Mongo",
                Sound = "Woof",
                Sound2 = "Bark"
            };

            mongo.Sound = "Wooooof";

            whiskers.MakeSound();
            mongo.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Jon Smith");
            mongo.SetAnimalIDInfo(12346, "Josh Jackson");

            whiskers.GetAnimalIDInfo();
            mongo.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy : {0}", getHealth.HealthyWeight(11, 146));

            Animal monkey = new Animal()
            {
                Name= "Happy",
                Sound = "Eeeek"
            };
            
            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "WOOF",
                Sound2 = "Growl"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
    }
}
