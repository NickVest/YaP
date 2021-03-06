﻿using System;
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

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // создаем переменную rsl, которая будет хранить результат вывода окна с вопросом
      // (пользователь нажал одну из клавиш на окне - это и есть результат)
      // MessageBox будет содержать вопрос, а также кнопки Yes, No и иконку Question(Вопрос)
      DialogResult rsl = MessageBox.Show("Вы действительно хотите выйти из приложения ? ", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      // если пользователь нажал кнопку да
      if (rsl == DialogResult.Yes)
      { // выходим из приложения
        Application.Exit();
      }
    }

    private void toolStripButton3_Click(object sender, EventArgs e)
    {
      // создаем новый экземпляр класса Preview,
      // отвечающего за работу с нашей дополнительной формой
      // в качестве параметра мы передаем наше загруженное изображение
      Form PreView = new Preview(MemForImage);
      // затем мы вызываем диалоговое окно
      PreView.ShowDialog();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      // загружаем png файлы
      LoadImage(false);
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
      // загружаем jpg фалйы
      LoadImage(true);
    }

    private void вФорматеJPGToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // загружаем jpg-файлы
      LoadImage(true);
    }

    private void вФорматеPNGToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // загружаем png файлы
      LoadImage(false);
    }

    Image MemForImage;
    // функция загрузки изображения
    private void LoadImage(bool jpg)
    {
      // директория, которая будет выбрана как начальная в окне для выбора файла
    openFileDialog1.InitialDirectory = "c:";
      // если будем выбирать jpg файлы
      if (jpg)
      {
        // устанавливаем формат файлов для загрузки - jpg
        openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files (*.*) | *.* ";
}
      else
      {
        // устанавливаем формат файлов для загрузки - png
        openFileDialog1.Filter = "image (PNG) files (*.png)|*.png|All files (*.*) | *.* ";
      }
      // если открытие окна выбора файла завершилось выбором файла и нажатием кнопки ОК
if (openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        try // безопасная попытка
        {
          // пытаемся загрузить файл с именем openFileDialog1.FileName - выбранный пользователем файл.
          MemForImage = Image.FromFile(openFileDialog1.FileName);
          // устанавливаем картинку в поле элемента PictureBox
          pictureBox1.Image = MemForImage;
        }
        catch (Exception ex) // если попытка загрузки не удалась
        {
          // выводим сообщение с причиной ошибки
          MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
        }
      }
    }
  }
 }
