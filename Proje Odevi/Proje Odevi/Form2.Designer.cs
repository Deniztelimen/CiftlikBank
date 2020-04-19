namespace Proje_Odevi
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Anaveri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKilo = new System.Windows.Forms.TextBox();
            this.textBoxYas = new System.Windows.Forms.TextBox();
            this.textBoxCins = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdet = new System.Windows.Forms.TextBox();
            this.Ekle = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ana Menüye Dönüş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(769, 265);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Anaveri
            // 
            this.Anaveri.Location = new System.Drawing.Point(696, 283);
            this.Anaveri.Name = "Anaveri";
            this.Anaveri.Size = new System.Drawing.Size(107, 35);
            this.Anaveri.TabIndex = 2;
            this.Anaveri.Text = "Göster";
            this.Anaveri.UseVisualStyleBackColor = true;
            this.Anaveri.Click += new System.EventHandler(this.Anaveri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kilo";
            // 
            // textBoxKilo
            // 
            this.textBoxKilo.Location = new System.Drawing.Point(131, 345);
            this.textBoxKilo.Name = "textBoxKilo";
            this.textBoxKilo.Size = new System.Drawing.Size(100, 22);
            this.textBoxKilo.TabIndex = 6;
            // 
            // textBoxYas
            // 
            this.textBoxYas.Location = new System.Drawing.Point(131, 317);
            this.textBoxYas.Name = "textBoxYas";
            this.textBoxYas.Size = new System.Drawing.Size(100, 22);
            this.textBoxYas.TabIndex = 7;
            // 
            // textBoxCins
            // 
            this.textBoxCins.Location = new System.Drawing.Point(131, 289);
            this.textBoxCins.Name = "textBoxCins";
            this.textBoxCins.Size = new System.Drawing.Size(100, 22);
            this.textBoxCins.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adet";
            // 
            // textBoxAdet
            // 
            this.textBoxAdet.Location = new System.Drawing.Point(131, 373);
            this.textBoxAdet.Name = "textBoxAdet";
            this.textBoxAdet.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdet.TabIndex = 10;
            // 
            // Ekle
            // 
            this.Ekle.Location = new System.Drawing.Point(281, 285);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(82, 42);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(281, 333);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(82, 42);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.Location = new System.Drawing.Point(281, 384);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(82, 42);
            this.Guncelle.TabIndex = 13;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = true;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(842, 443);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.textBoxAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCins);
            this.Controls.Add(this.textBoxYas);
            this.Controls.Add(this.textBoxKilo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Anaveri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Genel Bilgi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Anaveri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKilo;
        private System.Windows.Forms.TextBox textBoxYas;
        private System.Windows.Forms.TextBox textBoxCins;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdet;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Guncelle;
    }
}