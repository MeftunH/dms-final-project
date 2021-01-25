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
    public partial class FATURAURUNDUZENLEME : Form
    {
        public FATURAURUNDUZENLEME()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FATURAURUNDUZENLEME_Load(object sender, EventArgs e)
        {
            txturunid.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FaturaUrunID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())

            {
                txtfiyat.Text = dr[3].ToString();
                txtmiktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                txturunad.Text = dr[1].ToString();
                bgl.baglanti().Close();
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  TBL_FATURADETAY SET URUNAD=@P1,MIKTAR=@P2,FIYAT=@P3,TUTAR=@P4 WHERE FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p5", txturunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Degisiklikler kaydedildi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Degisiklikler kaydedildi", "BILGI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
