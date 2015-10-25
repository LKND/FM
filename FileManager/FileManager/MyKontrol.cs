using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication2;

namespace FileManager
{
    public partial class MyKontrol : Panel
    {
        public MyKontrol()
        {
            InitializeComponent();
        }
        
        private void Button1Click(object sender, EventArgs e)
        {
            string c = @"C:\";
            var fales = new Files { Per = c };
            dataGridView1.Rows.Clear();
            foreach (var i in fales._information())
            {
                dataGridView1.Rows.Add(fales.Name, fales.Size);
            }
        }
        private void Button2Click(object sender, EventArgs e)
        {
            string c = @"E:\";
            var fales = new Files { Per = c };
            dataGridView1.Rows.Clear();
            foreach (var i in fales._information())
            {
                dataGridView1.Rows.Add(fales.Name, fales.Size);
            }
        }

        public MyKontrol(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            dataGridView1.Columns.Add(Name, "Name");
            dataGridView1.Columns.Add(Name, "Size");
            dataGridView1.Dock=DockStyle.Bottom;
        }
    }

    //public class MyKontrolGrid : DataGridView
    //{
    //    public MyKontrol kontrol;
    //    private DataGridView dgv;
    //    private Button btnC;
    //    private Button btnD;
    //    public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
    //    public event ButtonClickedEventHandler OnUserControlButtonClicked;

    //    public MyKontrolGrid()
    //    {
    //        InitializeComponent();
    //    }

    //    private void InitializeComponent()
    //    {
    //        this.dgv=new DataGridView();
    //        this.kontrol=new MyKontrol();
    //        this.btnC=new Button();
    //        this.btnD=new Button();
    //        this.Controls.Add(this.kontrol);
    //        this.Controls.Add(this.dgv);
    //        this.Controls.Add(this.btnC);
    //        this.Controls.Add(this.btnD);
    //        this.Size=new Size(300, 350);
    //        this.dgv.Columns.Add(Name, "Name");
    //        this.dgv.Columns.Add(Name, "Size");
    //        btnC.Click+=new EventHandler(OnButtonClicked);

    //    }

    //    private void OnButtonClicked(object sender, EventArgs e)
    //    {
    //        if (OnUserControlButtonClicked != null)
    //            OnUserControlButtonClicked(this, e);
    //    }
    //}
}
