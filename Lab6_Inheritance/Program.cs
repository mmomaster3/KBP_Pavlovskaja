using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите точку X");
            int x = Int16.Parse(Console.ReadLine());
            Point point = new Point(x);
            point.Print(x);
            Console.WriteLine("\nВведите точку Y");
            int y = Int16.Parse(Console.ReadLine());
            Line line = new Line(x,y);
            line.Print(x, y);


            Console.ReadLine();
        }
    }
}
