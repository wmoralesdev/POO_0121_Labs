using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramFunctionality();
        }

        static void ProgramFunctionality()
        {
            Console.WriteLine("Introduzca un numero: ");
            var n = InputNumberAndParse();
        }

        static int InputNumberAndParse()
        {
            bool parsed = false;
            int parsedNum = 0;

            while (!parsed)
            {
                try
                {
                    var str = Console.ReadLine();
                    parsedNum = ParseInteger(str);

                    parsed = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Intente introducir un numero...");
                }
            }

            return parsedNum;
        }

        static int ParseInteger(string toParse)
        {
            return Int32.Parse(toParse);
        }

        static void CheckIfNegative(int n)
        {
            if (n < 0)
                throw new NegativeNumberException("No se admiten numeros negativos");
        }
    }
}