using System;

namespace Lab03
{
    public class Student : Person
    {
        public string College { get; set; }

        public double CollegePayment { get; set; }

        public int EnrolledSubjects { get; set; }

        public Student(string Name = "", string IdDoc = "None", int Age = 0,
        string College = "None", double CollegePayment = -1, int EnrolledSubjects = -1) 
        : base(Name, IdDoc, Age)
        {
            this.College = College;
            this.CollegePayment = CollegePayment;
            this.EnrolledSubjects = EnrolledSubjects;
        }

        public string GetStudentInfo()
        {
            return base.GetBaseInfo() + $"College: {College}\n"
                + $"Payment: {CollegePayment}\n"
                + $"Subjects: {EnrolledSubjects}\n";
        }
    }
}