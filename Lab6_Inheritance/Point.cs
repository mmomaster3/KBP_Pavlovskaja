using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_Inheritance
{
    class Point
    {
        private int x;

        public Point(int x)
        {
            this.X = x;
        }

        protected int X
        {
            get
            {
                return x;
            }

            set
            {
                if (x >= 0)
                {
                    x = value;
                } else { "Ошибка".ToString(); }
            }
        }

        public void Print(int x)
        {
            Console.WriteLine($"Точка x = {x} ");
            Console.WriteLine(new string(' ', x) + '*');
            Console.WriteLine(new string(' ', x) + x);
        }
    }
    class Line : Point
    {
        private int y;

        public Line (int x, int y):base (x)
        {
            this.Y = y;
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                if (y >= 0)
                {
                    y = value;
                }
                else { "Ошибка".ToString(); }
            }
        }

        public void Print(int x, int y)
        {
            int buf = 0;
            if (x > y)
            {
                buf = x;
                x = y;
                y = buf;
            }
            Console.WriteLine($"Линия с координатоми X = {x} и  Y = {y}");
            Console.WriteLine(new string(' ', x) + new string('_', y));
            Console.WriteLine(new string(' ', x)+ x + new string(' ', y - 2) + y);
        }


    }
    class ColoredPoint : Point
    {     
        public ColoredPoint(int x, string clr):base (x)
        {
           
        }
    }
}
