using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 9, 0, -3, 44, -22, -2, 9 };
            int min = mas.Min(x => Math.Abs(x));

            int index = Array.IndexOf((from i in mas select Math.Abs(i)).ToArray(), min);

            Console.WriteLine("Номер минимального эл-та: " + index);

            int NegFirstIndex = Array.FindIndex(mas, n => n < 0);
            int result = (NegFirstIndex == -1) ? 0 : mas.Where((i, j) => j > NegFirstIndex).Sum();
            Console.WriteLine("\nСумма эл-ов: " + result);

            Console.WriteLine("\nВведите инервал a и b:\n");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            var ValueQuery = (from i in mas
                              where i > a && i < b
                              select i).ToList();

            int count = mas.GetLength(0) - ValueQuery.Count();

            for (int i = 0; i < count; i++)
            {
                ValueQuery.Add(0);
            }
            Console.WriteLine();

            foreach (var i in ValueQuery)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
