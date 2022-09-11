using System;
using System.Collections.Generic;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter Username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();

                if (username=="admin" && password=="admin")
                {
                    bool adminPage = true;
                    while (adminPage)
                    {
                         
                        adminMenu();
                        string select = Console.ReadLine();
                        switch (select)
                        {
                            case "1":
                                addStudent(students);
                                break;
                            case "2":
                                editStudent(students);

                                break;
                            case "3":
                                deleteStudent(students);
                                break;
                            case "4":
                                printStudents(students);

                                break;
                            case "5":
                                searchStudent(students);
                                break;
                            case "6":
                                adminPage = false;
                               break;

                            default:
                                Console.WriteLine("input invalid");
                                break;
                        }
                    }
                  
                }
                else if(username == "guest" && password == "guest")
                {
                    bool guestPage = true;
                    while (guestPage)
                    {

                        guestMenu();
                        string select = Console.ReadLine();
                        switch (select)
                        {
                            case "1":
                                printStudents(students);
                                break;
                            case "2":
                                searchStudent(students);

                                break;
                            case "3":
                                guestPage = false;
                                break;
                    

                            default:
                                Console.WriteLine("input invalid");
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Username or Password Not found");
                    Console.ReadKey();
                }


                
            }

        }
        static void adminMenu()
        {
            Console.Clear();
            Console.WriteLine("1)Add Student");
            Console.WriteLine("2)Edit Student");
            Console.WriteLine("3)Delete Student");
            Console.WriteLine("4)Print Students");
            Console.WriteLine("5)Search Students");
            Console.WriteLine("6)Log Off");
        }

        static void guestMenu()
        {
            Console.Clear();

            Console.WriteLine("1)Print Students");
            Console.WriteLine("2)Search Students");
            Console.WriteLine("3)Log Off");
        }
        static void searchStudent(List<Student> students)
        {
            List<Student> result = new List<Student>();
            Console.Clear();
            Console.WriteLine("Enter Search");
            string search = Console.ReadLine();
            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].Surname.StartsWith(search))
                {
                    result.Add(students[i]);
                }

            }

            printStudents(result);

        }

        static void deleteStudent(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Enter Search");
            string search = Console.ReadLine();

            int index = findIndex(students, search);
            if (index != -1)
            {

                students.RemoveAt(index);
                Console.WriteLine("Delete Operatoin Successful");

            }
            else
            {
                Console.WriteLine("Student Not Found");
            }

            Console.ReadKey();
        }

        static void editStudent(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Enter Search");
            string search = Console.ReadLine();

            int index = findIndex(students, search);
            if (index != -1)
            {

                Console.WriteLine("Enter Name");
                students[index].Name = Console.ReadLine();
                Console.WriteLine("Enter Surname");
                students[index].Surname = Console.ReadLine();
                Console.WriteLine("Enter Age");
                students[index].Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Update Operatoin Successful");

            }
            else
            {
                Console.WriteLine("Student Not Found");
            }

            Console.ReadKey();
        }



        static void printStudents(List<Student> students)
        {
            Console.Clear();
            for (int i = 0; i < students.Count; i++)
            {

                Console.WriteLine("Name      =  " + students[i].Name);
                Console.WriteLine("Surname   =  " + students[i].Surname);
                Console.WriteLine("Age       =  " + students[i].Age);
                Console.WriteLine("***********************************");
            }
            Console.ReadKey();
        }

        static void addStudent(List<Student> students)
        {
            Console.Clear();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            Student student = new Student(age, name, surname);
            students.Add(student);
            Console.WriteLine("Add Operatoin Successful");
            Console.ReadKey();
        }


        static int findIndex(List<Student> array, string search)
        {
            int index = -1;
            for (int i = 0; i < array.Count; i++)
            {

                if (array[i].Surname == search)
                {
                    index = i;
                }
            }
            return index;
        }

     
    }
}
//admin admin  add edit delete print search 
//guest guest  search print