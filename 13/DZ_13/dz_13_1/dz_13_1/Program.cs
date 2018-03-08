using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dz_13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово.");
            string str = Console.ReadLine();
            int strlenght = str.Length;
            if (str[0] == str[str.Length - 1])
            {
                Console.WriteLine("Мне нравится!");
            }
            else
            {
                Console.WriteLine("Мне не нравится!");
            }
            Console.ReadLine();
            
        }
    }
}
