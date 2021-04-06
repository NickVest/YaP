using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _12._1
{
  public partial class Form1 : Form
  {
    //Chart chart;
    double[] x = new double[6] {3.0, 3.2, 3.4, 3.6, 3.8, 4.0 };
    double[] y = new double[6] { 2.0, 3.0, 3.0, 3.0, 2.0, 4.0 };
    double a0 = 0, a1 = 0,  b0 = 0, b1 = 0,  s0 = 0, s1 = 0, s2 = 0;
    double pa0 = 0, pa1 = 0, pa2 = 0, pb0 = 0, pb1 = 0, pb2 = 0, ps0 = 0, ps1 = 0, ps2 = 0, ps3 = 0, ps4 = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      chart1.ChartAreas.Add(area);
      
      dataGridView1.RowCount = 6; 
      dataGridView1.ColumnCount = 2;

      dataGridView2.RowCount = 2;
      dataGridView2.ColumnCount = 3;

      dataGridView3.RowCount = 3;
      dataGridView3.ColumnCount = 4;

      dataGridView4.RowCount = 2;
      dataGridView4.ColumnCount = 2;

      dataGridView5.RowCount = 3;
      dataGridView5.ColumnCount = 2;

      //Заполнение значений X
      dataGridView1.Columns[0].HeaderText = "x";
      for (int i = 0; i < 6; i++)
      {
        dataGridView1.Rows[i].Cells[0].Value = x[i];
      }
      //Заполнение значений Y
      dataGridView1.Columns[1].HeaderText = "y";
      for (int i = 0; i < 6; i++)
      {
        dataGridView1.Rows[i].Cells[1].Value = y[i];
      }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      
      Series series1 = new Series();
      // Ссылаемся на область для построения графика
      series1.ChartArea = "myGraph";
      // Задаём тип графика - сплайны
      series1.ChartType = SeriesChartType.Point;
      // Указываем ширину линии графика
      series1.BorderWidth = 3;
      series1.MarkerColor = Color.Red;
      
      // Название графика для отображения в легенде
      series1.LegendText = "Начальные данные";
      // Добавляем в список графиков диаграммы
      chart1.Series.Add(series1);
      chart1.Series[0].Points.DataBindXY(x, y);
    }

    private void chart1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 6; i++)
      {
        b0 = b0 + y[i] * Math.Pow(x[i], 0);
        b1 = b1 + y[i] * Math.Pow(x[i], 1);

        s0 = s0 + Math.Pow(x[i], 0);
        s1 = s1 + Math.Pow(x[i], 1);
        s2 = s2 + Math.Pow(x[i], 2);
      }
      a0 = (b1*s1 - b0*s2)/(s1*s1 - s2*s0);
      a1 = (b0 - s0*a0)/s1;

      dataGridView2.Rows[0].Cells[0].Value = s0;
      dataGridView2.Rows[0].Cells[1].Value = s1;
      dataGridView2.Rows[0].Cells[2].Value = b0;

      dataGridView2.Rows[1].Cells[0].Value = s1;
      dataGridView2.Rows[1].Cells[1].Value = s2;
      dataGridView2.Rows[1].Cells[2].Value = b1;

      dataGridView4.Columns[0].HeaderText = "Коэффициент";
      dataGridView4.Rows[0].Cells[0].Value = "a0";
      dataGridView4.Rows[0].Cells[1].Value = a0;

      dataGridView4.Columns[1].HeaderText = "Значение";
      dataGridView4.Rows[1].Cells[0].Value = "a1";
      dataGridView4.Rows[1].Cells[1].Value = a1;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      double[] y1 = new double[6];

      Series series2 = new Series();
      series2.ChartArea = "myGraph";
      series2.ChartType = SeriesChartType.Spline;
      series2.BorderWidth = 2;
      series2.Color = Color.DarkRed;
      series2.LegendText = "Полином первой степени";
      chart1.Series.Add(series2);

      for (int i = 0; i < 6; i++)
      {
        y1[i] = a0 + a1 * x[i];
      }

      chart1.Series[1].Points.DataBindXY(x, y1);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      double c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;

      for (int i = 0; i < 6; i++)
      {
        pb0 = pb0 + y[i] * Math.Pow(x[i], 0);
        pb1 = pb1 + y[i] * Math.Pow(x[i], 1);
        pb2 = pb2 + y[i] * Math.Pow(x[i], 2);

        ps0 = ps0 + Math.Pow(x[i], 0);
        ps1 = ps1 + Math.Pow(x[i], 1);
        ps2 = ps2 + Math.Pow(x[i], 2);
        ps3 = ps3 + Math.Pow(x[i], 3);
        ps4 = ps4 + Math.Pow(x[i], 4);
      }
      c1 = ps1 - ps0 * ps3 / ps2;
      c2 = ps2 - ps1 * ps3 / ps2;
      c3 = pb1 - pb0 * ps3 / ps2;
      c4 = ps2 - ps0 * ps4 / ps2;
      c5 = ps3 - ps1 * ps4 / ps2;
      c6 = pb2 - pb0 * ps4 / ps2;

      pa0 = (c6*c2 - c5*c3) / (c2*c4 - c5*c1);
      pa1 = (c3 - c1*pa0) / c2;
      pa2 = (pb0 - ps1*pa1 - ps0*pa0) / ps2;

      dataGridView3.Rows[0].Cells[0].Value = ps0;
      dataGridView3.Rows[0].Cells[1].Value = ps1;
      dataGridView3.Rows[0].Cells[2].Value = ps2;
      dataGridView3.Rows[0].Cells[3].Value = pb0;

      dataGridView3.Rows[1].Cells[0].Value = ps1;
      dataGridView3.Rows[1].Cells[1].Value = ps2;
      dataGridView3.Rows[1].Cells[2].Value = ps3;
      dataGridView3.Rows[1].Cells[3].Value = pb1;

      dataGridView3.Rows[2].Cells[0].Value = ps2;
      dataGridView3.Rows[2].Cells[1].Value = ps3;
      dataGridView3.Rows[2].Cells[2].Value = ps4;
      dataGridView3.Rows[2].Cells[3].Value = pb2;

      dataGridView5.Columns[0].HeaderText = "Коэффициент";
      dataGridView5.Columns[1].HeaderText = "Значение";

      dataGridView5.Rows[0].Cells[0].Value = "a0";
      dataGridView5.Rows[0].Cells[1].Value = pa0;

      dataGridView5.Rows[1].Cells[0].Value = "a1";
      dataGridView5.Rows[1].Cells[1].Value = pa1;

      dataGridView5.Rows[2].Cells[0].Value = "a2";
      dataGridView5.Rows[2].Cells[1].Value = pa2;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      double[] y2 = new double[6];

      Series series3 = new Series();
      series3.ChartArea = "myGraph";
      series3.ChartType = SeriesChartType.Spline;
      series3.BorderWidth = 2;
      series3.Color = Color.Green;
      series3.LegendText = "Полином второй степени";
      chart1.Series.Add(series3);

      for (int i = 0; i < 6; i++)
      {
        y2[i] = pa0 + pa1 * x[i] + pa2 * Math.Pow(x[i], 2);
      }

      chart1.Series[2].Points.DataBindXY(x, y2);
    }

  }
}
