﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Array
{
    class das
    {
        const int d = 2;
        static int s = 4;
        public int i = 2;
        int t = 3;

        public static int D
        {
            get
            {
                return d;
            }
        }

        public static int S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public int T
        {
            get
            {
                return t;
            }

            set
            {
                t = value;
            }
        }
    }

    class Program
    {
        public override string ToString()
        {
            return base.ToString();
        }

        unsafe static void Main(string[] args)
        {
            das dsasd = new das();
            

            int summ = 0;
            int comm = Int32.MaxValue;
            bool flag = false;
            Console.Write("Введите кол-во эл-ов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int* arr = stackalloc int[n]; //Оператор stackalloc принимает после себя массив, на который будет указывать указатель.
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
            Console.WriteLine("\n \nМин. эл-т по Abs: " + comm);  //вывод мин эле-та
            Console.WriteLine("Сумма abs массива: " + summ);
            Console.WriteLine("\nВведите интервал:"); // ввод интервала
            Console.Write("от:");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.Write("до:");
            int fin = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (p[i] >= str && p[i] <= fin) p[i] = 0;
            }
            Console.WriteLine("\nКонечный массив: ");
            //вывод конецного массива
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
