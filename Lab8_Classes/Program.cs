using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите матриццу N*M ");
            int n = Int32.Parse(Console.ReadLine());
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            CheckArray arr = new CheckArray(n, m);
            Random r = new Random();

            for (int i = 0; i < arr.LengthN; i++)
            {
                for (int j = 0; j < arr.LengthM ; j++)
                {
                    arr[i, j] = Double.Parse(Console.ReadLine());
                    if (arr.errflag) { Console.WriteLine($"Вне границ {i} и {j}"); }

                }
            }
            Console.WriteLine();

            for (int i = 0; i < arr.LengthN; i++)
            {
                for (int j = 0; j < arr.LengthM; j++)
                {
                    Console.Write($"{arr[i, j].ToString("F")}  ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\nМассив нулевой " + arr.IZiro());
            try
            {
                Console.WriteLine("Массив диагональный " + arr.IDiagonal());
                Console.WriteLine("треугольная " + arr.ITriangle());
                Console.WriteLine("Массив симетричеый " + arr.ISemetric());
                Console.WriteLine("Массив единичный " + arr.IOne());
                
            }
            catch(SqrException except)
            {
                Console.WriteLine(except);
            }
            Console.ReadLine();
        }
    }
}
