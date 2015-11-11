using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ConsoleApplication2;
using UltimateFilesHurricaneManagerClassLibrary;

namespace FileManager
{
    public partial class MyKontrol : Panel
    {
        public string[] Drives = Environment.GetLogicalDrives();
        File fales;

        public int datagridView_Left { get; set; }
        public int datagridView_Right { get; set; }
        public MyKontrol()
        {
            InitializeComponent();
        }
        public void CreateDiskBut()
        {
            List<Button> listBTN = new List<Button>();
            Button btn;
            int k = 0;
            for (int i = 0; i < Drives.Length; i++)
            {
                btn = new Button();
                btn.Location = new Point(10 + k, 30);
                btn.Size = new Size(50, 25);
                btn.Name = "BTN"+Drives[i];
                btn.Text = Drives[i];
                btn.Dock = DockStyle.Top;
                listBTN.Add(btn);
                k = k + 50;
                btn.Click += ButtonClickOD;
            }
            foreach (Button b in listBTN)
            {
                panel1.Controls.AddRange(new Button[] { b });
            }

        }
        public void ButtonClickOD(object sender, EventArgs e)
        {
            string g = ((Button) sender).Text;
            openDir(g);
        }
        public void openDir(string d)
        {
            string c = d;
            //var fales = new Files { Per = c };
            //fales = new Files {Per = c};
            //dataGridView1.Rows.Clear();
            //foreach (var l in fales._information())
            //{
            //    dataGridView1.Rows.Add(fales.Name, fales.Size);
            //}
            dataGridView1.Rows.Clear();
            Folder flFile = new Folder(c);
            flFile.Open();
            foreach (var l in flFile.DirectoriesList)
            {
                dataGridView1.Rows.Add(l.Name, l.Path);
            }
            foreach (var l in flFile.FilesList)
            {
                dataGridView1.Rows.Add(l.Name, l.Size);
            }
        }

        public MyKontrol(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            dataGridView1.Columns.Add(Name, "Name");
            dataGridView1.Columns.Add(Name, "Size");
            dataGridView1.Dock=DockStyle.Bottom;
            CreateDiskBut();
            var flFile=new Folder(@"C:\");
            flFile.Open();
            foreach (var l in flFile.DirectoriesList)
            {
                dataGridView1.Rows.Add(l.Name, l.Path);
            }
            foreach (var l in flFile.FilesList)
            {
                dataGridView1.Rows.Add(l.Name,l.Size);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = dataGridView1.CurrentCell.RowIndex;
            string c = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            var flFile = new Folder(c);
          try
            {
                
                flFile.Open();
                dataGridView1.Rows.Clear();
                foreach (var l in flFile.DirectoriesList)
                {
                    dataGridView1.Rows.Add(l.Name, l.Path);
                }
                foreach (var l in flFile.FilesList)
                {
                    dataGridView1.Rows.Add(l.Name, l.Size);
                }
                
            }
            catch (Exception)
            {

                var flfiles = new File(flFile.Path);
                flfiles.Open();
            }
            
        }
    }
}
