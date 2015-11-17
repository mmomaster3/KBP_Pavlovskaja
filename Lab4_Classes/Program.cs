using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Введите а, b, c: ");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Triangle triangle=new Triangle();
            try
            {
                triangle.A = a; triangle.B = b;
                    //new Triangle(a, b, c);
                Console.WriteLine(triangle);
                Console.WriteLine();
                Console.WriteLine("Периметр = "+triangle.Perim().ToString("F"));
                Console.WriteLine("Площадь = "+ triangle.Area().ToString("F"));
                Console.WriteLine("Медиана равна = "+triangle.Median().ToString("F"));                
            }
            catch (TriangleExeption exception)
            {
                Console.WriteLine(triangle);
                Console.WriteLine(exception);
                Console.WriteLine();
            }
            tr2 tr22 = new tr2();
            Console.WriteLine(tr22);
            Console.ReadLine();
        }
    }
}
