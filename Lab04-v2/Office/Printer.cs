using System;
using Lab04_v2.Interfaces;

// SOLID -> Principios de la programacion orientada a objetos
// I -> Interface Seggregation
// Preferir interfaces atomicas, con responsabilidades bien definidas (interfaces pequeñas)

namespace Lab04_v2.Office
{
    public class Printer : IPrintJob, IScannJob
    {
        // Print, Scann
        public void Print(int pages)
        {
            Console.WriteLine($"Se ha recibido el papel en la bandeja, imprimiendo {pages} paginas");
        }

        public void Scann()
        {
            Console.WriteLine("Se ha hecho el scanneo principal, digitalizando");
            SaveFile();
        }

        public void SaveFile()
        {
            Console.WriteLine("Se ha guardado el archivo luego de su scaneo");
        }
    }
}