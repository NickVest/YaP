using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    private void button1_Click(object sender, EventArgs e)
    {
      double n = Convert.ToDouble(textBox1.Text);
      double esp = Convert.ToDouble(textBox1.Text);
      textBox2.Text = "Результат работы программы ст. Подхватилина Н.В." + Environment.NewLine;

      int m = 0;
      if (radioButton2.Checked) m = 1;
      double s = 0, p = 1, ch;
      double i = 1;
      switch (m)
      {
        case 0:
          ch = 1 / i;
          while (ch >= esp)
          {
            ch = 1 / i;
            s += ch;
            i++;
          }
          textBox2.Text += "При esp = " + textBox1.Text + Environment.NewLine;
          textBox2.Text += "Расчет суммы ряда S = " + Convert.ToString(s) + Environment.NewLine;
          break;
      }
    }
  }
}
