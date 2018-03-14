using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Cem_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово");
            string str = Console.ReadLine();
            int strlenght = str.Length;
            bool isI = false;
            int counti = 0;
            for (int i = 0; i < strlenght; i++)
            {
                if (str[i] == 'и')
                {
                    isI = true;
                    counti++;
                }
            }
            if (isI)
            {
                Console.WriteLine("В слове есть буква 'и' " + counti + " раз(а).");
            }
            else
            {
                Console.WriteLine("В этом слове нет буквы 'и' ");
            }
            Console.ReadLine();
        }
    }
}
