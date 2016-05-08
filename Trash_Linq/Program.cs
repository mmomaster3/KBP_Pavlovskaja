using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Trash_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10] { 1, 2, -5, 6, 2, 8, 4, -18, 1, 5 };


            var query =
                (from n in mas
                where n >= 0
                select n).Sum();

            Console.WriteLine(query);

            var query2 =
                (from n in mas
                 where n >= mas.Min(min => Math.Abs(min)) && n <= mas.Max(max => Math.Abs(max))
                 select n * n).Last();
            Console.WriteLine(new string('_', 50) + "\n" + query2);
            
            Console.WriteLine((new string('_', 50)));
            foreach (var item in mas.OrderByDescending(n => n))
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
