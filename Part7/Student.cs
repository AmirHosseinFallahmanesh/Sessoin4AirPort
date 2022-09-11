namespace Part7
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