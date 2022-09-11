using System;


namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.totalHours = 100;
            employee.baseSalary = 20;
            employee.extraHours = 51;
            employee.insurance = 400;
            employee.tax = 0.09;
            Console.WriteLine(employee.Income());
        }
    }

    class Employee
    {
        public int totalHours;
        public double baseSalary;
        public int extraHours;
        public double insurance;
        public double tax;

        public double Income()
        {
            double result = totalHours * baseSalary;
            result += extraHours * 1.4 * baseSalary;
            if (totalHours+extraHours>150)
            {
                result += 1000;
            }
            result -= insurance;
            result = result * (1 - tax);
            return result;
        }

    }

}
