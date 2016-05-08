using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DKR
{
    static class SumMult
    {
        public static int Sum(int m, int n)
        {
            int sum = 0;

            for (int i = m; i < n; i++)
            {
                sum += 2 * i;
            }

            return sum;
        }

        public static int Mult(int m, int n)
        {
            int mult = 1;

            for (int i = m; i < n; i++)
            {
                mult *= 2 * i;
            }

            return mult;
        }
    }

    public static class Sum
    {
        public static double Sum2(int n, int q)
        {
            double sum = 0;

            for (int i = 1; i < n; i++)
            {
                sum += Math.Abs(i * q) < 10 ? Math.Pow(Math.E, i + q) : Math.Abs(i * q) == 10? i + q : 0;
            }

            return sum;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Sum.Sum2(22, 3));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
