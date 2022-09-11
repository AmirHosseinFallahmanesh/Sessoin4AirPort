using System;
using System.Collections.Generic;
using System.Text;
//admni
namespace Part6
{
    class Student
    {
        public Student(int age, string name, string surname)
        {
            Age = age;
            Name = name;
            Surname = surname;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
      
    }
}
