using System;

namespace Lab04.Animals
{
    public class Snake : IBehavior
    {
        public bool SkinShedding { get; set; }

        public bool IsPoisonous { get; set; }

        public void Eat(string food)
        {
            Console.WriteLine($"La serpiente engulle {food}");
        }

        public void Move()
        {
            Console.WriteLine("La serpiente repta");
        }

        public void Sleep()
        {
            Console.WriteLine("La serpiente duerme enrollada en ramas");
        }
    }
}