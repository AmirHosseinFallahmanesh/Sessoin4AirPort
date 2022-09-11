using System;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            MC mc1 = new MC();
            Student student = new Student("amir", "amiri", 12) ;
            //Console.WriteLine(student.Name);

            Student student1 = new Student("a", "b");

            StudentNew student2 = new StudentNew("amir", "amiri", 14);
            Console.WriteLine(student2.Name);

            student2.Update(new StudentNew("reza", "rezaii", 14));
            Console.WriteLine(student2.Name);


            StudentNew2 new2 = new StudentNew2();
            new2.Name = "a";
            new2.Surname = "a";
            new2.Age = 20;

            StudentNew2 new21 = new StudentNew2()
            {
                Age = 16,
                Surname = "AMIRI",
                Name = "AMIR"
            };


        }
    }
    class StudentNew2
    {
        public string Name { get;  set; }
        public string Surname { get;  set; }
        public int Age { get;  set; }

       
    }
    class StudentNew
    {
        public string Name { get;private set; }
        public string Surname { get;private set; }
        public int Age { get;private set; }

        public StudentNew(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void Update(StudentNew student)
        {
            this.Name = student.Name;
            this.Surname = student.Surname;
            this.Age = student.Age;
        }
    }



    class Student
    {
        private string name;
        private string surname;
        private int age;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }


        public Student(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

    

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    class MC
    {
        public MC()
        {
            Console.WriteLine("Hello This is Constrcutor");
        }

    }
}
