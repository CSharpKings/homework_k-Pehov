using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_14_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 6, 2, 5, 4 };
            int sum = 0;
            for (int i = 0;i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);
            float last;
            last = sum % 2;
            if (last == 0)
            {
                Console.WriteLine("сумма элементов массива является чётным числом");
            }
            else 
            {
                Console.WriteLine("сумма элементов массива НЕ является чётным числом");
            }
            Console.ReadLine();
        }
    }
}
