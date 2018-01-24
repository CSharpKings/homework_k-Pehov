using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int proizvedenie = 0;
            while (true)
            {
                Console.WriteLine("Ввидите число");
                int number = int.Parse(Console.ReadLine());
                
                proizvedenie = number * number;
                    Console.WriteLine(proizvedenie);
            }
        }
    }
}
