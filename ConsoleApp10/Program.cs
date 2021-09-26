using System;

namespace ConsoleApp10
{
    class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public Rectangle() { }

        double AreaCalculator()
        {
            return side1 * side2;
        }

        double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area { get { return this.AreaCalculator(); } }
        public double Perimeter { get { return this.PerimeterCalculator(); } }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону А прямоугольника -> ");
            string x = Console.ReadLine();
            double side1 = Int32.Parse(x);

            Console.Write("Введите сторону Б прямоугольника -> ");
            string y = Console.ReadLine();
            double side2 = Int32.Parse(y);

            Rectangle rectangle = new Rectangle(side1, side2);

            Console.WriteLine("Площадь = {0}", rectangle.Area);
            Console.WriteLine("Периметр = {0}", rectangle.Perimeter);

        }
    }
}
