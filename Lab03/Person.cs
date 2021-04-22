using System;

namespace Lab03
{
    public class Person
    {
        public string Name { get; set; }

        public string IdDoc { get; set; }

        public int Age { get; set; }

        public Person(string Name, string IdDoc, int Age)
        {
            this.Name = Name;
            this.IdDoc = IdDoc;
            this.Age = Age;
        }

        protected string GetBaseInfo()
        {
            return $"Name: {Name}\n" +
                $"IdDoc: {IdDoc}\n" +
                $"Age: {Age}\n";
        }
    }
}