using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFig
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите длину:");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Введите ширину:");
            Rectangle rec = new Rectangle(temp, Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine($"Площадь: {rec.Area}; Периметр: {rec.Perimeter}.");
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        private double side1, side2;
        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }
        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
        public double Area
        {
            get { return AreaCalculator(); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

    }
}
