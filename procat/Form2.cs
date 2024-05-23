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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator gg = new QRCoder.QRCodeGenerator();
            var dd = gg.CreateQrCode(textBox1.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(dd);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
