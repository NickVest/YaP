﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (
          textBox1.Text == ""
          ||
          textBox2.Text == ""
        )
      {
        textBox3.Text = "error";
      }
      else
      {
        double a, b;
        a = Convert.ToDouble(textBox1.Text);
        b = Convert.ToDouble(textBox2.Text);

        switch (comboBox1.Text)
        {
          case "+":
            textBox3.Text = Convert.ToString(a + b);
            break;
          case "-":
            textBox3.Text = Convert.ToString(a - b);
            break;
          case "*":
            textBox3.Text = Convert.ToString(a * b);
            break;
          case "/":
            if (b != 0)
            {
              textBox3.Text = Convert.ToString(a / b);
            }
            else
            {
              textBox3.Text = "error";
            }
            break;
        }
        if (
            textBox1.Text == ""
            &&
            textBox2.Text == ""
          )
        {
          textBox3.Text = "error";
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      comboBox1.Text = "";
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
  }
}