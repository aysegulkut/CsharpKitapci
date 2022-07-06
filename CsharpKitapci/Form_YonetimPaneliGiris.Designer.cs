namespace CsharpKitapci
{
    partial class Form_YonetimPaneliGiris
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
            this.button_Giris = new System.Windows.Forms.Button();
            this.label_parola = new System.Windows.Forms.Label();
            this.label_kullaniciadi = new System.Windows.Forms.Label();
            this.textBox_Parola = new System.Windows.Forms.TextBox();
            this.textBox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Giris
            // 
            this.button_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Giris.Location = new System.Drawing.Point(126, 137);
            this.button_Giris.Name = "button_Giris";
            this.button_Giris.Size = new System.Drawing.Size(100, 40);
            this.button_Giris.TabIndex = 10;
            this.button_Giris.Text = "Giriş";
            this.button_Giris.UseVisualStyleBackColor = true;
            this.button_Giris.Click += new System.EventHandler(this.button_Giris_Click);
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_parola.Location = new System.Drawing.Point(17, 91);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(54, 20);
            this.label_parola.TabIndex = 9;
            this.label_parola.Text = "Parola";
            // 
            // label_kullaniciadi
            // 
            this.label_kullaniciadi.AutoSize = true;
            this.label_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kullaniciadi.Location = new System.Drawing.Point(17, 51);
            this.label_kullaniciadi.Name = "label_kullaniciadi";
            this.label_kullaniciadi.Size = new System.Drawing.Size(93, 20);
            this.label_kullaniciadi.TabIndex = 8;
            this.label_kullaniciadi.Text = "Kullanıcı Adı";
            // 
            // textBox_Parola
            // 
            this.textBox_Parola.Location = new System.Drawing.Point(126, 91);
            this.textBox_Parola.Name = "textBox_Parola";
            this.textBox_Parola.PasswordChar = '*';
            this.textBox_Parola.Size = new System.Drawing.Size(122, 20);
            this.textBox_Parola.TabIndex = 7;
            // 
            // textBox_KullaniciAdi
            // 
            this.textBox_KullaniciAdi.Location = new System.Drawing.Point(126, 53);
            this.textBox_KullaniciAdi.Name = "textBox_KullaniciAdi";
            this.textBox_KullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.textBox_KullaniciAdi.TabIndex = 6;
            // 
            // Form_YonetimPaneliGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 257);
            this.Controls.Add(this.button_Giris);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_kullaniciadi);
            this.Controls.Add(this.textBox_Parola);
            this.Controls.Add(this.textBox_KullaniciAdi);
            this.Name = "Form_YonetimPaneliGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Giris;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.Label label_kullaniciadi;
        private System.Windows.Forms.TextBox textBox_Parola;
        private System.Windows.Forms.TextBox textBox_KullaniciAdi;
    }
}

