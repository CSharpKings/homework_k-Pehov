using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int MaxNumber = 10;
            while (true)
            {
                int A = rand.Next(MaxNumber);
                int B = rand.Next(MaxNumber);
                int C = rand.Next(MaxNumber);
                int Summa = A + B + C;
                Console.WriteLine("Сколько будет " + A + " + " + B + " + " + C + " ?");
                int guess = int.Parse(Console.ReadLine());
                if (Summa == guess)
                {
                    Console.WriteLine("всё правильно!");
                }
                else {
                    Console.WriteLine("Ошибочка. Правильный ответ "+Summa);
                }
            }

              
        }
    }
}
