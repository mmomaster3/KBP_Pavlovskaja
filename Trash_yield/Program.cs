using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trash_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 'а';
            int ya = 'я';
            Console.WriteLine(a +  " " + ya);
            //MyClass MC = new MyClass();
            //foreach (var i in MC.GetBook(550))
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
        }
    }

    class MyClass
    {
        int[] mas = new int[7];

        public MyClass()
        {
            
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                mas[i] = i;
            }

            
        }


        public IEnumerable GetBook(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == mas.GetLength(0))
                {
                    yield break;
                }
                else
                {
                    yield return mas[i];
                }
            }
        }
    }
}
