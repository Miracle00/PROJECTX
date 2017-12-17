namespace YS_PROJECT
{
    partial class DemirbasAtama
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasAtama));
            this.btn_sec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dd_fakulteler = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.dd_odalar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_departmanlar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_demirbasTur = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_demirbaslar = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_stokMiktari = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_demirbasEkle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_adet = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sec
            // 
            this.btn_sec.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sec.BorderRadius = 0;
            this.btn_sec.ButtonText = "SEÇ";
            this.btn_sec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sec.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sec.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sec.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sec.Iconimage")));
            this.btn_sec.Iconimage_right = null;
            this.btn_sec.Iconimage_right_Selected = null;
            this.btn_sec.Iconimage_Selected = null;
            this.btn_sec.IconMarginLeft = 0;
            this.btn_sec.IconMarginRight = 0;
            this.btn_sec.IconRightVisible = true;
            this.btn_sec.IconRightZoom = 0D;
            this.btn_sec.IconVisible = true;
            this.btn_sec.IconZoom = 90D;
            this.btn_sec.IsTab = false;
            this.btn_sec.Location = new System.Drawing.Point(681, 45);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_sec.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sec.selected = false;
            this.btn_sec.Size = new System.Drawing.Size(199, 43);
            this.btn_sec.TabIndex = 82;
            this.btn_sec.Text = "SEÇ";
            this.btn_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sec.Textcolor = System.Drawing.Color.White;
            this.btn_sec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // dd_fakulteler
            // 
            this.dd_fakulteler.BackColor = System.Drawing.Color.White;
            this.dd_fakulteler.BorderRadius = 3;
            this.dd_fakulteler.DisabledColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_fakulteler.ForeColor = System.Drawing.Color.White;
            this.dd_fakulteler.Items = new string[0];
            this.dd_fakulteler.Location = new System.Drawing.Point(18, 45);
            this.dd_fakulteler.Margin = new System.Windows.Forms.Padding(7);
            this.dd_fakulteler.Name = "dd_fakulteler";
            this.dd_fakulteler.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_fakulteler.onHoverColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.selectedIndex = -1;
            this.dd_fakulteler.Size = new System.Drawing.Size(215, 43);
            this.dd_fakulteler.TabIndex = 83;
            this.dd_fakulteler.onItemSelected += new System.EventHandler(this.dd_fakulteler_onItemSelected);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(18, 3);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(862, 12);
            this.bunifuSeparator3.TabIndex = 81;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(18, 94);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(862, 20);
            this.bunifuSeparator4.TabIndex = 80;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // dd_odalar
            // 
            this.dd_odalar.BackColor = System.Drawing.Color.White;
            this.dd_odalar.BorderRadius = 3;
            this.dd_odalar.DisabledColor = System.Drawing.Color.Gray;
            this.dd_odalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_odalar.ForeColor = System.Drawing.Color.White;
            this.dd_odalar.Items = new string[0];
            this.dd_odalar.Location = new System.Drawing.Point(460, 45);
            this.dd_odalar.Name = "dd_odalar";
            this.dd_odalar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_odalar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_odalar.selectedIndex = -1;
            this.dd_odalar.Size = new System.Drawing.Size(215, 43);
            this.dd_odalar.TabIndex = 79;
            this.dd_odalar.onItemSelected += new System.EventHandler(this.dd_odalar_onItemSelected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(456, 18);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel3.TabIndex = 78;
            this.bunifuCustomLabel3.Text = "ODA İSMİ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 24);
            this.bunifuCustomLabel1.TabIndex = 77;
            this.bunifuCustomLabel1.Text = "DEPARTMAN İSMİ";
            // 
            // dd_departmanlar
            // 
            this.dd_departmanlar.BackColor = System.Drawing.Color.White;
            this.dd_departmanlar.BorderRadius = 3;
            this.dd_departmanlar.DisabledColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_departmanlar.ForeColor = System.Drawing.Color.White;
            this.dd_departmanlar.Items = new string[0];
            this.dd_departmanlar.Location = new System.Drawing.Point(239, 45);
            this.dd_departmanlar.Name = "dd_departmanlar";
            this.dd_departmanlar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_departmanlar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.selectedIndex = -1;
            this.dd_departmanlar.Size = new System.Drawing.Size(215, 43);
            this.dd_departmanlar.TabIndex = 76;
            this.dd_departmanlar.onItemSelected += new System.EventHandler(this.dd_departmanlar_onItemSelected);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 18);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(136, 24);
            this.bunifuCustomLabel7.TabIndex = 84;
            this.bunifuCustomLabel7.Text = "FAKÜLTE İSMİ";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(14, 126);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(162, 24);
            this.bunifuCustomLabel2.TabIndex = 86;
            this.bunifuCustomLabel2.Text = "DEMİRBAS TURU";
            // 
            // dd_demirbasTur
            // 
            this.dd_demirbasTur.BackColor = System.Drawing.Color.White;
            this.dd_demirbasTur.BorderRadius = 3;
            this.dd_demirbasTur.DisabledColor = System.Drawing.Color.Gray;
            this.dd_demirbasTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_demirbasTur.ForeColor = System.Drawing.Color.White;
            this.dd_demirbasTur.Items = new string[0];
            this.dd_demirbasTur.Location = new System.Drawing.Point(18, 153);
            this.dd_demirbasTur.Margin = new System.Windows.Forms.Padding(7);
            this.dd_demirbasTur.Name = "dd_demirbasTur";
            this.dd_demirbasTur.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_demirbasTur.onHoverColor = System.Drawing.Color.Gray;
            this.dd_demirbasTur.selectedIndex = -1;
            this.dd_demirbasTur.Size = new System.Drawing.Size(215, 43);
            this.dd_demirbasTur.TabIndex = 85;
            this.dd_demirbasTur.onItemSelected += new System.EventHandler(this.dd_demirbasTur_onItemSelected);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(14, 207);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(141, 24);
            this.bunifuCustomLabel4.TabIndex = 88;
            this.bunifuCustomLabel4.Text = "DEMİRBAS ADI";
            // 
            // dd_demirbaslar
            // 
            this.dd_demirbaslar.BackColor = System.Drawing.Color.White;
            this.dd_demirbaslar.BorderRadius = 3;
            this.dd_demirbaslar.DisabledColor = System.Drawing.Color.Gray;
            this.dd_demirbaslar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_demirbaslar.ForeColor = System.Drawing.Color.White;
            this.dd_demirbaslar.Items = new string[0];
            this.dd_demirbaslar.Location = new System.Drawing.Point(18, 234);
            this.dd_demirbaslar.Margin = new System.Windows.Forms.Padding(7);
            this.dd_demirbaslar.Name = "dd_demirbaslar";
            this.dd_demirbaslar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_demirbaslar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_demirbaslar.selectedIndex = -1;
            this.dd_demirbaslar.Size = new System.Drawing.Size(215, 43);
            this.dd_demirbaslar.TabIndex = 87;
            this.dd_demirbaslar.onItemSelected += new System.EventHandler(this.dd_demirbaslar_onItemSelected);
            // 
            // txt_stokMiktari
            // 
            this.txt_stokMiktari.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_stokMiktari.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_stokMiktari.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_stokMiktari.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_stokMiktari.BorderThickness = 3;
            this.txt_stokMiktari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stokMiktari.Enabled = false;
            this.txt_stokMiktari.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_stokMiktari.ForeColor = System.Drawing.Color.White;
            this.txt_stokMiktari.isPassword = false;
            this.txt_stokMiktari.Location = new System.Drawing.Point(18, 321);
            this.txt_stokMiktari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stokMiktari.Name = "txt_stokMiktari";
            this.txt_stokMiktari.Size = new System.Drawing.Size(126, 43);
            this.txt_stokMiktari.TabIndex = 90;
            this.txt_stokMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(18, 296);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(120, 20);
            this.bunifuCustomLabel6.TabIndex = 89;
            this.bunifuCustomLabel6.Text = "STOK MİKTARI";
            // 
            // btn_demirbasEkle
            // 
            this.btn_demirbasEkle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_demirbasEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_demirbasEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_demirbasEkle.BorderRadius = 0;
            this.btn_demirbasEkle.ButtonText = "EKLE";
            this.btn_demirbasEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_demirbasEkle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_demirbasEkle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_demirbasEkle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_demirbasEkle.Iconimage")));
            this.btn_demirbasEkle.Iconimage_right = null;
            this.btn_demirbasEkle.Iconimage_right_Selected = null;
            this.btn_demirbasEkle.Iconimage_Selected = null;
            this.btn_demirbasEkle.IconMarginLeft = 0;
            this.btn_demirbasEkle.IconMarginRight = 0;
            this.btn_demirbasEkle.IconRightVisible = true;
            this.btn_demirbasEkle.IconRightZoom = 0D;
            this.btn_demirbasEkle.IconVisible = true;
            this.btn_demirbasEkle.IconZoom = 90D;
            this.btn_demirbasEkle.IsTab = false;
            this.btn_demirbasEkle.Location = new System.Drawing.Point(18, 390);
            this.btn_demirbasEkle.Name = "btn_demirbasEkle";
            this.btn_demirbasEkle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_demirbasEkle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_demirbasEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_demirbasEkle.selected = false;
            this.btn_demirbasEkle.Size = new System.Drawing.Size(215, 43);
            this.btn_demirbasEkle.TabIndex = 91;
            this.btn_demirbasEkle.Text = "EKLE";
            this.btn_demirbasEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_demirbasEkle.Textcolor = System.Drawing.Color.White;
            this.btn_demirbasEkle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demirbasEkle.Click += new System.EventHandler(this.btn_demirbasEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(239, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 280);
            this.dataGridView1.TabIndex = 93;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Demirbaş Türü";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Demirbaş Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Açıklama";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adet";
            this.Column4.Name = "Column4";
            // 
            // txt_adet
            // 
            this.txt_adet.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_adet.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_adet.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_adet.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_adet.BorderThickness = 3;
            this.txt_adet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adet.ForeColor = System.Drawing.Color.White;
            this.txt_adet.isPassword = false;
            this.txt_adet.Location = new System.Drawing.Point(152, 321);
            this.txt_adet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(80, 43);
            this.txt_adet.TabIndex = 95;
            this.txt_adet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(164, 296);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(61, 24);
            this.bunifuCustomLabel5.TabIndex = 94;
            this.bunifuCustomLabel5.Text = "ADET";
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(239, 512);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(444, 33);
            this.pnl_uyari.TabIndex = 96;
            this.pnl_uyari.Visible = false;
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyari.ForeColor = System.Drawing.Color.White;
            this.lbl_uyari.Location = new System.Drawing.Point(159, 5);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(123, 20);
            this.lbl_uyari.TabIndex = 1;
            this.lbl_uyari.Text = "İşlem Başarısız !";
            // 
            // DemirbasAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_uyari);
            this.Controls.Add(this.txt_adet);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_demirbasEkle);
            this.Controls.Add(this.txt_stokMiktari);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.dd_demirbaslar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dd_demirbasTur);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.dd_fakulteler);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.dd_odalar);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dd_departmanlar);
            this.Name = "DemirbasAtama";
            this.Size = new System.Drawing.Size(899, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_sec;
        private Bunifu.Framework.UI.BunifuDropdown dd_fakulteler;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuDropdown dd_odalar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown dd_departmanlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown dd_demirbasTur;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown dd_demirbaslar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_stokMiktari;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_demirbasEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_adet;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
    }
}
