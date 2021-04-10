using System;
using Lab04_v2.Office;

namespace Lab04_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- PRINTER ---------");
            var printer = new Printer();
            printer.Print(4);
            printer.Scann();
            Console.WriteLine();
            
            Console.WriteLine("--------- SCANNER ---------");
            var scanner = new Scanner();
            scanner.Scann();
            Console.WriteLine();

            Console.WriteLine("--------- MULTI ---------");
            var multi = new MultiPrinter();
            multi.Print(10);
            multi.Copy(200);
            multi.Scann();
            Console.WriteLine();

            Console.WriteLine("--------- PHOTOCOPIER ---------");
            var copier = new PhotoCopier();
            copier.Copy(1000);
            Console.WriteLine();
        }
    }
}
