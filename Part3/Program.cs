using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "amir";
            student.SurName = "amiri";
            student.Age = 20;
            student.Password = "1246";
            //student.Role = "test"; error
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Role);
            //Console.WriteLine(student.Password); error


            StudentNew studentNew = new StudentNew();
            studentNew.Name = "amir";
            studentNew.Surname = "amiri";
            studentNew.Age = 20;
            studentNew.Password = "1246";
            //student.Role = "test"; error
            Console.WriteLine(student.Name);
            Console.WriteLine(student.SurName);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Role);
         
        }
    }

    class StudentNew
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Role { get; private set; }
        public string Password {private get; set; }
    }

    class Student
    {
        private string name;  //g s
        private string surname; //g s
        private int age; //g s
        private string role = "guest"; //g
        private string password; //s
        public string Password
        {
            set { password = value+"***"; }

        }

        public string Role
        {
            get { return name; }
           
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string SurName   
        {
            get { return surname; }
            set { surname = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
