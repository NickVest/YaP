using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика_1_Задание_3._2
{
	public partial class Form1 : Form
	{
		System.Windows.Forms.Timer t;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			t = new System.Windows.Forms.Timer();
			t.Interval = 100;
			t.Tick += new EventHandler(timer1_Tick);
			t.Start();
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}

		private void progressBar2_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value > 99)
			{
				progressBar1.Value = 0;
			}

			progressBar1.Value += 1;
			trackBar1.Value = progressBar1.Value;
			progressBar2.Value = 100 - progressBar1.Value;
		}

		

		private void trackBar1_ValueChanged(object sender, EventArgs e)
		{
			progressBar1.Value = trackBar1.Value;
		}
	}
}
