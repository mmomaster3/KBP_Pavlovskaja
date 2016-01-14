using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashUnsafe
{
    class Program
    {
        static void Main(string[] args)
        {

            unsafe
            {
                int* x; // определение указателя
                int y = 10; // определяем переменную

                x = &y; // указатель x теперь указывает на адрес переменной y
                Console.WriteLine(*x); // 10

                y = y + 20;
                Console.WriteLine(*x);// 30

                *x = 50;
                Console.WriteLine(y); // переменная y=50
            }
            Console.ReadLine();
        }
    }
}
