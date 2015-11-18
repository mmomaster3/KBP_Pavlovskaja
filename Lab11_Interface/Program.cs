using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Interface
{
    class Program
    {
        interface IPoint
        {
            int x
            {
                get;
                set;
            }

            int y
            {
                get;
                set;
            }
        }

        class Point : IPoint
        {
            private int _x;
            private int _y;

            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public int x
            {
                get
                {
                    return _x;
                }

                set
                {
                    _x = value;
                }
            }

            public int y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }
        }

        class MainClass
        {
            static void PrintPoint(IPoint p)
            {
                Console.WriteLine("x={0}, y={1}", p.x, p.y);
            }

            static void Main()
            {
                Point p = new Point(2, 3);
                Console.Write("My Point: ");
                PrintPoint(p);
            }
        }
    }
}
