using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Otomasyon
{
    public partial class FRMMUSTERILER : Form
    {
        public FRMMUSTERILER()
        {
            InitializeComponent();
            temizle();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from TBL_ILCELER where Sehir=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void FRMMUSTERILER_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERI (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGI) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtadi.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktel1.Text);
            komut.Parameters.AddWithValue("@p4", msktel2.Text);
            komut.Parameters.AddWithValue("@p5",msktc.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7",cmbil.Text);
            komut.Parameters.AddWithValue("@p8", cmbilce.Text);
            komut.Parameters.AddWithValue("@p9", txtadres.Text);
            komut.Parameters.AddWithValue("@p10", txtvergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("MUSTERI SISTEME EKLENDI!", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
            txtid.Text = dr["ID"].ToString();
            txtadi.Text = dr["AD"].ToString();
            txtsoyad.Text = dr["SOYAD"].ToString();
            msktel1.Text = dr["TELEFON"].ToString();
            msktel2.Text = dr["TELEFON2"].ToString();
            msktc.Text = dr["TC"].ToString();
            txtmail.Text =dr["MAIL"].ToString();
            cmbil.Text = dr["IL"].ToString();
            cmbilce.Text = dr["ILCE"].ToString();
            txtvergi.Text = dr["VERGI"].ToString();
            txtadres.Text = dr["ADRES"].ToString();
            }

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From TBL_MUSTERI where ID=@p1", bgl.baglanti());      
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri basariyla silindi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUSTERI set AD=@P1,SOYAD=@P2,TELEFON=@P3,TELEFON2=@P4,TC=@P5,MAIL=@P6,IL=@P7,ILCE=@P8,VERGI=@P9,ADRES=@P10 where ID=@P11", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtadi.Text);
            komut.Parameters.AddWithValue("@P2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@P3", msktel1.Text);
            komut.Parameters.AddWithValue("@P4", msktel2.Text);
            komut.Parameters.AddWithValue("@P5", msktc.Text);
            komut.Parameters.AddWithValue("@P6", txtmail.Text);  
            komut.Parameters.AddWithValue("@P7", cmbil.Text);
            komut.Parameters.AddWithValue("@P8", cmbilce.Text); 
            komut.Parameters.AddWithValue("@P9", txtvergi.Text);
            komut.Parameters.AddWithValue("@P10", txtadres.Text);
            komut.Parameters.Add("@P11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("MUSTERI basariyla guncellendi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
         
        }
        void temizle()
        {
            txtadres.Text = "";
            txtid.Text = "";
            txtvergi.Text = "";
            cmbilce.Text = "";
            cmbil.Text = "";
            txtmail.Text = "";
            msktc.Text = "";
            msktel2.Text = "";
            msktel1.Text = "";
            txtadi.Text = "";
            txtsoyad.Text = "";
        }
        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
