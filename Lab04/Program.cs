using System;
using Lab04.Animals;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            var fish = new Fish()
            {
                Colors = "Anaranjado"
            };

            fish.Eat("alga");
            fish.Move();
            fish.Sleep();
            Console.WriteLine();

            var cat = new Cat()
            {
                FurColor = "Negro con blanco",
                Age = 2
            };

            cat.Eat("Cat Chow");
            cat.Move();
            cat.Sleep();
        }
    }
}
