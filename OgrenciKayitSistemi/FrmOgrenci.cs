using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace OgrenciKayitSistemi
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kk.OgrenciListesi();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kk.OgrenciGuncelle(txtAdi.Text, txtSoyadi.Text, byte.Parse(cmbKulubu.SelectedValue.ToString()), c, int.Parse(txtDersID.Text));
            MessageBox.Show("Bilgiler Güncellendi");
        }
       string c = "";
       private void btnEkle_Click(object sender, EventArgs e)
        {
            kk.OgrenciEkleme(txtAdi.Text, txtSoyadi.Text, byte.Parse(cmbKulubu.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme Yapıldı.");
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            kk.OgrenciSil(int.Parse(txtDersID.Text));
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-864OGI4\SQLEXPRESS;Initial Catalog=DB_OgrenciKayitSistemi;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter kk = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kk.OgrenciListesi();
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kulupler", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulubu.DisplayMember = "kulupAd";
            cmbKulubu.ValueMember = "kulupID";
            cmbKulubu.DataSource = dt;
            bgl.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersID.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void cmbKulubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtDersID.Text = cmbKulubu.SelectedValue.ToString();
        }
        private void rdbKiz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz.Checked == true)
                c = "Kız";
            if (rdbErkek.Checked == true)
                c = "Erkek";
        }
        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKiz.Checked == true)
                c = "Kız";
            if (rdbErkek.Checked == true)
                c = "Erkek";
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=kk.OgrenciGetir(txtArama.Text);
        }
    }
}
