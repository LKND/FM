using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication2;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //создать пару экземпляров с месседжбоксами, и передать их в контрол, для отображения.
            //dataGridView1.Columns.Add(Name, "Name");
            //dataGridView1.Columns.Add(Name, "Size");
            //dataGridView2.Columns.Add(Name, "Name");
            //dataGridView2.Columns.Add(Name, "Size");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Файл Открыт");
            progressBar1.Value = 0;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Файл Создан");
            progressBar1.Value = 0;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Файл скопирован");
            progressBar1.Value = 0;
        }
        private void btnReMove_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Файл перемещен");
            progressBar1.Value = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            MessageBox.Show("Файл удален");
            progressBar1.Value = 0;
        }
    }
}
