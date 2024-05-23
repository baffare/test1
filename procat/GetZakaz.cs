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
    public partial class GetZakaz : Form
    {
        Database database = new Database();
        public GetZakaz()
        {
            InitializeComponent();
        }

        private void GetZakaz_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (database.Getzakaz(
                Convert.ToInt32(textBox1.Text.Trim()),
                textBox2.Text.Trim(),
                textBox3.Text.Trim(),
                textBox4.Text.Trim(),
                Convert.ToInt32(textBox5.Text.Trim()),
                Convert.ToInt32(textBox6.Text.Trim()),
                textBox7.Text.Trim(),
                textBox8.Text.Trim(),
                textBox9.Text.Trim(),
                Convert.ToInt32(textBox10.Text.Trim()),
                textBox11.Text.Trim()
                ))

                
            {
           }
            Prodavec ww = new Prodavec();
            ww.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            interfece ww = new interfece();
            ww.Show();
            this.Close();
        }
    }
}
