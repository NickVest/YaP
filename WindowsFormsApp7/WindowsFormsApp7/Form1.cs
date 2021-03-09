using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      int len = str.Length;
      int count = 0;
      int i = 0;

      /*while (i < len - 1)
      {
        if (str[i] == ' ')
          count++;
        i++;
      }
      label1.Text = "Количество пробелов = " + count.ToString();*/

      string newstr = str.Replace(" ", string.Empty);
      str = str.ToLower();
      newstr = newstr.ToLower();

      char[] newstrReverse = newstr.ToCharArray();
      Array.Reverse(newstrReverse);
      newstr = new string(newstrReverse);

      if (str.Replace(" ", string.Empty) == newstr)
      {
        label1.Text = "Является палиндромом";
      }
      else label1.Text = "Не является палиндромом";
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
