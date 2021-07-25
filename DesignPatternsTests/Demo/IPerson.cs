using System;

namespace DesignPatterns.Tests.Demo
{
    public interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        void Introduction();
        string GetName();
    }

    public class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name)
        {
            Name = name;
        }
        
        public void Introduction()
        {
            Console.WriteLine("I am teacher:" + Name);
        }

        public string GetName()
        {
            return Name;
        }
    }
}