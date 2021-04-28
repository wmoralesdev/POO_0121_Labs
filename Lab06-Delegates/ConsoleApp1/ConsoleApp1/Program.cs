using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public delegate void Discounts(List<double> list);
        
        static void Main(string[] args)
        {
            var salary = new List<double> { 750.74, 150, 400.54, 765, 1000 };
            Discounts d;

            d = Afp;
            d += Isss;
            d += Renta;
            d += PrintAfterDiscounts;

            d.Invoke(salary);
        }

        public static void Afp(List<double> list)
        {
            for (var i = 0; i < list.Count; i++)
                list[i] = list[i] - list[i] * 0.0725;
        }

        public static void Isss(List<double> list)
        {
            for (var i = 0; i < list.Count; i++)
                list[i] = list[i] - list[i] * 0.03;
        }

        public static void Renta(List<double> list)
        {
            for (var i = 0; i < list.Count; i++)
                list[i] = list[i] - list[i] * 0.1;
        }

        public static void PrintAfterDiscounts(List<double> list)
        {
            list.ForEach(e => Console.WriteLine($"Salario: ${e}"));
        }
    }
}