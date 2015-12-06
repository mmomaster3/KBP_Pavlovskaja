using System;

namespace Lab10_Struct_main
{
    struct MARSH : IComparable
    {

        public string nachalniy_punkt_marshryta;
        public string konechniy_punkt_marshryta;
        public int nomer_marshryta;
        public override string ToString()
        {
            return (string.Format(@"
                                    Начальный пункт назначения: {0}
                                    Конечный пункт назначения: {1}
                                    Номер маршрута: {2}", nachalniy_punkt_marshryta, konechniy_punkt_marshryta, nomer_marshryta));
        }

        public int CompareTo(object obj)
        {
            var tmp = (MARSH)obj;
            if (this.nomer_marshryta > tmp.nomer_marshryta) return 1;
            if (this.nomer_marshryta < tmp.nomer_marshryta) return -1;
            return 0;
        }

        class Program
        {

            static void Main(string[] args)
            {
                Console.WriteLine("Введите кол-во записей:");
                int n = Int32.Parse(Console.ReadLine());
                MARSH[] mas = new MARSH[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nНачальный пункт маршрута:");
                    mas[i].nachalniy_punkt_marshryta = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Конечный пункт маршрута:");
                    mas[i].konechniy_punkt_marshryta = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Номер маршрута:");
                    mas[i].nomer_marshryta = Convert.ToInt32(Console.ReadLine());
                }

                Array.Sort(mas);
                Console.WriteLine("\nИнформация в базе:\n");
                foreach (var x in mas) Console.WriteLine(x);

                Console.WriteLine("\nВведите начальный или конечный маршрут для вывода информации: ");
                var fam = Convert.ToString(Console.ReadLine());
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (mas[i].nachalniy_punkt_marshryta == fam || mas[i].konechniy_punkt_marshryta == fam) Console.WriteLine(mas[i]); k++;
                }

                if (k == 0) Console.WriteLine("Зе нот екзист!");
                Console.ReadKey(true);
            }

        }
    }
}
