using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._2
{
  public partial class Form1 : Form
  {
    private int r;
    float[] x = new float[9];
    float[] y = new float[9];
    private double a;
    private Pen pen = new Pen(Color.Black, 2);

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //определяем цент экрана
      x[0] = ClientSize.Width / 4;
      y[0] = ClientSize.Height / 4;
      r = 75; //задаем радиус
      a = 0; //задаем угол поворота
      for (int i = 1; i < 9 ; i++)
      {
        int arc = 45;

        x[i] = x[0] + (int)(r * Math.Cos(a - (i - 1) * arc * Math.PI / 180));
        y[i] = y[0] - (int)(r * Math.Sin(a - (i - 1) * arc * Math.PI / 180));
      }
      
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      for (int i = 1; i < 9; i++)
      {
        g.DrawLine(pen, x[0], y[0], x[i], y[i]);
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int coord = rnd.Next(15, 30);
      a -= 0.05;
      x[0] += coord/10;
      y[0] += coord/10;
      //определяем конец часовой стрелки с учетом центра экрана
      for (int i = 1; i < 9; i++)
      {
        int arc = 45;

        x[i] = x[0] + (int)(r * Math.Cos(a - (i - 1) * arc * Math.PI / 180));
        y[i] = y[0] - (int)(r * Math.Sin(a - (i - 1) * arc * Math.PI / 180));
      }
      Invalidate(); //вынудительный вызов перерисовки (Paint)
    }
  }
}
