using System;

namespace ConsoleApp15
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void Calculator(out double salary, out double tax)
        {
            double baseSalary = 0d;

            switch (Post)
            {
                case "Junior Developer":
                    baseSalary = 20000d;
                    break;
                case "Middle Developer":
                    baseSalary = 35000d;
                    break;
                case "Senior Developer":
                    baseSalary = 60000d;
                    break;
            }
            salary = baseSalary * Experience / 2d;
            tax = salary * 0.137d;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;
            Employee employee = new Employee("John", "Cena")
            {
                Post = "Middle Developer",
                Experience = 5
            };
            employee.Calculator(out double salary, out double tax);
            Console.WriteLine($"Имя: {employee.Name}\nФамилия: {employee.Surname}\nДолжность: {employee.Post}\nЗарплата: {salary}\nНалог: {tax} ");
            Console.ReadKey();



        }
    }
}
