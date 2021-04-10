using System;
using Lab04_v2.Interfaces;

namespace Lab04_v2.Office
{
    public class MultiPrinter : IPrintJob, IScannJob, ICopyJob
    {
        // Copiar, Print, Scanner
        public void Copy(int copies)
        {
            Console.WriteLine("Se ha recibido el papel en la bandeja posterior");
            Console.WriteLine($"Sacando {copies} copias");
        }

        public void Print(int pages)
        {
            Console.WriteLine("Se ha recibido el papel en la bandeja");
            Console.WriteLine($"Imprimiendo {pages} paginas");
        }

        public void Scann()
        {
            Console.WriteLine("Calentando scanner");
            Console.WriteLine("Scanneo preliminar");
            Console.WriteLine("Digitalizando imagen");
            SaveFile();
        }

        public void SaveFile()
        {
            Console.WriteLine("Cargando.....");
            Console.WriteLine("Se ha guardado el archivo");
        }
    }
}