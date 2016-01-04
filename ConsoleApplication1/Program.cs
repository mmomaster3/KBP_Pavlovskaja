using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyClient
    {
        unsafe public static void Main()
        {
            int[] iArray = new int[10];
            for (int count = 0; count < 10; count++)
            {
                iArray[count] = count * count;
            }
            fixed (int* ptr = iArray)
            {
                for (int i = 0; i < 14; i++)
                {
                    Console.WriteLine(*(ptr + i));
                }
                Console.ReadLine();
            }
        }  
    }
}
