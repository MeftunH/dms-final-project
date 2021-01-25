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
    public partial class FRMFATURAURUNLER : Form
    {sqlbaglantisi bgl = new sqlbaglantisi();

        public FRMFATURAURUNLER()
        {
            InitializeComponent();
        }
        public string id;
        void listele()
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURADETAY WHERE FATURAID='"+id+"'", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FATURAURUNDUZENLEME FR = new FATURAURUNDUZENLEME();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)

            {
                FR.urunid = dr["FATURAURUNID"].ToString();
            }FR.Show();
        }
        
        private void FRMFATURAURUNLER_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
