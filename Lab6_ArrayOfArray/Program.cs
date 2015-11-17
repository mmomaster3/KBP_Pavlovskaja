using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_ArrayOfArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 7;
            int m = 7;
            double[,] A = new double[7, 7]
            {
                {1, 1, 2, 5, 2, 7, 1},
                {7, 2, 5, 6, 1, 3, 1},
                {4, 3, 1, 9, 1, 6, 2},
                {6, 8, 1, 6, 8, 1, 0},
                {8, 2, 4, 6, 9, 1, 1},
                {8, 7, 5, 3, 2, 3, 9},
                {9, 7, 1, 9, 5, 8, 4}
            };
            triang(ref A, m, n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + Math.Round(A[i, j]), 2);
                Console.WriteLine();
            }

            mid(ref A, m, n);

            Console.ReadLine();
        }
        public static double mid(ref double[,] a, int n, int m)
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Введите велечину: ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double tmp = 0;
            double mid = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                tmp = 0;
                for (int j = 0; j < m; j++)
                {
                    tmp += a[i, j];
                    if (j == m - 1)
                    {
                        mid = tmp / m;
                        if (k > mid)
                        {
                            ++count;
                            Console.WriteLine("Строка: " + i + " меньше чем  {" + k + "}");
                        }
                    }

                }
            }
            Console.WriteLine("\nКоличество строк меньше ср. ар. {" + k + "} = " + count);
            return 0;
        }
        public static int triang(ref double[,] a, int n, int m)
        {
            double tmp = 0;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (i > j)
                    {
                        if (a[j, i] != 0)
                            tmp = a[i, j] / a[j, j];
                        for (int f = 0; f < n; f++)
                            a[i, f] = a[i, f] - (tmp * a[j, f]);
                    }
            return 0;
        }
    }
}
