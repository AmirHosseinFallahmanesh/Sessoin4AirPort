using System;
using System.Collections.Generic;

namespace Part5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Age = 12,
                FullName = "amir amiri"
            };
            Student student2 = new Student()
            {
                Age = 14,
                FullName = "reza rezaii"
            };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(new Student()
            {
                Age = 16,
                FullName = "sina sinaii"
            });

            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].FullName);
            }
        }
    }
    class Student
    {
        public string FullName { get; set; }
        public int Age { get; set; }
    }
}
