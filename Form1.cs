using System;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Lab3Threads
{
	public partial class Form1 : Form
	{
		Random random = new Random();

		public Form1()
		{
			InitializeComponent();
		}

		private void DrawTriangle()
		{
			for (int i = 0; i < 100; i++)
			{
				int x = random.Next(0, Width);
				int y = random.Next(0, Height);
				this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x, y, x + 10, y + 20);
				this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x, y, x - 10, y + 20);
				this.CreateGraphics().DrawLine(new Pen(Color.Orange, 3), x + 10, y + 20, x - 10, y + 20);
				Thread.Sleep(100);
			}
		}

		private void DrawCircle()
		{
			for (int i = 0; i < 100; i++)
			{
				int x = random.Next(0, Width);
				int y = random.Next(0, Height);
				this.CreateGraphics().DrawEllipse(new Pen(Color.Green, 3), x, y, 20, 20);
				Thread.Sleep(100);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DrawTriangle();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DrawCircle();
		}
	}
}
