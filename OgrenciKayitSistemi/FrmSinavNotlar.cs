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
namespace OgrenciKayitSistemi
{
    public partial class FrmSinavNotlar : Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOgrenciID.Text));
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int notID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notID= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());           
            txtOgrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSinav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSinav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSinav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-864OGI4\SQLEXPRESS;Initial Catalog=DB_OgrenciKayitSistemi;Integrated Security=True");
        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {           
            bgl.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Dersler", bgl);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "dersAd";
            cmbDers.ValueMember = "dersID";
            cmbDers.DataSource = dt;
            bgl.Close();
        }
       
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje;
            double ortalama;
            sinav1 =Convert.ToDouble(txtSinav1.Text);
            sinav2 =Convert.ToDouble(txtSinav2.Text);
            sinav3 =Convert.ToDouble(txtSinav3.Text);
            proje = Convert.ToDouble(txtProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama>=50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(byte.Parse(cmbDers.SelectedValue.ToString()),int.Parse(txtOgrenciID.Text),byte.Parse(txtSinav1.Text), byte.Parse(txtSinav2.Text), byte.Parse(txtSinav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrtalama.Text),bool.Parse(txtDurum.Text),notID);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
