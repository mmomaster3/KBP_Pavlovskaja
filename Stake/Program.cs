using System;
using System.Collections.Generic;

namespace Stake
{
    class Program
    {
        public class Stack<T>
        {
            int count;

            T[] items;
            int top; 

            public int Count
            {
                get { return count; }
                set { if ((top > 0) && (top <= count)) count = value; else Console.WriteLine("Error!!!"); }
            }

            public void InitStack() 
            {
                Console.Write("Введите количество элементов стека: ");
                count = Convert.ToInt32(Console.ReadLine());
                items = new T[count]; 
                top = count; 
            }

            public bool EndOfStack()
            {
                if (top == count) return true;
                else return false;
            }

            public void Push(T item)
            {
                if (top == 0) { Console.WriteLine("Error"); return; }
                else
                {
                    items[top - 1] = item;
                    top = top - 1;
                }
            }

            public T Pop() 
            {
                if (top == count) { Console.WriteLine("Error"); } else top = top + 1; return items[top - 1];
            }
        }

        static void Main(string[] args)
        {
           
            Stack<int> ints = new Stack<int>();
            ints.InitStack();
            for (int i = 0; i < ints.Count; i++)
                ints.Push(i);
            while (!ints.EndOfStack())
            {
                int x = ints.Pop();
                Console.WriteLine(x + " ");
            }

            Console.ReadKey();
        }

    }
}