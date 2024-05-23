using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace procat
{
    
    public partial class interfece : Form
    {
        Timer tim = new Timer();
        public interfece()
        {
            InitializeComponent();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        public void interfece_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.FIO;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Shtrih_Kod". При необходимости она может быть перемещена или удалена.
            this.shtrih_KodTableAdapter.Fill(this.prokatDataSet.Shtrih_Kod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.History_Vhod". При необходимости она может быть перемещена или удалена.
            this.history_VhodTableAdapter.Fill(this.prokatDataSet.History_Vhod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Uslug". При необходимости она может быть перемещена или удалена.
            this.uslugTableAdapter.Fill(this.prokatDataSet.Uslug);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Oborud". При необходимости она может быть перемещена или удалена.
            this.oborudTableAdapter.Fill(this.prokatDataSet.Oborud);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.prokatDataSet.Client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.prokatDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.prokatDataSet.Zakaz);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            tim.Interval = 1000;
            tim.Tick += timer1_Tick;
            tim.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tim.Tick += (obj, ebat) => {
                label3.Text = DateTime.Now.Second.ToString();



            };
            if (label3.Text == "100")
            {
             
                Form1 gg = new Form1();
                gg.Show();
                this.Close();
                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
