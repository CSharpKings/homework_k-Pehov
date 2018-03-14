using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DZ_13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double number = 0.1; number <= 0.9; number = number + 0.1)
            {
                Console.WriteLine("Корень из: "+ number + " " + Math.Sqrt(number));
            }
            Thread.Sleep(10000);
        }
    }
}
