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
    public partial class Form2 : Form
    {
        SqlCommand komut;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-MHFR7QC\TELIMEN;Initial Catalog=Projeodev;User ID=sa;Password=123");
        
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            Form1 formax = new Proje_Odevi.Form1();
            formax.Show();
        }

        private void Anaveri_Click(object sender, EventArgs e)
        { 
            verilerigoster("Select * From Hayvan");
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCins.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxYas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxKilo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxAdet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Hayvan(Cins,Yas,Kilo,Adet) VALUES(@Cins,@Yas,@Kilo,@Adet) ";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@Cins", textBoxCins.Text);
            komut.Parameters.AddWithValue("@Yas", textBoxYas.Text);
            komut.Parameters.AddWithValue("@Kilo", textBoxKilo.Text);
            komut.Parameters.AddWithValue("@Adet", textBoxAdet.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Hayvan");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Hayvan WHERE Cins=@Cins";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Cins",textBoxCins.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Hayvan");


        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Hayvan SET Yas=@Yas,Kilo=@Kilo,Adet=@Adet WHERE Cins=@Cins";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Cins", textBoxCins.Text);
            komut.Parameters.AddWithValue("@Yas",Convert.ToInt16( textBoxYas.Text));
            komut.Parameters.AddWithValue("@Kilo", Convert.ToInt16(textBoxKilo.Text));
            komut.Parameters.AddWithValue("@Adet", Convert.ToInt16(textBoxAdet.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Hayvan");

        }
    }
}
