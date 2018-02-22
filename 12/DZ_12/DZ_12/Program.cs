using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DZ_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int MaxNumber = 100;
            int sum = 0;
            for (int number = 1; number <= 50 ; number++)
            {
                int randNumber = rand.Next(MaxNumber);
                Console.WriteLine(randNumber);
                sum = sum + randNumber;
            }
            int average;
            average = sum / 50;
            Console.WriteLine("среднее арифметическое " + average);
            Thread.Sleep(10000);

        }
    }
}
