using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procat
{
    public partial class Form1 : Form
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-949SEK0; Initial Catalog=prokat; Integrated Security=True");
        public static string FIO;
        public int w = 0;
        
       
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString();
            var loginUsers = textBox1.Text;
            var passwordUsers = textBox2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string zapros = $"select * from Sotrudniki where Login = '{loginUsers}' and Password = '{passwordUsers}'"; 
            
            SqlCommand comm = new SqlCommand(zapros, conn);
            adapter.SelectCommand = comm;
            
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                string Gleo2 = table.Rows[0][0].ToString();
                string Gleo = table.Rows[0][1].ToString();
                MessageBox.Show("Вы успешно вошли!","Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (Gleo == "Администратор")
                {
                    conn.Open();
                    FIO = table.Rows[0][2].ToString();
                    string history = $"INSERT INTO History_Vhod Values ('{Gleo2}','{s}', 'Успешно')";
                    SqlCommand commp = new SqlCommand(history, conn);
                    commp.ExecuteNonQuery();
                    interfece bb = new interfece();
                    bb.Show();
                    this.Hide();
                    conn.Dispose();
                }
                else if(Gleo == "Продавец")
                {
                    conn.Open();
                    string history = $"INSERT INTO History_Vhod Values ('{Gleo2}','{s}', 'Успешно')";
                    FIO = table.Rows[0][2].ToString();
                    SqlCommand commp = new SqlCommand(history, conn);
                    commp.ExecuteNonQuery();
                    Prodavec ww = new Prodavec();
                    ww.Show();
                    this.Hide();
                    conn.Dispose();
                }
                else if (Gleo == "Старший смены")
                {
                    conn.Open();
                    string history = $"INSERT INTO History_Vhod Values ('{Gleo2}','{s}', 'Успешно')";
                    FIO = table.Rows[0][2].ToString();
                    SqlCommand commp = new SqlCommand(history, conn);
                    commp.ExecuteNonQuery();
                    Prodavec ww = new Prodavec();
                    ww.Show();
                    this.Hide();
                    conn.Dispose();
                }
                
                conn.Dispose();
            }
            else if (table.Rows.Count == 0)
            {

                MessageBox.Show("Такого аккаунта нету!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                w++;
                if (w == 3)
                {
                    captha captha = new captha();
                    captha.Show();
                    this.Hide();
                }
            }


        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
               
                textBox2.PasswordChar = '\0';

            }
            else 
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.FromArgb(73, 140, 81);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }

}
