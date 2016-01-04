using System;
using System.Text.RegularExpressions;
using System.IO;


namespace Lab7_String
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"text.txt", System.Text.Encoding.Default))
            {
                Regex regex = new Regex(@"\b[+-]?\d{2}\b");
                string s = null;
                while (false == reader.EndOfStream)
                {
                    s = reader.ReadLine();
                    if (true != regex.IsMatch(s))
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
