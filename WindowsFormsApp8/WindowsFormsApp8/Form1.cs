using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
  public partial class Form1 : Form
  {
    int[] Mas = new int[15];

    public Form1()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      textBox1.Text = "";
      for (int i = 0; i < 15; i++)
      {
        Mas[i] = rand.Next(-50, 50);
        textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      /*textBox2.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] < 0) Mas[i] = 0;
        textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(Mas[i]) + Environment.NewLine;
      }
      */

      int chch = 0;
      textBox2.Text = "";
      for (int i = 0; i < 15; i++)
      {
        if (Mas[i] <= 7 && Mas[i] > 0) chch++;
      }
      textBox2.Text += "количество положительных элементов массива, не превышающих числа '7' = " + chch;
    }
  }
}
