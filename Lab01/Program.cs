// Importaciones de librerias
using System;

// Agrupacion de archivos que comparten un contexto
namespace Lab01
{
    // Clase 
    class Program
    {
        // Metodo (Funcion que esta dentro de una clase)
        static void Main(string[] args)
        {
            // Variables
            // Output
            // Input
            // Metodos
            // Mayoria del codigo este en ingles (- Comentarios)
        }

        // TOdos los metodos inician con mayuscula
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static string ConvertToUpperCase(string word)
        {
            return word.ToUpper();
        }

        static bool IsVowel(char a)
        {
            switch(a)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }
    }
}
