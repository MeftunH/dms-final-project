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
    public partial class frmFATURALAR : Form
    {
        public frmFATURALAR()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txid.Text = "";
            txteden.Text = "";
            txtalici.Text = "";
            txtseri.Text = "";
            txtsirano.Text = "";
            txtarih.Text = "";
            txtsirano.Text = "";
            txttalan.Text = "";
            txtvergi.Text = "";
            txtsaat.Text = "";
        }
        private void frmFATURALAR_Load(object sender, EventArgs e)
        {
            listele();
            temizle();

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtfaturaid.Text == "")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SIRA,SIRANO,TARIH,SAAT,VERGI,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtseri.Text);
                komut.Parameters.AddWithValue("@p2", txtsirano.Text);
                komut.Parameters.AddWithValue("@p3", txtarih.Text);
                komut.Parameters.AddWithValue("@p4", txtsaat.Text);
                komut.Parameters.AddWithValue("@p5", txtvergi.Text);
                komut.Parameters.AddWithValue("@p6", txtalici.Text);
                komut.Parameters.AddWithValue("@p7", txteden.Text);
                komut.Parameters.AddWithValue("@p8", txttalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura sisteme basariyla kaydedildi!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            if (txtfaturaid.Text!= "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();
                SqlCommand komut = new SqlCommand("insert into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txturunad.Text);
                komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
                komut.Parameters.AddWithValue("@p3", txtfiyat.Text);
                komut.Parameters.AddWithValue("@p4", txttutar.Text);
                komut.Parameters.AddWithValue("@p5", txtfaturaid.Text);
           
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura ait urun basariyla kaydedildi!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FRMFATURAURUNLER fr = new FRMFATURAURUNLER();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
                
            }
            fr.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["FATURABILGIID"].ToString();
                txtsirano.Text = dr["SIRANO"].ToString();
                txtseri.Text = dr["SIRA"].ToString();
                txtarih.Text = dr["TARIH"].ToString();
                txtsaat.Text = dr["SAAT"].ToString();
                txtalici.Text = dr["VERGI"].ToString();
                txteden.Text = dr["ALICI"].ToString();
                txttalan.Text = dr["TESLIMEDEN"].ToString();
                txtvergi.Text = dr["TESLIMALAN"].ToString();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("FATURA basariyla silindi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI set SIRA=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGI=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 where FATURABILGIID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtseri.Text);
            komut.Parameters.AddWithValue("@p2", txtsirano.Text);
            komut.Parameters.AddWithValue("@p3", txtarih.Text);
            komut.Parameters.AddWithValue("@p4", txtsaat.Text);
            komut.Parameters.AddWithValue("@p5", txtvergi.Text);
            komut.Parameters.AddWithValue("@p6", txtalici.Text);
            komut.Parameters.AddWithValue("@p7", txteden.Text);
            komut.Parameters.AddWithValue("@p8", txttalan.Text);
            komut.Parameters.AddWithValue("@p9", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura bilgisi basariyla Guncellendi!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

    }
}



