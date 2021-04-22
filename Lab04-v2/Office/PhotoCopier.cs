using System;
using Lab04_v2.Interfaces;

namespace Lab04_v2.Office
{
    public class PhotoCopier : ICopyJob
    {
        // Copy
        public void Copy(int copies)
        {
            Console.WriteLine("Se ha recibido el papel en la bandeja");
            Console.WriteLine($"Sacando {copies} copias");
        }
    }
}