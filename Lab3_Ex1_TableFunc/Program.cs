using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ex1_TableFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, dx = 0;
            Console.WriteLine("Введите значения:");
            Console.Write("x1= ");
            double sx = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2= ");
            double ex = Convert.ToDouble(Console.ReadLine());
            while (dx == 0)
            {
                if (dx != 0) break;
                Console.Write("Шаг=");
                dx = Convert.ToDouble(Console.ReadLine());
                if (dx == 0) Console.WriteLine("Non 0");
            }
            if (sx > ex)
            {
                x = sx;
                sx = ex;
                ex = x;
            }
            if (dx < 0) dx = -dx;
            Console.WriteLine("\tTabulation of function:");
            Console.WriteLine("___________________________________________");
            Console.WriteLine("    | -x - 2,               if -3 <= x < -2");
            Console.WriteLine("    | sqrt(1 - sqr(x + 1)), if -2 <= x < -1");
            Console.WriteLine("y = | 1,                    if -1 <= x < 1");
            Console.WriteLine("    | 3 - 2 * x,            if 1 <= x < 2");
            Console.WriteLine("    | -1,                   if 2 <= x <= 5");
            Console.WriteLine("    | undefined,            otherwise");
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    x    |    y    |");
            Console.WriteLine("+---------+---------+");
            for (int i = 0; Math.Round(Math.Abs(ex - sx) / dx) >= i; i++)   //for i := 0 to round(abs(ex - sx) / dx) do
            {
                x = sx + dx * i;
                Console.Write("|" + x + "\t  |"); //: 9:3
                if ((-3 <= x) && (x < -2))
                    Console.Write(-x - 2);//:9:3
                else
                        if ((-2 <= x) && (x < -1))
                    Console.Write(Math.Sqrt(1 - Math.Pow((x + 1), 2))); //:9:3
                else
                            if ((-1 <= x) && (x < 1))
                    Console.Write(1.0); //:9:3
                else
                                if ((1 <= x) && (x < 2))
                    Console.Write(3 - 2 * x); //:9:3 
                else
                                    if ((2 <= x) && (x <= 5))
                    Console.Write(-1.0); //:9:3
                else Console.Write("undefined");
                Console.WriteLine("");
            }
            Console.Write("+---------+---------+");
            Console.ReadLine();
        }
    }
}
