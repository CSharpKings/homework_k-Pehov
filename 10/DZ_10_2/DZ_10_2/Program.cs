using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cem_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            while (true)
            {
                Console.WriteLine("ВВЕДИТЕ ЧИСЛО!");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(number);
                if (number > max)
                {
                    max = number;
                }
                Console.WriteLine("Максимальное число " + max);

                
            }

        }
    }
}
