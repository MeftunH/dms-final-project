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
namespace Otomasyon
{
    public partial class FRMNOTLAR : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRMNOTLAR()
        {
            InitializeComponent();
        }

        private void FRMNOTLAR_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txttarih.Text);
            komut.Parameters.AddWithValue("@p2", txtsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtdet.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT SISTEME EKLENDI!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["NOTID"].ToString();
                txttarih.Text = dr["NOTTARIH"].ToString();
                txtsaat.Text = dr["NOTSAAT"].ToString();
                txtbaslik.Text = dr["NOTBASLIK"].ToString();
                txtdet.Text = dr["NOTDETAY"].ToString();
                txtolusturan.Text = dr["NOTOLUSTURAN"].ToString();

            }

        }
        void temizle()
        {
            txtid.Text = "";
            txttarih.Text = "";
            txtsaat.Text = "";
            txtbaslik.Text = "";
            txtolusturan.Text = "";
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["NOTID"].ToString();
                txttarih.Text = dr["NOTTARIH"].ToString();
                txtsaat.Text = dr["NOTSAAT"].ToString();
                txtbaslik.Text = dr["NOTBASLIK"].ToString();
                txtdet.Text = dr["NOTDETAY"].ToString();
                txtolusturan.Text = dr["NOTOLUSTURAN"].ToString();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_NOTLAR where NOTID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT basariyla silindi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set NOTTARIH=@P1,NOTSAAT=@P2,NOTBASLIK=@P3,NOTDETAY=@P4,NOTOLUSTURAN=@P5 where NOTID=@P6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txttarih.Text);
            komut.Parameters.AddWithValue("@p2", txtsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", txtdet.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("NOT GUNCELLENDI!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
           
        }
    }
}
