﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativePrecipitations {
	class Program {
		static void Main(string[] args) {
			int[] precipitations = { 25, 4545, 45, 2, -16, 765, 341, 1, -3, 0 };
            int zero = precipitations[0];
			for (int i = 0; i < precipitations.Length; i++) {
				precipitations[i] = precipitations[i] - zero;
				Console.WriteLine(precipitations[i]);
			}
			Console.ReadLine();
		}
	}
}
