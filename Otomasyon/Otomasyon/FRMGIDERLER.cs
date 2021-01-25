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
    public partial class FRMGIDERLER : Form
    {
        public FRMGIDERLER()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void giderlistele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FRMGIDERLER_Load(object sender, EventArgs e)
        {
            giderlistele();
            TEMIZLE();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CMBAY.Text);
            komut.Parameters.AddWithValue("@p2", CMBYIL.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtelek.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdg.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtint.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtekstra.Text));
            komut.Parameters.AddWithValue("@p9", txtnot.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GIDERLER KAYDEDILDI!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistele();
            TEMIZLE();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_GIDERLER set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CMBAY.Text);
            komut.Parameters.AddWithValue("@p2", CMBYIL.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtelek.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdg.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtint.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtmaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtekstra.Text));
            komut.Parameters.AddWithValue("@p9", txtnot.Text);
            komut.Parameters.Add("@P10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider basariyla guncellendi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           giderlistele();
            TEMIZLE();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }
        void TEMIZLE()
        {
            CMBAY.Text = "";
            CMBYIL.Text = "";
            txtelek.Text = "";
            txtsu.Text = "";
            txtdg.Text = "";
            txtint.Text = "";
            txtmaas.Text = "";
            txtekstra.Text = "";
            txtnot.Text = "";
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtid.Text = dr["ID"].ToString();
                CMBAY.Text = dr["AY"].ToString();
                CMBYIL.Text = dr["YIL"].ToString();
                txtelek.Text = dr["ELEKTRIK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtdg.Text = dr["DOGALGAZ"].ToString();
                txtint.Text = dr["INTERNET"].ToString();
                txtmaas.Text = dr["MAASLAR"].ToString();
                txtekstra.Text = dr["EKSTRA"].ToString();
                txtnot.Text = dr["NOTLAR"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            TEMIZLE();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("GIDER basariyla silindi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          giderlistele();
            TEMIZLE();
        }
    }
}
