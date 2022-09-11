using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            
            student.SetName("ali");
            student.SetSurname("amiri");
            student.SetPassword("Aa21354");
            student.SetAge(16);

            Console.WriteLine(student.GetRole());
            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetSurname());
            Console.WriteLine(student.GetAge());
            Console.WriteLine(student.GetName());
        }
    }
    class Student
    {
        private string name;  //g s
        private string surname; //g s
        private int age; //g s
        private string role = "guest"; //g
        private string password; //s

        public void SetPassword(string value)
        {
            password = value;
        }

        //get
        public string GetRole()
        {
            return role;
        }

        //set
        public void SetName(string value)
        {
            name = value;
        }

        public string GetName()
        {
            return name;
        }


        public void SetSurname(string value)
        {
            surname = value;
        }

        public string GetSurname()
        {
            return surname;
        }

        public void SetAge(int value)
        {
            age = value;
        }

        public int GetAge()
        {
            return age;
        }

    }
}
