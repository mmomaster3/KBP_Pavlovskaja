using System;
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
            int[] arr = new int[n];
            Random r = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-100, 100);
                if (arr[i] < 0 || flag == true)
                {
                    summ += Math.Abs(arr[i]);
                    flag = true;
                }

                if (Math.Abs(arr[i]) < comm) comm = Math.Abs(arr[i]);
                
                fixed(int *ptr = arr)
                Console.Write((*(ptr + i)) + "  ");
            }     
            Console.WriteLine("\n \nМин. эл-т по Abs: " + comm);
            Console.WriteLine("Сумма abs массива: " + summ);
            Console.WriteLine("\nВведите интервал:");
            Console.Write("от:");
            int str = Convert.ToInt32(Console.ReadLine());
            Console.Write("до:");
            int fin = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= str && arr[i] <= fin) arr[i] = 0;
            }
            Console.WriteLine("\nКонечный массив: ");
            //int buff;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (Math.Abs(arr[j - 1]) < Math.Abs(arr[j]))
                    {
                        int x = arr[j - 1]; arr[j - 1] = arr[j]; arr[j] = x;
                    }
                }
                Console.Write(arr[i] + "  ");
            }
            //
            Console.ReadLine();
        }
    }
}
