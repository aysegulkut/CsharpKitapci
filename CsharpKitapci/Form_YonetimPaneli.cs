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
    public partial class Form_YonetimPaneli : Form
    {
        public Form_YonetimPaneli()
        {
            InitializeComponent();
        }

        private void button_KitapEkle_Click(object sender, EventArgs e)
        {
            Form_YonetimPaneli kapa = new Form_YonetimPaneli();
            kapa.Close();
            Form_KitapEkle ac = new Form_KitapEkle();
            ac.Show();
            this.Hide();
        }

        private void button_Fatura_Click(object sender, EventArgs e)
        {
            Form_YonetimPaneli kapa = new Form_YonetimPaneli();
            kapa.Close();
            Form_Fatura ac = new Form_Fatura();
            ac.Show();
            this.Hide();
        }
    }
}
