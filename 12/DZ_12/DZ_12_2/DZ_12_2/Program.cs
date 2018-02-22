using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DZ_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int high = 0;
            for (int boyar = 1; boyar <= 20; boyar++)
            {
                Console.WriteLine("Введите рост боярина");
                int growing = int.Parse(Console.ReadLine());
                if (growing > 160)
                {
                    high++;
                }

            }
            Console.WriteLine("должны подвергнуться наказанию " + high + " боярина");
            Thread.Sleep(10000);
        }
    }
}
