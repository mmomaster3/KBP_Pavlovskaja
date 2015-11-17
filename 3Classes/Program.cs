using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();
            Console.WriteLine("\nВведите фикс. зароботную плату:");
            int fix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите stat");
            int stat = Convert.ToInt32(Console.ReadLine());

            FixedSal fixedsal = new FixedSal(name, fix);
            HoursSal hour = new HoursSal(name, stat);


        }
    }
}
