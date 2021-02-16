using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double x = Convert.ToDouble(textBox1.Text);
      double y = Convert.ToDouble(textBox2.Text);
      double z = Convert.ToDouble(textBox3.Text);

      textBox4.Text = "Результаты работы программы ст. Иванова И.И." + Environment.NewLine;
      textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
      textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
      textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;

      int n = 0;
      if (radioButton2.Checked) n = 1;
      else if (radioButton3.Checked) n = 2;

      double u;
      switch (n)
      {
        case 0:
          if ((z - x) == 0) u = y * Math.Sinh(x) * Math.Sinh(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Sinh(x)) - z;
          else u = y * Math.Sin(Math.Sinh(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 1:
          if ((z - x) == 0) u = y * Math.Cosh(x) * Math.Cosh(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Cosh(x)) - z;
          else u = y * Math.Sin(Math.Cosh(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        case 2:
          if ((z - x) == 0) u = y * Math.Exp(x) * Math.Exp(x) + z;
          else if ((z - x) < 0) u = y * Math.Exp(Math.Exp(x)) - z;
          else u = y * Math.Sin(Math.Exp(x)) + z;
          textBox4.Text += "U = " + Convert.ToString(u) + Environment.NewLine;
          break;
        default:
          textBox4.Text += "Решение не найдено" + Environment.NewLine;
          break;
      }
    }
    private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

    
  }
}
