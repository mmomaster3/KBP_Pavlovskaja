using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Ex3_Taylor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное значение суммы ряда: ");
            double xn = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечное значение суммы ряда: ");
            double ex = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг: ");
            double s = double.Parse(Console.ReadLine());
            double eps = 0.0000001;
            int n = 1;
            double result = 0, currVal = 1 / xn;

            Console.WriteLine("+------------+------------+");
            Console.WriteLine("|      x     |    Atan    |");
            Console.WriteLine("+------------+------------+");
            //double x1 = 2;
            double arth;
            for (double x = xn; x <= ex; x = x + s)
            {
                n = 1;
                currVal = 1 / x;
                result = 0;
                while (Math.Abs(currVal) > eps)
                {
                    result += currVal;
                    currVal = (1 / ((2 * n + 1) * (Math.Pow(x, 2 * n + 1))));
                    // currVal *= (2 * n - 1) / (x * x * (2 * n + 1));
                    // x=x + (1/((2*i+1)*Math.Pow(x, 2*i+1)));
                    n++;

                }
          //      arth = 0.5 * Math.Log((1 + x) / (1 - x));
                Console.WriteLine("|" + "   X={0,5:f}" + "  |" + " Arth ={1,5:f}" + "|", x,result);

            }

            Console.WriteLine("+------------+------------+");
            //Console.WriteLine("\nАркТангинс: "+ Math.Atan(x));
            Console.ReadLine();
        }
    }
}
