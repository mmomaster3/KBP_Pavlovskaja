using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string s = @"Далее, после первой десятки, вслед за таинственным числом 10
, начинаются двузначные числа. Они являются комбинацией однозначных чисел и потому вторичн
ы по отношению к ним. Каждое двузначное число путем суммирования составляющих его цифр может быть ";
            string pattern = @"\b" + text + "\b";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            if (regex.IsMatch(s))
            {
                Console.WriteLine(s);
            }
        }
    }
}
