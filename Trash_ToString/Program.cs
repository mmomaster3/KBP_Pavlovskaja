using System;
using System.Globalization;

namespace Trash_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 0.01;
            Console.WriteLine(i.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(i.ToString("P"));
            Console.ReadLine();
        }
    }
}
