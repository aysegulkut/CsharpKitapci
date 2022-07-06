namespace CsharpKitapci
{
    partial class Form_KitapEkle
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
            this.listView_kitap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_resim = new System.Windows.Forms.Button();
            this.textBox_kitapadet = new System.Windows.Forms.TextBox();
            this.textBox_kitapfiyat = new System.Windows.Forms.TextBox();
            this.textBox_kategori = new System.Windows.Forms.TextBox();
            this.textBox_dil = new System.Windows.Forms.TextBox();
            this.textBox_yayinevi = new System.Windows.Forms.TextBox();
            this.textBox_yazar = new System.Windows.Forms.TextBox();
            this.textBox_kitapadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_yonetimpaneli = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_kitapekle = new System.Windows.Forms.Button();
            this.pictureBox_kitapresmi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kitapresmi)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_kitap
            // 
            this.listView_kitap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_kitap.HideSelection = false;
            this.listView_kitap.Location = new System.Drawing.Point(12, 309);
            this.listView_kitap.Name = "listView_kitap";
            this.listView_kitap.Size = new System.Drawing.Size(699, 185);
            this.listView_kitap.TabIndex = 43;
            this.listView_kitap.UseCompatibleStateImageBehavior = false;
            this.listView_kitap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yazar";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yayınevi";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dil";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kategori";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adet";
            // 
            // button_resim
            // 
            this.button_resim.Location = new System.Drawing.Point(432, 42);
            this.button_resim.Name = "button_resim";
            this.button_resim.Size = new System.Drawing.Size(200, 23);
            this.button_resim.TabIndex = 42;
            this.button_resim.Text = "Seç...";
            this.button_resim.UseVisualStyleBackColor = true;
            // 
            // textBox_kitapadet
            // 
            this.textBox_kitapadet.Location = new System.Drawing.Point(432, 235);
            this.textBox_kitapadet.Name = "textBox_kitapadet";
            this.textBox_kitapadet.Size = new System.Drawing.Size(200, 20);
            this.textBox_kitapadet.TabIndex = 41;
            // 
            // textBox_kitapfiyat
            // 
            this.textBox_kitapfiyat.Location = new System.Drawing.Point(432, 203);
            this.textBox_kitapfiyat.Name = "textBox_kitapfiyat";
            this.textBox_kitapfiyat.Size = new System.Drawing.Size(200, 20);
            this.textBox_kitapfiyat.TabIndex = 40;
            // 
            // textBox_kategori
            // 
            this.textBox_kategori.Location = new System.Drawing.Point(432, 171);
            this.textBox_kategori.Name = "textBox_kategori";
            this.textBox_kategori.Size = new System.Drawing.Size(200, 20);
            this.textBox_kategori.TabIndex = 39;
            // 
            // textBox_dil
            // 
            this.textBox_dil.Location = new System.Drawing.Point(432, 139);
            this.textBox_dil.Name = "textBox_dil";
            this.textBox_dil.Size = new System.Drawing.Size(200, 20);
            this.textBox_dil.TabIndex = 38;
            // 
            // textBox_yayinevi
            // 
            this.textBox_yayinevi.Location = new System.Drawing.Point(432, 107);
            this.textBox_yayinevi.Name = "textBox_yayinevi";
            this.textBox_yayinevi.Size = new System.Drawing.Size(200, 20);
            this.textBox_yayinevi.TabIndex = 37;
            // 
            // textBox_yazar
            // 
            this.textBox_yazar.Location = new System.Drawing.Point(432, 75);
            this.textBox_yazar.Name = "textBox_yazar";
            this.textBox_yazar.Size = new System.Drawing.Size(200, 20);
            this.textBox_yazar.TabIndex = 36;
            // 
            // textBox_kitapadi
            // 
            this.textBox_kitapadi.Location = new System.Drawing.Point(432, 11);
            this.textBox_kitapadi.Name = "textBox_kitapadi";
            this.textBox_kitapadi.Size = new System.Drawing.Size(200, 20);
            this.textBox_kitapadi.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Kategori";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Dil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Resim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ad";
            // 
            // button_yonetimpaneli
            // 
            this.button_yonetimpaneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_yonetimpaneli.Location = new System.Drawing.Point(12, 247);
            this.button_yonetimpaneli.Name = "button_yonetimpaneli";
            this.button_yonetimpaneli.Size = new System.Drawing.Size(185, 46);
            this.button_yonetimpaneli.TabIndex = 26;
            this.button_yonetimpaneli.Text = "Yönetim Paneli";
            this.button_yonetimpaneli.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(510, 270);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(76, 33);
            this.button_sil.TabIndex = 25;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            // 
            // button_kitapekle
            // 
            this.button_kitapekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kitapekle.Location = new System.Drawing.Point(386, 270);
            this.button_kitapekle.Name = "button_kitapekle";
            this.button_kitapekle.Size = new System.Drawing.Size(75, 33);
            this.button_kitapekle.TabIndex = 24;
            this.button_kitapekle.Text = "Ekle";
            this.button_kitapekle.UseVisualStyleBackColor = true;
            // 
            // pictureBox_kitapresmi
            // 
            this.pictureBox_kitapresmi.Location = new System.Drawing.Point(175, 14);
            this.pictureBox_kitapresmi.Name = "pictureBox_kitapresmi";
            this.pictureBox_kitapresmi.Size = new System.Drawing.Size(161, 192);
            this.pictureBox_kitapresmi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_kitapresmi.TabIndex = 23;
            this.pictureBox_kitapresmi.TabStop = false;
            // 
            // Form_KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 504);
            this.Controls.Add(this.listView_kitap);
            this.Controls.Add(this.button_resim);
            this.Controls.Add(this.textBox_kitapadet);
            this.Controls.Add(this.textBox_kitapfiyat);
            this.Controls.Add(this.textBox_kategori);
            this.Controls.Add(this.textBox_dil);
            this.Controls.Add(this.textBox_yayinevi);
            this.Controls.Add(this.textBox_yazar);
            this.Controls.Add(this.textBox_kitapadi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_yonetimpaneli);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.button_kitapekle);
            this.Controls.Add(this.pictureBox_kitapresmi);
            this.Name = "Form_KitapEkle";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kitapresmi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_kitap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button button_resim;
        private System.Windows.Forms.TextBox textBox_kitapadet;
        private System.Windows.Forms.TextBox textBox_kitapfiyat;
        private System.Windows.Forms.TextBox textBox_kategori;
        private System.Windows.Forms.TextBox textBox_dil;
        private System.Windows.Forms.TextBox textBox_yayinevi;
        private System.Windows.Forms.TextBox textBox_yazar;
        private System.Windows.Forms.TextBox textBox_kitapadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_yonetimpaneli;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_kitapekle;
        private System.Windows.Forms.PictureBox pictureBox_kitapresmi;
    }
}