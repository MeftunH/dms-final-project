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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        FRMSTOKLAR frS;
    
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frS == null)
            {
                frS = new FRMSTOKLAR();
                frS.MdiParent = this;
                frS.Show();
            }

        }
        FRMGIDERLER frgider;
        FRMREHBER fr5;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr5 == null)
            {
                fr5 = new FRMREHBER();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }
        public void  verigoster(String veri)
        {
            
        }
        FRMURUNLER fr;
        
        private void btnurun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FRMURUNLER();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        FRMMUSTERILER frm;
        private void btnmusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null)
            {
                frm = new FRMMUSTERILER();
                frm.MdiParent = this;
                frm.Show();
            }
        }
        FRMFIRMALAR frmfirmalar;
        private void btnfirma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmfirmalar == null)
            {
                frmfirmalar = new FRMFIRMALAR();
                frmfirmalar.MdiParent = this;
                frmfirmalar.Show();
            }
        }
        FRMPERSONEL fr4;
        private void btnpersonal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new FRMPERSONEL();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        private void btngider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgider == null)
            {
                frgider = new FRMGIDERLER();
                frgider.MdiParent = this;
                frgider.Show();
            }
        }
        FRMBANKALAR frbanka;
        private void btnbanka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frbanka == null)
            {
                frbanka = new FRMBANKALAR();
                frbanka.MdiParent = this;
                frbanka.Show();
            }
        }

        frmFATURALAR fr8;
        private void btnfatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr8 == null)
            {
                fr8 = new frmFATURALAR();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }
        FRMNOTLAR fr9;
        private void btnnotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr9 == null)
            {
                fr9 = new FRMNOTLAR();
                fr9.MdiParent = this;
                fr9.Show();
            }
        }
        FRMHAREKETLER frn;
        private void btnharaket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frn == null)
            {
                frn = new FRMHAREKETLER();
                frn.MdiParent = this;
                frn.Show();
            }
        }
    }
}
