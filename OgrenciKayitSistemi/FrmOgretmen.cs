using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitSistemi
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDersler fr=new FrmDersler();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKulup klp=new FrmKulup();
            klp.Show();
        }

        private void btnOgrenciisleri_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr=new FrmOgrenci();
            fr.Show();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr=new FrmSinavNotlar();
            fr.Show();
            
        }

        private void btnOgretmenler_Click(object sender, EventArgs e)
        {

        }
    }
}
