using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "2";
      textBox2.Text = "Практическая работа № 1 Иванов И.И.";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражений y=формула №6";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      double x = double.Parse(textBox1.Text);
      textBox2.Text += Environment.NewLine + "При х = " + x.ToString();
      double y = ((Math.Sqrt(Math.Pow(x, 3))-Math.Log(x)) / (Math.Cos(2*Math.Pow(x, 2)) + Math.Abs(x-3))) + ((3*Math.Pow((x-2), 2))/(Math.Log(x)+2));
      textBox2.Text += Environment.NewLine + "Результат y = " + y.ToString();
    }
  }
}
