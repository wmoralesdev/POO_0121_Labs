using System;
using Lab04_v2.Interfaces;

namespace Lab04_v2.Office
{
    public class Scanner : IScannJob
    {
        // Scann
        public void Scann()
        {
            Console.WriteLine("Digitalizando imagen...");
            SaveFile();
        }

        public void SaveFile()
        {
            Console.WriteLine("Se ha guardado el archivo en formato PDF, JPG, y PNG");
        }
    }
}