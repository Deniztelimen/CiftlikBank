using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Proje_Odevi
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MHFR7QC\TELIMEN;Initial Catalog=Projeodev;User ID=sa;Password=123");
        public void verilerigoster(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Visible = false;
            Form1 formax = new Proje_Odevi.Form1();
            formax.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verilerigoster("Select * From Hayvan");

            verilerigoster2("Select * From Uretim");
        }
        public void verilerigoster2(string veriler)
        {

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }
       
    }
}
