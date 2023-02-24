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
namespace OgrenciKayitSistemi
{
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-864OGI4\SQLEXPRESS;Initial Catalog=DB_OgrenciKayitSistemi;Integrated Security=True");
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Kulupler",bgl);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kulupler (kulupAd) values (@p1)",bgl);
            komut.Parameters.AddWithValue("@p1",txtKulupAdi.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Eklendi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            liste();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.GreenYellow;
        }
        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulupID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulupAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Kulupler where kulupID=@p1", bgl);
            komut.Parameters.AddWithValue("@p1", txtKulupID.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kulüp Silme İşlemi Başarılı");
            liste();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Kulupler set kulupAd=@p1 where kulupID=@p2", bgl);
            komut.Parameters.AddWithValue("@p1", txtKulupAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtKulupID.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("1 ROWS EFFECTED");
            liste();
        }      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
