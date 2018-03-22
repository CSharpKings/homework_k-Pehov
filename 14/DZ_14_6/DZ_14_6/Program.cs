using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 6, 10, 5, 7, 1, 3 };
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
