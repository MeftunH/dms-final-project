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
    public partial class FRMFIRMALAR : Form
    {
        public FRMFIRMALAR()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmalistele()
        {
         
            SqlDataAdapter da = new SqlDataAdapter("Select * From FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txad.Text = "";
            txgorev.Text = "";
            txid.Text = "";
            txtyetkiliadsoyad.Text = "";
            txtc.Text = "";
            txsektor.Text = "";
            msktel.Text = "";
            msktel2.Text = "";
            txmail.Text = "";
            mskfax.Text = "";
            txilce.Text = "";
            txil.Text = "";
            txvergi.Text = "";
            txadres.Text = "";
            txok1.Text = "";
            txok2.Text = "";
            txok3.Text = "";


        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        void carikodaciklamalar()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR", bgl.baglanti());
            SqlDataReader DR = komut.ExecuteReader();
            while(DR.Read())
            {
                rchok1.Text = DR[0].ToString();

            }
            bgl.baglanti().Close();
        }
        private void FRMFIRMALAR_Load(object sender, EventArgs e)
        {
            firmalistele();
            sehirlistesi();
            carikodaciklamalar();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txid.Text = dr["ID"].ToString();
                txad.Text = dr["AD"].ToString();
                txgorev.Text = dr["YETKILISTATU"].ToString();
                txtyetkiliadsoyad.Text = dr["YETKILIADSOYAD"].ToString();
                txtc.Text = dr["YETKILITC"].ToString();
                txsektor.Text = dr["SEKTOR"].ToString();
                msktel.Text = dr["TELEFON1"].ToString();
                msktel2.Text = dr["TELEFON2"].ToString();
                mskfax.Text = dr["FAX"].ToString();
                txmail.Text = dr["MAIL"].ToString();
                txil.Text = dr["IL"].ToString();
                txilce.Text = dr["ILCE"].ToString();
                txvergi.Text = dr["VERGI"].ToString();
                txadres.Text = dr["ADRES"].ToString();
                txok1.Text = dr["OZELKOD1"].ToString();
                txok2.Text = dr["OZELKOD2"].ToString();
                txok3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,FAX,MAIL,IL,ILCE,VERGI,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txyetkiyili.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkiliadsoyad.Text);
            komut.Parameters.AddWithValue("@p4", txtc.Text);
            komut.Parameters.AddWithValue("@p5", txsektor.Text);
            komut.Parameters.AddWithValue("@p6", msktel.Text);
            komut.Parameters.AddWithValue("@p7", msktel2.Text);
            komut.Parameters.AddWithValue("@p8", mskfax.Text);
            komut.Parameters.AddWithValue("@p9", txmail.Text);
            komut.Parameters.AddWithValue("@p10", txil.Text);
            komut.Parameters.AddWithValue("@p11", txilce.Text);
            komut.Parameters.AddWithValue("@p12", txvergi.Text);
            komut.Parameters.AddWithValue("@p13", txadres.Text);
            komut.Parameters.AddWithValue("@p14", txok1.Text);
            komut.Parameters.AddWithValue("@p15", txok2.Text);
            komut.Parameters.AddWithValue("@p16", txok3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma sisteme basariyla kaydedildi!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();

        }

        private void txil_SelectedIndexChanged(object sender, EventArgs e)
        {
            txilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From FIRMALAR where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            firmalistele();
            MessageBox.Show("Firma basariyla silindi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update FIRMALAR set AD=@P1,YETKILISTATU=@P2,YETKILIADSOYAD=@P3,YETKILITC=@P4,SEKTOR=@P5,TELEFON1=@P6,TELEFON2=@P7,MAIL=@P8,FAX=@P9,IL=@P10,ILCE=@P11,VERGI=@P12,ADRES=@P13,OZELKOD1=@P14,OZELKOD2=@P15,OZELKOD3=@P16 where ID=@P17", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txad.Text);
            komut.Parameters.AddWithValue("@P2", txyetkiyili.Text);
            komut.Parameters.AddWithValue("@P3", txtyetkiliadsoyad.Text);
            komut.Parameters.AddWithValue("@P4", txtc.Text);
            komut.Parameters.AddWithValue("@P5", txsektor.Text);
            komut.Parameters.AddWithValue("@P6", msktel.Text);
            komut.Parameters.AddWithValue("@P7", msktel2.Text);
            komut.Parameters.AddWithValue("@P8", txmail.Text);
            komut.Parameters.AddWithValue("@P9", mskfax.Text);
            komut.Parameters.AddWithValue("@P10", txil.Text);
            komut.Parameters.AddWithValue("@P11", txilce.Text);
            komut.Parameters.AddWithValue("@P12", txvergi.Text);
            komut.Parameters.AddWithValue("@P13", txadres.Text);
            komut.Parameters.AddWithValue("@P14", txok1.Text);
            komut.Parameters.AddWithValue("@P15", txok2.Text);
            komut.Parameters.AddWithValue("@P16", txok3.Text);
            komut.Parameters.AddWithValue("@P17", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma bilgileri guncellendi!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistele();
            temizle();
        }
    }
}
