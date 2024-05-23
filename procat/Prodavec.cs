using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;	


namespace procat
{
    public partial class Prodavec : Form
    {
        public SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-949SEK0; Initial Catalog=prokat; Integrated Security=True");
        public Prodavec()
        {
            InitializeComponent();
        }

        private void Prodavec_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.FIO;
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect.Open();
            string ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand dt = new SqlCommand("DELETE FROM Zakaz Where ID = '" + ID + "'");
            dt.Connection = connect;
            dt.ExecuteNonQuery();
            this.zakazTableAdapter.Fill(this.prokatDataSet.Zakaz);
            dt.Parameters.Clear();
            connect.Close();
        

         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
