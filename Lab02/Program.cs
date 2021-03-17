using System;
using System.Collections.Generic;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleChanged = new List<string>();

            peopleChanged.Add("Walter");
            peopleChanged.Add("Mariana");
            peopleChanged.Add("Cristian");
            peopleChanged.Add("Fernando");
            peopleChanged.Add("Lourdes");

            Console.WriteLine("For normal");
            for(var i = 0; i < peopleChanged.Count; i++)
                Console.WriteLine($"Elemento en pos {i} es {peopleChanged[i]}");
            
            Console.WriteLine();

            // foreach
            Console.WriteLine("foreach");
            foreach(var pana in peopleChanged)
                if(pana == "Walter")
                    Console.WriteLine("Instructor");
                else
                    Console.WriteLine("Estudiante");

            // Predicado -> Predicative 
            // Funcion de un solo proposito, por lo general devuelve
            // un valor de verdad (no es obligatorio)
            // Lambda -> Arrow Functions

            var numList = new List<int>();

            for(var i = 0; i < 8; i++)
                numList.Add(i);

            // Lambda
            // En este caso, es la funcion que me retorna el valor de verdad
            numList.RemoveAll(num => 
            {
                return num % 2 == 0;
            });

            // En este caso es la funcion que realiza algo con cada elemento
            numList.ForEach(num => 
            {
                Console.WriteLine(num * 2);
            });

            peopleChanged.ForEach(person => 
            {
                Console.WriteLine($"{person} te ha saludado");
            });

            peopleChanged.RemoveAll(person => 
            {
                return person.StartsWith("W");
            });

            peopleChanged.ForEach(person => 
            {
                Console.WriteLine($"{person} te ha saludado");
            });
        }

        static bool CheckIfEven(int n)
        {
            return n % 2 == 0;
        }
    }
}
