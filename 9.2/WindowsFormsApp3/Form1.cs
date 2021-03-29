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
    Pen pen1 = new Pen(Color.Black, 2);
    Pen pen2 = new Pen(Color.DarkGreen, 2);
    Brush brush1 = new SolidBrush(Color.DarkGreen);
    Brush brush2 = new SolidBrush(Color.Black);
    Point[] pKorpus = new Point[4];
    Point[] pBashnya = new Point[6];

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics g = e.Graphics;
      g.DrawArc(pen1, 300, 300, 50, 50, 90, 180);
      g.DrawArc(pen1, 700, 300, 50, 50, -90, 180);
      g.DrawLine(pen1, 320, 350, 730, 350);
      pKorpus[0] = new Point(300, 200);
      pKorpus[1] = new Point(275, 300);
      pKorpus[2] = new Point(775, 300);
      pKorpus[3] = new Point(750, 200);
      g.FillPolygon(brush1, pKorpus);
      pBashnya[0] = new Point(450, 100);
      pBashnya[1] = new Point(425, 150);
      pBashnya[2] = new Point(450, 200);
      pBashnya[3] = new Point(600, 200);
      pBashnya[4] = new Point(625, 150);
      pBashnya[5] = new Point(600, 100);
      g.DrawPolygon(pen1, pBashnya);
      g.FillRectangle(brush2, 150, 140, 300, 20);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
      
    }
  }
}
