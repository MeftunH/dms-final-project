namespace Otomasyon
{
    partial class FRMURUNLER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMURUNLER));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.txtyil = new System.Windows.Forms.MaskedTextBox();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtdetay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtsatisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtalisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtadet = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtmodel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtmarka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.kdvdegerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBotomasyonDataSet = new Otomasyon.DBotomasyonDataSet();
            this.btnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.kdvdegerTableAdapter = new Otomasyon.DBotomasyonDataSetTableAdapters.KdvdegerTableAdapter();
            this.dBotomasyonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kdvdegerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBotomasyonDataSet1 = new Otomasyon.DBotomasyonDataSet();
            this.dBotomasyonDataSet11 = new Otomasyon.DBotomasyonDataSet1();
            this.uRUNBILGISIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uRUN_BILGISITableAdapter = new Otomasyon.DBotomasyonDataSet1TableAdapters.URUN_BILGISITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvdegerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvdegerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBILGISIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(730, 681);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btntemizle);
            this.groupControl1.Controls.Add(this.txtyil);
            this.groupControl1.Controls.Add(this.btnsil);
            this.groupControl1.Controls.Add(this.btnkaydet);
            this.groupControl1.Controls.Add(this.txtdetay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtsatisfiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtalisfiyat);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtadet);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtmodel);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtmarka);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtadi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtid);
            this.groupControl1.Location = new System.Drawing.Point(737, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1200, 1200);
            this.groupControl1.TabIndex = 1;
            // 
            // btntemizle
            // 
            this.btntemizle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btntemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntemizle.Appearance.Options.UseBackColor = true;
            this.btntemizle.Appearance.Options.UseFont = true;
            this.btntemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntemizle.ImageOptions.Image")));
            this.btntemizle.Location = new System.Drawing.Point(54, 659);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(179, 57);
            this.btntemizle.TabIndex = 36;
            this.btntemizle.Text = "TEMIZLE";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // txtyil
            // 
            this.txtyil.Location = new System.Drawing.Point(76, 213);
            this.txtyil.Mask = "0000";
            this.txtyil.Name = "txtyil";
            this.txtyil.Size = new System.Drawing.Size(125, 23);
            this.txtyil.TabIndex = 22;
            this.txtyil.ValidatingType = typeof(int);
            // 
            // btnsil
            // 
            this.btnsil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Appearance.Options.UseBackColor = true;
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(54, 521);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(179, 57);
            this.btnsil.TabIndex = 22;
            this.btnsil.Text = "SIL";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnkaydet.Appearance.Options.UseBackColor = true;
            this.btnkaydet.Appearance.Options.UseFont = true;
            this.btnkaydet.Appearance.Options.UseForeColor = true;
            this.btnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.ImageOptions.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(54, 458);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(179, 57);
            this.btnkaydet.TabIndex = 21;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtdetay
            // 
            this.txtdetay.Location = new System.Drawing.Point(81, 374);
            this.txtdetay.Name = "txtdetay";
            this.txtdetay.Size = new System.Drawing.Size(125, 78);
            this.txtdetay.TabIndex = 20;
            this.txtdetay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 252);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(36, 16);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "ADET:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(0, 335);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(75, 16);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "SATISFIYAT:";
            // 
            // txtsatisfiyat
            // 
            this.txtsatisfiyat.Location = new System.Drawing.Point(81, 329);
            this.txtsatisfiyat.Name = "txtsatisfiyat";
            this.txtsatisfiyat.Size = new System.Drawing.Size(125, 22);
            this.txtsatisfiyat.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 289);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "ALISFIYAT:";
            // 
            // txtalisfiyat
            // 
            this.txtalisfiyat.Location = new System.Drawing.Point(81, 286);
            this.txtalisfiyat.Name = "txtalisfiyat";
            this.txtalisfiyat.Size = new System.Drawing.Size(125, 22);
            this.txtalisfiyat.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 374);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 16);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "DETAY:";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(81, 250);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(120, 23);
            this.txtadet.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 171);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "MODEL:";
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(76, 168);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(125, 22);
            this.txtmodel.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 216);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(22, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "YIL:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "MARKA:";
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(76, 127);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(125, 22);
            this.txtmarka.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "AD:";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(76, 82);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(125, 22);
            this.txtadi.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(76, 36);
            this.txtid.Name = "txtid";
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(125, 22);
            this.txtid.TabIndex = 0;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Otomasyon.Properties.Settings.DBotomasyonConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "Kdvdeger";
            queryParameter1.Name = "@FIYAT";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("0", typeof(int));
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "Kdvdeger";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZTEiPjxWaWV3IE5hbWU9IktkdmRlZ2VyIiAvPjwvRGF0Y" +
    "VNldD4=";
            // 
            // kdvdegerBindingSource
            // 
            this.kdvdegerBindingSource.DataMember = "Kdvdeger";
            this.kdvdegerBindingSource.DataSource = this.dBotomasyonDataSet;
            // 
            // dBotomasyonDataSet
            // 
            this.dBotomasyonDataSet.DataSetName = "DBotomasyonDataSet";
            this.dBotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnguncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.Appearance.Options.UseBackColor = true;
            this.btnguncelle.Appearance.Options.UseFont = true;
            this.btnguncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnguncelle.ImageOptions.Image")));
            this.btnguncelle.Location = new System.Drawing.Point(791, 596);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(179, 57);
            this.btnguncelle.TabIndex = 23;
            this.btnguncelle.Text = "GUNCELLE";
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // kdvdegerTableAdapter
            // 
            this.kdvdegerTableAdapter.ClearBeforeFill = true;
            // 
            // dBotomasyonDataSetBindingSource
            // 
            this.dBotomasyonDataSetBindingSource.DataSource = this.dBotomasyonDataSet;
            this.dBotomasyonDataSetBindingSource.Position = 0;
            // 
            // kdvdegerBindingSource1
            // 
            this.kdvdegerBindingSource1.DataMember = "Kdvdeger";
            this.kdvdegerBindingSource1.DataSource = this.dBotomasyonDataSetBindingSource;
            // 
            // dBotomasyonDataSet1
            // 
            this.dBotomasyonDataSet1.DataSetName = "DBotomasyonDataSet";
            this.dBotomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBotomasyonDataSet11
            // 
            this.dBotomasyonDataSet11.DataSetName = "DBotomasyonDataSet1";
            this.dBotomasyonDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNBILGISIBindingSource
            // 
            this.uRUNBILGISIBindingSource.DataMember = "URUN_BILGISI";
            this.uRUNBILGISIBindingSource.DataSource = this.dBotomasyonDataSet11;
            // 
            // uRUN_BILGISITableAdapter
            // 
            this.uRUN_BILGISITableAdapter.ClearBeforeFill = true;
            // 
            // FRMURUNLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FRMURUNLER";
            this.Text = "FRMURUNLER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMURUNLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsatisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtalisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmodel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvdegerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdvdegerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBotomasyonDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNBILGISIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RichTextBox txtdetay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtsatisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtalisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.NumericUpDown txtadet;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtmodel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtmarka;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.MaskedTextBox txtyil;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnguncelle;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private System.Windows.Forms.BindingSource kdvdegerBindingSource;
        private DBotomasyonDataSet dBotomasyonDataSet;
        private DBotomasyonDataSetTableAdapters.KdvdegerTableAdapter kdvdegerTableAdapter;
        private System.Windows.Forms.BindingSource kdvdegerBindingSource1;
        private System.Windows.Forms.BindingSource dBotomasyonDataSetBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DBotomasyonDataSet dBotomasyonDataSet1;
        private System.Windows.Forms.BindingSource uRUNBILGISIBindingSource;
        private DBotomasyonDataSet1 dBotomasyonDataSet11;
        private DBotomasyonDataSet1TableAdapters.URUN_BILGISITableAdapter uRUN_BILGISITableAdapter;
    }
}