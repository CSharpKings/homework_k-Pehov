﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyPasteHell {
	class Program {
		static void Main(string[] args) {
			float[] numbers = { 765, 341, 1, -3, 0, 13, -200, 23, 44 };
            for (int loop = 0; loop < numbers.Length; loop++)
            {
                //numbers[0] = numbers[0] / 5;
                numbers[loop] = numbers[loop] / 5;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
			Console.ReadLine();
		}
	}
}
