﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wins = { 3, 5, 4, 7, 2, 10, 1, 9, 3, 4, 2, 0 };
            for (int i = 0; i < wins.Length; i++)
            {
                if (wins[i] < 3)
                {
                    Console.WriteLine("номер команды меньше трех побед " + i);
                }
            }
            Console.ReadLine();
        }
    }
}
