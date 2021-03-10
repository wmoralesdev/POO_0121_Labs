// Utilizacion de librerias
using System;

// Agrupacion de archivos
namespace Lab01
{
    // Clase
    class Program
    {
        // Metodo

        /*
            Rapido
            Eficiente
            Ordenado

            TODAS LAS ACTIVIDADES SON DE MIERCOLES A MARTES A LAS 23:59
            Hoy, Martes 16, 23:59

            Realizar todas
            Optativas (seleccionar 1)
            Introduccion a GitHub (Obligatoria por clanes)
            Contadores y Acumuladores
            
            Actividades de labo (todos)
            Lab01
        */

        static void Main(string[] args)
        {
            int opcion = 0, opcion1 = 0, opcion2 = 0;
            // Best practices (Carpeta -> Leen)
            // 1. Mayoria del codigo tiene que estar en ingles (exceptuando
            // comentarios, e impresiones)
            // 2. Comentar el codigo (Documentar)
            // 3. Apertura de llaves
            // 4. Inicializar las variables
            
            // Variables explicitas, son a las que se les declara el tipo
            int num = 20;
            char letter = 'a';
            string str = "Salu2 banda";
            float f = 12.34f;
            double d = 12.34d;

            // Variables implicitas (Preferida)
            // Objetos con herencia, Variables de interfaz
            var aInteger = 1;
            var aLetter = 'e';
            var aString = "Implicit var";
            var aFloat = 3.14f;
            var aDouble = 3.14;

            var emptyString = "";
            var anotherEmptyString = string.Empty;

            var notInitialized = 10;

            /*
                META 1 (VSCode)

                META 2 (Rider)
                    Roslyn Fixes -> Codificar por ustedes
                META 3 (Anything)
                    
            */

            // Random num generator
            var randNumber = new Random().Next(1, 10);
            
            if(randNumber % 2 == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es impar");

            for(int i = 0; i < 10; i++)
                Console.WriteLine(i);

            // Cadena interpolada (Combinar string con variables)
            for(var j = 0; j < 20; j++)
                Console.WriteLine($"El numero es {j}");
                // Console.WriteLine("El numero es " + j);

            var word = "Walter";

            word = word.ToLower();

            for(int i = 0; i < word.Length; i++)
            {
                switch(word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"El caracter {word[i]} es vocal");
                        break;
                    default:
                        Console.WriteLine($"El caracter {word[i]} no es vocal");
                        break;
                }
            }

            // Parseo, Parsing -> convertir un string a un tipo X
            int edad = 0;

            Console.WriteLine("Cual es su edad?");
            edad = Int32.Parse(Console.ReadLine());

            char a = Char.Parse(Console.ReadLine());
            char e = Console.ReadLine()[0];

            double dd = Double.Parse(Console.ReadLine());

            Console.WriteLine(AddNumbers(2, 3));
        }
    
        static int AddNumbers(int a, int b)
        {
            return a + b;
        } 

        static double SubstractNumbers(int a, int b)
        {
            return a - b;
        }

        static string ConvertToUpperCase(string word)
        {
            return word.ToUpper();
        }
    }
}
