using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopyLandscape {
	public partial class Form1 : Form {
		Graphics graphics;
		public Form1() {
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs e) {
			graphics = e.Graphics;
			graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			Pen pen = new Pen(Brushes.BlueViolet, 8);
			// Упростите код с помощью цикла for
            // первая пара чисел - координаты начала отрезка, вторая - координаты конца
            for (int line = 0; line <= 6; line = line + 1)
            {
                int number;
                number = line * 60 + 20;
                int number2;
                number2 = line * 60 + 80;
                graphics.DrawLine(pen, number, 40, number2, 80);
            }
		}
	}
}
