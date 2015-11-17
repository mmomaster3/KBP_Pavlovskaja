using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ex1_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int r = 2;

            if (x >= -10 && x < -6)
                Console.WriteLine("Func: {0}", 2 - Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x + 8), 2)));
            else
                if (x >= -6 && x < -4)
                Console.WriteLine("Func: {0}", 2);
            else
                    if (x >= -4 && x < 2)
                Console.WriteLine("Func: {0}", -0.5 * x);
            else
                        if (x >= 2)
                Console.WriteLine("Func: {0}", x - 3);
            else
                Console.WriteLine("Функции нету");
            Console.ReadKey();
        }
    }
}
