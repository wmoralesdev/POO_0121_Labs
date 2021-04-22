using System;

namespace Lab04.Animals
{
    public class Cat : IBehavior
    {
        public string FurColor { get; set; }

        public int Age { get; set; }

        public void Eat(string food)
        {
            Console.WriteLine($"El gato come {food} masticandola");
        }

        public void Move()
        {
            Console.WriteLine("El gato camina a 4 patas");
        }

        public void Sleep()
        {
            Console.WriteLine("El gato duerme donde sea, acostado");
        }
    }
}