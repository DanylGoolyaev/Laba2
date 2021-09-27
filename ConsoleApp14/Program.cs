using System;

namespace ConsoleApp14
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime Date { get; }

        public User(string login, string name, string surname, int age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Логин: {Login}\n" + $"Имя: {Name}\n" + $"Фамилия: {Surname}\n" + $"Возраст: {Age}\n" + $"Дата заполнения анкеты: {Date}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Логин: ");
            string login = Console.ReadLine();

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());

            User user = new User(login, name, surname, age);
            Console.WriteLine("Заполненная анкета:");
            Console.WriteLine(user);
            Console.ReadLine();
        }
    }
}
