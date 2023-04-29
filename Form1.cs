using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ort,vize, final, proje;
            vize = Convert.ToInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            proje = Convert.ToInt16(textBox3.Text);
            vize = (vize * 30) / 100;
            final = (final * 50) / 100;
            proje = (proje * 20) / 100;
            ort = vize + final + proje;
            textBox4.Text = ort.ToString();
            label1.Text = vize.ToString();
            label2.Text = final.ToString();
            label3.Text = proje.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
