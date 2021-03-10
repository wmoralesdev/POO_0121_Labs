using System;
using System.Collections.Generic;

/*
    Generalities
    - A majority of code must be in english (typos are allowed grammatically and spelling)
    - Code MUST be clean, and readable
    - Var names must be descriptive and shouldn't be like: a, b, c unless it's an example or iterator (for counter)
*/

namespace _0_BestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# specific
            // Explicit variables should be used unless you are 
            // 1. Explaning var types
            // 2. Using Interface variables

            // Also, WHENEVER IT'S POSSIBLE initialize vars in declaration, NOT ANYWHERE ELSE
            var i = 20;
            Console.WriteLine(i);

            // Declaration of unused vars should be completely avoided
            var str = string.Empty;

            // When a variable is declared it should use camelCase writing
            var someRamdonString = "Walter";

            // When using List, prefer List instead of IList if possible, and also
            // for traversing it use ForEach integrated method
            List<int> someNumbers = new List<int>
            {
                1,
                2,
                3
            };

            someNumbers.ForEach(num => Console.WriteLine(num));

            // Every time that a operator is written, a black space should be after and before it, unless you need
            // to close parenthesis, brackets or braces
            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // When calling a method that returns boolean, if it's single usage
            // don't store it, if it has multiple usages that persist, then store it
            if(NumberExists(someNumbers, 1))
                Console.WriteLine("It does exist inside list");

            // When declaring functions that return boolean, like checking if 
            // value exists, value is odd, even, etc
            // don't place if inside, just return boolean expression (see BetterNumberExists)
            if(BetterNumberExists(someNumbers, 1))
                Console.WriteLine("It does exist inside list");

            // When a class is instantiated and has/needs values for props, use braces initialization
            var objectClassA = new ClassA('a', false)
            {
                PropertyA = "Setting",
                PropertyB = 2
            };

            // When string is used and value is user input, calculated or not initialized in declaration
            // use nullability
            string? waitForUser = null;

            // When null checking, use patter matching (C# 9.0 improved)
            if(waitForUser is not null)
            {
                waitForUser = Console.ReadLine();
            }

            // Use safe calls for nullable variables
            Console.WriteLine(waitForUser?.Equals("UCA"));

            // If a string needs to be composed of some vars, use string.Format or interpolared
            // $ instead of concatenation and parsing/converting
            Console.WriteLine(string.Format("Object of ClassA, has PropertyA with value {0}", objectClassA.PropertyA));
            Console.WriteLine($"Object of ClassA, has PropertyA with value {objectClassA.PropertyA}");

            // When asking data for user input, always print guide message (unless exercise says not to)
            Console.WriteLine("Enter fullname");
            var fullName = Console.ReadLine();

            // Always mantain max and min 1 empty line separating block sentences, as following
            // Avoid openning braces 
            if(new Random().Next() % 2 == 0)
                Console.WriteLine("Generated number is even");
            // ----------------------------------------- separation line (comment shouldn't be here, it's just for explannation)
            for(int j = 0; j < 4; j++)
                if(new Random().Next() % 2 == 0)
                    Console.WriteLine("Generated number is even");
            
            // Avoid blank lines when code sentences share same context, like I/O, decissions, etc
            string? name = null, lastName = null;
            int? age = null;

            Console.Write("Name: ");
            name = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Age: ");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Person: {name}, {lastName}, {age}");
        }

        // OOPL specific
        // Every method needs to start wih UpperCase letter
        
        // C# specific
        // Braces should start in new line everywhere, unless you're writing a lamdba
        public static void TestMethod()
        {
            // Every incomplete part of code MUST have a TODO line comment explaining pending work
            // TODO: Complete method
        }

        public static bool NumberExists(List<int> list, int num)
        {
            // When a method has non-void return type, even if there's no
            // expected value to return, return stock/default/placeholder value
            if(list.Contains(num))
                return true;
            else
                return false;
        }

        public static bool BetterNumberExists(List<int> list, int num)
        {
            return list.Contains(num);
        }
    }
}
