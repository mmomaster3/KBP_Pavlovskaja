using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_LineProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            double z1, z2;
            Console.WriteLine("Vvedite m");
            string s = Console.ReadLine();
            m = Convert.ToInt32(s);
            Console.WriteLine("Vvedite n");
            s = Console.ReadLine();
            n = Convert.ToInt32(s);
            z1 = (((m - 1) * Math.Sqrt(m)) - ((n - 1) * Math.Sqrt(n))) / (Math.Sqrt(Math.Pow(m, 3)) + n * m + Math.Pow(m, 2) - m);
            Console.WriteLine(z1);
            Console.WriteLine("z1={0,10:f}", z1);
            z2 = ((Math.Sqrt(m) - Math.Sqrt(n)) / m);
            Console.WriteLine(z2);
            Console.ReadLine();
        }
    }
}
