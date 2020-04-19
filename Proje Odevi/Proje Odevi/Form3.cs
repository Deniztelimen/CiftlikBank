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
    public partial class Form3 : Form
    {
        SqlCommand komut;
        public Form3()
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
            Form3.ActiveForm.Visible = false;
            Form1 formax = new Proje_Odevi.Form1();
            formax.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * From Uretim");
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Uretim(Urun_adi,Urun_adet,Urun_fiyat) VALUES(@Urun_adi,@Urun_adet,@Urun_fiyat) ";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Urun_adi", textBoxUrun.Text);
            komut.Parameters.AddWithValue("@Urun_adet", textBoxAdet.Text);
            komut.Parameters.AddWithValue("@Urun_fiyat", textBoxFiyat.Text);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Uretim");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUrun.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxAdet.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxFiyat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Uretim WHERE Urun_adi=@Urun_adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Urun_adi", textBoxUrun.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Uretim");
        }

        private void buttongun_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Uretim SET Urun_adi=@Urun_adi,Urun_adet=@Urun_adet,Urun_fiyat=@Urun_fiyat WHERE Urun_adi=@Urun_adi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Urun_adi", textBoxUrun.Text);
            komut.Parameters.AddWithValue("@Urun_adet", Convert.ToInt16(textBoxAdet.Text));
            komut.Parameters.AddWithValue("@Urun_fiyat", Convert.ToInt16(textBoxFiyat.Text));
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster("Select * From Uretim");
        }

        private void buttonhsp_Click(object sender, EventArgs e)
        {
            
            


            try
            {
                int a = Convert.ToInt16(textBoxAdet.Text);
                int b = Convert.ToInt16(textBoxFiyat.Text);
                int t = (a * b);
                sonuc.Text = t.ToString();
                
            }
            catch (Exception t)
            {
                MessageBox.Show(sonuc, "Lütfen Ürün adına çift tıklayınız");
            }


        }
    }
}
