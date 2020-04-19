using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form2 formax = new Proje_Odevi.Form2();
            formax.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form3 formax = new Proje_Odevi.Form3();
            formax.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form4 formax = new Proje_Odevi.Form4();
            formax.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();

            txtSaat.Text = saat;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
