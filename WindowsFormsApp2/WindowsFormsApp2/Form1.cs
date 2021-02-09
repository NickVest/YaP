using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

   private void button1_Click(object sender, EventArgs e)
   {
      Random rnd = new Random();
      int value = rnd.Next(0, 10);
      switch (value)
      {
         case 0:
          button2.Visible = false;
          break;
        case 1:
          button3.Visible = false;
          break;
        case 2:
          button4.Visible = false;
          break;
        case 3:
          button5.Visible = false;
          break;
        case 4:
          button2.Visible = true;
          break;
        case 5:
          button3.Visible = true;
          break;
        case 6:
          button4.Visible = true;
          break;
        case 7:
          button5.Visible = true;
          break;
        case 8:
          button1.Visible = false;
          break;
        case 9:
          button1.Visible = true;
          break;
      }
   }

    private void button2_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int value = rnd.Next(0, 10);
      switch (value)
      {
        case 0:
          button2.Visible = false;
          break;
        case 1:
          button3.Visible = false;
          break;
        case 2:
          button4.Visible = false;
          break;
        case 3:
          button5.Visible = false;
          break;
        case 4:
          button2.Visible = true;
          break;
        case 5:
          button3.Visible = true;
          break;
        case 6:
          button4.Visible = true;
          break;
        case 7:
          button5.Visible = true;
          break;
        case 8:
          button2.Visible = false;
          break;
        case 9:
          button2.Visible = true;
          break;
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int value = rnd.Next(0, 10);
      switch (value)
      {
        case 0:
          button2.Visible = false;
          break;
        case 1:
          button3.Visible = false;
          break;
        case 2:
          button4.Visible = false;
          break;
        case 3:
          button5.Visible = false;
          break;
        case 4:
          button2.Visible = true;
          break;
        case 5:
          button3.Visible = true;
          break;
        case 6:
          button4.Visible = true;
          break;
        case 7:
          button5.Visible = true;
          break;
        case 8:
          button3.Visible = false;
          break;
        case 9:
          button3.Visible = true;
          break;
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int value = rnd.Next(0, 10);
      switch (value)
      {
        case 0:
          button2.Visible = false;
          break;
        case 1:
          button3.Visible = false;
          break;
        case 2:
          button4.Visible = false;
          break;
        case 3:
          button5.Visible = false;
          break;
        case 4:
          button2.Visible = true;
          break;
        case 5:
          button3.Visible = true;
          break;
        case 6:
          button4.Visible = true;
          break;
        case 7:
          button5.Visible = true;
          break;
        case 8:
          button4.Visible = false;
          break;
        case 9:
          button4.Visible = true;
          break;
      }
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int value = rnd.Next(0, 10);
      switch (value)
      {
        case 0:
          button2.Visible = false;
          break;
        case 1:
          button3.Visible = false;
          break;
        case 2:
          button4.Visible = false;
          break;
        case 3:
          button5.Visible = false;
          break;
        case 4:
          button2.Visible = true;
          break;
        case 5:
          button3.Visible = true;
          break;
        case 6:
          button4.Visible = true;
          break;
        case 7:
          button5.Visible = true;
          break;
        case 8:
          button5.Visible = false;
          break;
        case 9:
          button5.Visible = true;
          break;
      }
    }
  }
}
