using System;

namespace Lab04.Animals
{
    public class Fish : IBehavior
    {
        public string Colors { get; set; }

        public void Eat(string food)
        {
            Console.WriteLine($"El pez engulle {food}");
        }

        public void Move()
        {
            Console.WriteLine("El pez nada");
        }

        public void Sleep()
        {
            Console.WriteLine("El pez duerme flotando");
        }
    }
}