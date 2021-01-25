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
    public partial class FRMHAREKETLER : Form
    {
        public FRMHAREKETLER()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void Firmaharaketleri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Firmaharaketler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        void MusteriHaraketleri ()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec MUSTERIHARAKETLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void xtraTabControl1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void FRMHAREKETLER_Load(object sender, EventArgs e)
        {
            Firmaharaketleri();
            MusteriHaraketleri();
        }
    }
}
