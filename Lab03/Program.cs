using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            var std1 = new Student(Name: "Walter", College: "UCA");
            var std2 = new Student(Name: "Nelson", College: "UCA", Age: 20);
            var std3 = new Student(Name: "Lourdes", College: "UCA", CollegePayment: 121, Age: 20);

            Console.WriteLine(std1.GetStudentInfo());
            Console.WriteLine(std3.GetStudentInfo());
        }
    }
}
