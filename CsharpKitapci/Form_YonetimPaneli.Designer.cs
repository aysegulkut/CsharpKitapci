namespace CsharpKitapci
{
    partial class Form_YonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_YonetimPaneli));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Fatura = new System.Windows.Forms.Button();
            this.button_KitapEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(270, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fatura Oluştur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap Ekle";
            // 
            // button_Fatura
            // 
            this.button_Fatura.Image = ((System.Drawing.Image)(resources.GetObject("button_Fatura.Image")));
            this.button_Fatura.Location = new System.Drawing.Point(274, 97);
            this.button_Fatura.Name = "button_Fatura";
            this.button_Fatura.Size = new System.Drawing.Size(137, 129);
            this.button_Fatura.TabIndex = 5;
            this.button_Fatura.UseVisualStyleBackColor = true;
            this.button_Fatura.Click += new System.EventHandler(this.button_Fatura_Click);
            // 
            // button_KitapEkle
            // 
            this.button_KitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("button_KitapEkle.Image")));
            this.button_KitapEkle.Location = new System.Drawing.Point(67, 97);
            this.button_KitapEkle.Name = "button_KitapEkle";
            this.button_KitapEkle.Size = new System.Drawing.Size(137, 129);
            this.button_KitapEkle.TabIndex = 4;
            this.button_KitapEkle.UseVisualStyleBackColor = true;
            this.button_KitapEkle.Click += new System.EventHandler(this.button_KitapEkle_Click);
            // 
            // Form_YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Fatura);
            this.Controls.Add(this.button_KitapEkle);
            this.Name = "Form_YonetimPaneli";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Fatura;
        private System.Windows.Forms.Button button_KitapEkle;
    }
}