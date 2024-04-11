using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Треугольник",3,3,3);
            Console.WriteLine($"{triangle.ToString()}");
            Rectangle rectangle = new Rectangle("Прямоугольник",2,5);
            Console.WriteLine($"{rectangle.ToString()}");
            Сircle сircle = new Сircle("Окружность",3);
            Console.WriteLine($"{сircle.ToString()}");
            Console.ReadKey();
        }
    }
}
