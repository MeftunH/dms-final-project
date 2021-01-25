namespace Otomasyon
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnurun = new DevExpress.XtraBars.BarButtonItem();
            this.btnstok = new DevExpress.XtraBars.BarButtonItem();
            this.btnmusteri = new DevExpress.XtraBars.BarButtonItem();
            this.btnfirma = new DevExpress.XtraBars.BarButtonItem();
            this.btnanasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.btnpersonal = new DevExpress.XtraBars.BarButtonItem();
            this.btngider = new DevExpress.XtraBars.BarButtonItem();
            this.btnkasa = new DevExpress.XtraBars.BarButtonItem();
            this.btnnotlar = new DevExpress.XtraBars.BarButtonItem();
            this.btnbanka = new DevExpress.XtraBars.BarButtonItem();
            this.btnfatura = new DevExpress.XtraBars.BarButtonItem();
            this.btnayarlar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.btnrehber = new DevExpress.XtraBars.BarButtonItem();
            this.btnharaket = new DevExpress.XtraBars.BarButtonItem();
            this.btnrapor = new DevExpress.XtraBars.BarButtonItem();
            this.OTOMASYON = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnurun,
            this.btnstok,
            this.btnmusteri,
            this.btnfirma,
            this.btnanasayfa,
            this.btnpersonal,
            this.btngider,
            this.btnkasa,
            this.btnnotlar,
            this.btnbanka,
            this.btnfatura,
            this.btnayarlar,
            this.barButtonItem13,
            this.btnrehber,
            this.btnharaket,
            this.btnrapor});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.OTOMASYON});
            this.ribbonControl1.Size = new System.Drawing.Size(1924, 183);
            // 
            // btnurun
            // 
            this.btnurun.Caption = "Urunler";
            this.btnurun.Id = 1;
            this.btnurun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnurun.ImageOptions.Image")));
            this.btnurun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnurun.ImageOptions.LargeImage")));
            this.btnurun.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnurun.ItemAppearance.Normal.Options.UseFont = true;
            this.btnurun.Name = "btnurun";
            this.btnurun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnurun_ItemClick);
            // 
            // btnstok
            // 
            this.btnstok.Caption = "Stok";
            this.btnstok.Id = 2;
            this.btnstok.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnstok.ImageOptions.Image")));
            this.btnstok.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnstok.ImageOptions.LargeImage")));
            this.btnstok.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnstok.ItemAppearance.Normal.Options.UseFont = true;
            this.btnstok.Name = "btnstok";
            this.btnstok.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnmusteri
            // 
            this.btnmusteri.Caption = "Musteriler";
            this.btnmusteri.Id = 3;
            this.btnmusteri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnmusteri.ImageOptions.Image")));
            this.btnmusteri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnmusteri.ImageOptions.LargeImage")));
            this.btnmusteri.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmusteri.ItemAppearance.Normal.Options.UseFont = true;
            this.btnmusteri.Name = "btnmusteri";
            this.btnmusteri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnmusteri_ItemClick);
            // 
            // btnfirma
            // 
            this.btnfirma.Caption = "Firmalar";
            this.btnfirma.Id = 4;
            this.btnfirma.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfirma.ImageOptions.Image")));
            this.btnfirma.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfirma.ImageOptions.LargeImage")));
            this.btnfirma.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirma.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfirma.Name = "btnfirma";
            this.btnfirma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfirma_ItemClick);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.Caption = "Ana Sayfa";
            this.btnanasayfa.Id = 5;
            this.btnanasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.Image")));
            this.btnanasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnanasayfa.ImageOptions.LargeImage")));
            this.btnanasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnanasayfa.Name = "btnanasayfa";
            // 
            // btnpersonal
            // 
            this.btnpersonal.Caption = "Personel";
            this.btnpersonal.Id = 6;
            this.btnpersonal.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnpersonal.ImageOptions.Image")));
            this.btnpersonal.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnpersonal.ImageOptions.LargeImage")));
            this.btnpersonal.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpersonal.ItemAppearance.Normal.Options.UseFont = true;
            this.btnpersonal.Name = "btnpersonal";
            this.btnpersonal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnpersonal_ItemClick);
            // 
            // btngider
            // 
            this.btngider.Caption = "Giderler";
            this.btngider.Id = 7;
            this.btngider.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngider.ImageOptions.Image")));
            this.btngider.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btngider.ImageOptions.LargeImage")));
            this.btngider.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngider.ItemAppearance.Normal.Options.UseFont = true;
            this.btngider.Name = "btngider";
            this.btngider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngider_ItemClick);
            // 
            // btnkasa
            // 
            this.btnkasa.Caption = "Kasa";
            this.btnkasa.Id = 8;
            this.btnkasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.Image")));
            this.btnkasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnkasa.ImageOptions.LargeImage")));
            this.btnkasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkasa.ItemAppearance.Normal.Options.UseFont = true;
            this.btnkasa.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkasa.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnkasa.Name = "btnkasa";
            // 
            // btnnotlar
            // 
            this.btnnotlar.Caption = "Notlar";
            this.btnnotlar.Id = 10;
            this.btnnotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.Image")));
            this.btnnotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnnotlar.ImageOptions.LargeImage")));
            this.btnnotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnnotlar.Name = "btnnotlar";
            this.btnnotlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnnotlar_ItemClick);
            // 
            // btnbanka
            // 
            this.btnbanka.Caption = "Bankalar";
            this.btnbanka.Id = 11;
            this.btnbanka.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbanka.ImageOptions.Image")));
            this.btnbanka.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnbanka.ImageOptions.LargeImage")));
            this.btnbanka.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanka.ItemAppearance.Normal.Options.UseFont = true;
            this.btnbanka.Name = "btnbanka";
            this.btnbanka.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnbanka_ItemClick);
            // 
            // btnfatura
            // 
            this.btnfatura.Caption = "Faturalar";
            this.btnfatura.Id = 12;
            this.btnfatura.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfatura.ImageOptions.Image")));
            this.btnfatura.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnfatura.ImageOptions.LargeImage")));
            this.btnfatura.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfatura.ItemAppearance.Normal.Options.UseFont = true;
            this.btnfatura.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfatura.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnfatura.Name = "btnfatura";
            this.btnfatura.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnfatura_ItemClick);
            // 
            // btnayarlar
            // 
            this.btnayarlar.Caption = "Ayarlar";
            this.btnayarlar.Id = 13;
            this.btnayarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.Image")));
            this.btnayarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnayarlar.ImageOptions.LargeImage")));
            this.btnayarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnayarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.btnayarlar.Name = "btnayarlar";
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Hareketler";
            this.barButtonItem13.Id = 14;
            this.barButtonItem13.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem13.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem13.Name = "barButtonItem13";
            // 
            // btnrehber
            // 
            this.btnrehber.Caption = "Rehber";
            this.btnrehber.Id = 15;
            this.btnrehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.Image")));
            this.btnrehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnrehber.ImageOptions.LargeImage")));
            this.btnrehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrehber.ItemAppearance.Normal.Options.UseFont = true;
            this.btnrehber.Name = "btnrehber";
            this.btnrehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // btnharaket
            // 
            this.btnharaket.Caption = "Hareketler";
            this.btnharaket.Id = 16;
            this.btnharaket.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnharaket.ImageOptions.Image")));
            this.btnharaket.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnharaket.ImageOptions.LargeImage")));
            this.btnharaket.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnharaket.ItemAppearance.Disabled.Options.UseFont = true;
            this.btnharaket.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnharaket.ItemAppearance.Normal.Options.UseFont = true;
            this.btnharaket.Name = "btnharaket";
            this.btnharaket.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnharaket_ItemClick);
            // 
            // btnrapor
            // 
            this.btnrapor.Caption = "Raporlar";
            this.btnrapor.Id = 17;
            this.btnrapor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnrapor.ImageOptions.Image")));
            this.btnrapor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnrapor.ImageOptions.LargeImage")));
            this.btnrapor.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrapor.ItemAppearance.Normal.Options.UseFont = true;
            this.btnrapor.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrapor.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.btnrapor.Name = "btnrapor";
            // 
            // OTOMASYON
            // 
            this.OTOMASYON.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.OTOMASYON.Name = "OTOMASYON";
            this.OTOMASYON.Text = "OTOMASYON";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnanasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnurun);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnstok);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnmusteri);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfirma);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnpersonal);
            this.ribbonPageGroup1.ItemLinks.Add(this.btngider);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnkasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnnotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnbanka);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnrehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnfatura);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnayarlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnharaket);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnrapor);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage OTOMASYON;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnurun;
        private DevExpress.XtraBars.BarButtonItem btnstok;
        private DevExpress.XtraBars.BarButtonItem btnmusteri;
        private DevExpress.XtraBars.BarButtonItem btnfirma;
        private DevExpress.XtraBars.BarButtonItem btnanasayfa;
        private DevExpress.XtraBars.BarButtonItem btnpersonal;
        private DevExpress.XtraBars.BarButtonItem btngider;
        private DevExpress.XtraBars.BarButtonItem btnkasa;
        private DevExpress.XtraBars.BarButtonItem btnnotlar;
        private DevExpress.XtraBars.BarButtonItem btnbanka;
        private DevExpress.XtraBars.BarButtonItem btnfatura;
        private DevExpress.XtraBars.BarButtonItem btnayarlar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.BarButtonItem btnrehber;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnharaket;
        private DevExpress.XtraBars.BarButtonItem btnrapor;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

