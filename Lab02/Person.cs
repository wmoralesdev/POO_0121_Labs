// Clase Person
// Molde que contiene caracteristicas y acciones de un objeto o elemento
// abstraido de la realidad
using System;

namespace Lab02
{
    class Person
    {
        // TODO: Atributos
        // Caracteristicas que definen la instancia de una clase
        private string firstName, lastName, profession, nationality;
        private int age;
        private char gender;

        // TODO: Metodos
        // Constructor
        public Person(string firstName, string lastName,
            string profession, string nationality, int age, char gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.profession = profession;
            this.nationality = nationality;
            this.age = age;
            this.gender = gender;
        }

        public void Greet()
        {
            Console.WriteLine($"{firstName} te esta saludando!");
        }

        public void Walk(string location1, string location2)
        {
            Console.WriteLine(
                $"{firstName} camina desde {location1} hasta {location2}");
        }

        public void Talk(string message)
        {
            Console.WriteLine($"{firstName} dice: \"{message}\"");
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine($"Nombre completo: {firstName} {lastName}");
            Console.WriteLine($"Edad: {age}");
            Console.WriteLine($"Nacionalidad: {nationality}");
            Console.WriteLine($"Profesion: {profession}");
            Console.WriteLine($"Genero: {gender}");
        }
    }
}