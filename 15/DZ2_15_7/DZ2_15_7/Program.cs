using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DZ2_15_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] monthJuly = { 5, 4, 3, 6, 2, 9, 3, 10, 5, 2 };
            int July = 0;
            for (int i = 0; i < monthJuly.Length; i++)
            {
                July = July + monthJuly[i];
            }

            int[] monthAugust = { 7, 2, 4, 5, 1, 9, 8, 3, 6, 10 };
            int August = 0;
            for (int i2 = 0; i2 < monthAugust.Length; i2++)
            {
                August = August + monthAugust[i2];
            }

            int common;
            common = July + August;

            Console.WriteLine(common);
            Console.ReadLine();
        }
    }
}
