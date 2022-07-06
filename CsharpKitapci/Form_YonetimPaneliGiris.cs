using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpKitapci
{
    public partial class Form_YonetimPaneliGiris : Form
    {
        public Form_YonetimPaneliGiris()
        {
            InitializeComponent();
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            if ((textBox_KullaniciAdi.Text == "a") && (textBox_Parola.Text == "a"))
            {
                Form_YonetimPaneliGiris kapa = new Form_YonetimPaneliGiris();
                kapa.Close();
                Form_YonetimPaneli ac = new Form_YonetimPaneli();
                ac.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Kullanıcı Adı Veya Sifre Hatalı.");
                textBox_KullaniciAdi.Clear();
                textBox_Parola.Clear();
            }
        }
    }
}
