using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DZ_13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 100; number <= 200; number = number + 1)
            {
                int last;
                last = number % 7;
                if (last == 0)
                {
                    Console.WriteLine("кратно семи "+ number);
                }
            }
            Thread.Sleep(10000);
        }
    }
}
