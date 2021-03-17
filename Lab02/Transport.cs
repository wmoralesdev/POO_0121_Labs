using System;

namespace Lab02
{
    public class Transport
    {
        private string name;
        private double? cost;

        public Transport(string name, double? cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public void UseTransport()
        {
            Console.WriteLine($"Usando {name}");

            if(cost is null)
                Console.WriteLine("Es gratis");
            else
                Console.WriteLine($"Costo: {cost}");
        }
    }
}