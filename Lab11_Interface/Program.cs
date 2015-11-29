using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Interface
{
    interface IDishes
    {
        string clear(byte clear);
    }

    interface IDrinkabe : IDishes
    {
        string drink(byte drink);
    }

    public class TeaCup : IDrinkabe
    {
        public string drink(byte drink)
        {
            switch (drink)
            {
                case 1: return "Будем пить ";
                case 2: return "Мы не пьем ";
            }
            throw new Exception("Вы сделали не правельный выбор!".ToString());
        }

        public string clear(byte clear)
        {
            switch (clear)
            {
                case 1: return "из мытой посуды";
                case 2: return "из не мытой посуды.";
            }
            throw new Exception("Вы сделали не правельный выбор!".ToString());
        }

        public string pig()
        { return " Поздравляю вы свинья!"; }
    }

    class Program
    {
        class MainClass
        {
            static void Main()
            {
                Console.WriteLine("1-Будем мыть посуду\n2-Не будем мыть посуду");
                byte clear = byte.Parse(Console.ReadLine());
                Console.WriteLine("1-Будем пить\n2-Не будем пить");
                byte drink = byte.Parse(Console.ReadLine());

                TeaCup cup = new TeaCup();

                Console.Write(cup.drink(drink) + cup.clear(clear));
                Console.Write(clear == 2 ? cup.pig() : "");
                Console.ReadLine();
            }
        }
    }
}
