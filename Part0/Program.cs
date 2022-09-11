using System;

namespace Part0
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.name = "amir";
            std1.surname = "amiri";
            std1.age = 15;

            Student std2 = new Student();
            std2.name = "reza";
            std2.surname = "rezaii";
            std2.age = 15;
            Console.WriteLine(std1.GetFullName());
            Console.WriteLine(std2.GetFullName());


        }
    }
    class Student
    {
        public string name;
        public string surname;
        public int age;

        public string GetFullName()
        {
            return name + " " + surname;
        }

    }
}