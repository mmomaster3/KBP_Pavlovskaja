﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Array
{
    class Program
    {
        unsafe static void Main(string[] args)
        {

            int summ = 0;
            int comm = Int32.MaxValue;
            bool flag = false;
            Console.Write("Введите кол-во эл-ов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int* arr = stackalloc int[n];
            int* p = arr;
            Random r = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                p[i] = r.Next(-100, 100);
                if (p[i] < 0 || flag == true)
                {
                    summ += Math.Abs(p[i]);
                    flag = true;
                }

                if (Math.Abs(p[i]) < comm) comm = Math.Abs(p[i]);
                Console.Write(p[i] + "  ");
            }     
            Console.WriteLine("\n \nМин. эл-т по Abs: " + comm);
            Console.WriteLine("Сумма abs массива: " + summ);
            Console.WriteLine("\nВведите интервал:");
            Console.Write("от:");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.Write("до:");
            int fin = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (p[i] >= str && p[i] <= fin) p[i] = 0;
            }
            Console.WriteLine("\nКонечный массив: ");
            //int buff;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    if (Math.Abs(p[j - 1]) < Math.Abs(p[j]))
                    {
                        int x = p[j - 1]; p[j - 1] = p[j]; p[j] = x;
                    }
                }
                Console.Write(arr[i] + "  ");
            }
            //
            Console.ReadLine();
        }
    }
}
