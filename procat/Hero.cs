using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procat
{
    public partial class Hero : Form
    {
        public Hero()
        {
            InitializeComponent();
        }

        private void Hero_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.FIO;
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.prokatDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prokatDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.prokatDataSet.Zakaz);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 gg = new Form1();
            gg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetZakaz gg = new GetZakaz();
            gg.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
