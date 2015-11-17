using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Ex2_PointInArea
{
    class Program
    {
        static bool IsHitPoint(double x, double y, double r)
        {
            if (x * y < 0)
                return false;

            if (x == 0 || y == 0)
                return Math.Abs(x) + Math.Abs(y) <= r;

            return (x > 0) ? (x * x + y * y) <= r * r : (x + y) >= -r;
        }


        static void Main()
        {
            double x, y;
            double r = 1.0;
            double delta = 0.25;

            Console.WriteLine("r = {0}, delta = {1}.", r, delta);

            Console.WriteLine("\nx\ty\tresult\n-------------------------");
            for (x = -(r + delta); x <= r + delta; x += delta)
            {
                for (y = -(r + delta); y <= r + delta; y += delta)
                    Console.WriteLine("{0}\t{1}\t{2}", x, y, IsHitPoint(x, y, r));

                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
