using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab10_Struct
{
    class Program
    {
        public struct MARSH : IComparable
        {
            public string beginPoint {
                get;
                set; }
            public string endPoint;
            public int routeNumber;

            public int CompareTo(object obj)
            {
                var tmp = (MARSH)obj;
                if (this.routeNumber > tmp.routeNumber) return 1;
                if (this.routeNumber < tmp.routeNumber) return -1;
                return 0;
            }
        }

        static void Main(string[] args)
        {
            List<MARSH> list = new List<MARSH>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите новый маршрут в формате ( начальный_пункт конечный_пункт номер_маршрута )");
                string[] tmp = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                list.Add(new MARSH() { beginPoint = tmp[0], endPoint = tmp[1], routeNumber = int.Parse(tmp[2]) });
            }

            //list.OrderBy(n => n.routeNumber);
            list.Sort();

            Console.WriteLine("Отсортированный: ");
            foreach (MARSH m in list)
                Console.WriteLine("bp: {0} ep: {1} rn: {2}", m.beginPoint, m.endPoint, m.routeNumber);

            Console.Write("Введите номер маршрута: ");
            int number = int.Parse(Console.ReadLine());

            MARSH tmp1 = list.Find(delegate (MARSH x) { return x.routeNumber == number; });
            Console.WriteLine("bp: {0} ep: {1} rn: {2}", tmp1.beginPoint, tmp1.endPoint, tmp1.routeNumber);

            Console.ReadKey(true);
        }
    }
}
