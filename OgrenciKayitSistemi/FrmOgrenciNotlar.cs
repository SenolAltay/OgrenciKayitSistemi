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
    public partial class FrmOgrenciNotlar : Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-864OGI4\SQLEXPRESS;Initial Catalog=DB_OgrenciKayitSistemi;Integrated Security=True");
        public string numara;
        public string ad;
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select dersAd,sınav1,sınav2,sınav2,proje,ortalama,durum from Tbl_Notlar\r\ninner join Tbl_Dersler on Tbl_Notlar.dersID=Tbl_Dersler.dersID where ogrID=@p1", bgl);
            komut.Parameters.AddWithValue("@p1",numara);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource= dt;
           // this.Text = ad.ToString();
        }
    }
}
