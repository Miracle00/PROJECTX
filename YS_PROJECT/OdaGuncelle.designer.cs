namespace YS_PROJECT
{
    partial class OdaGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaGuncelle));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_departmanlar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_odalar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_fakulteler = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_sec = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_GuncelOdalar = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_uygula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.dd_GuncelPersonel = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_guncelDepartman = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(235, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 24);
            this.bunifuCustomLabel1.TabIndex = 49;
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
            this.dd_departmanlar.Location = new System.Drawing.Point(239, 63);
            this.dd_departmanlar.Name = "dd_departmanlar";
            this.dd_departmanlar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_departmanlar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.selectedIndex = -1;
            this.dd_departmanlar.Size = new System.Drawing.Size(215, 43);
            this.dd_departmanlar.TabIndex = 48;
            this.dd_departmanlar.onItemSelected += new System.EventHandler(this.dd_departmanlar_onItemSelected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(456, 36);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel3.TabIndex = 50;
            this.bunifuCustomLabel3.Text = "ODA İSMİ";
            // 
            // dd_odalar
            // 
            this.dd_odalar.BackColor = System.Drawing.Color.White;
            this.dd_odalar.BorderRadius = 3;
            this.dd_odalar.DisabledColor = System.Drawing.Color.Gray;
            this.dd_odalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_odalar.ForeColor = System.Drawing.Color.White;
            this.dd_odalar.Items = new string[0];
            this.dd_odalar.Location = new System.Drawing.Point(460, 63);
            this.dd_odalar.Name = "dd_odalar";
            this.dd_odalar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_odalar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_odalar.selectedIndex = -1;
            this.dd_odalar.Size = new System.Drawing.Size(215, 43);
            this.dd_odalar.TabIndex = 51;
            this.dd_odalar.onItemSelected += new System.EventHandler(this.dd_odalar_onItemSelected);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 112);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(862, 20);
            this.bunifuSeparator1.TabIndex = 60;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(18, 21);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(862, 12);
            this.bunifuSeparator2.TabIndex = 62;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(14, 34);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(136, 24);
            this.bunifuCustomLabel7.TabIndex = 73;
            this.bunifuCustomLabel7.Text = "FAKÜLTE İSMİ";
            // 
            // dd_fakulteler
            // 
            this.dd_fakulteler.BackColor = System.Drawing.Color.White;
            this.dd_fakulteler.BorderRadius = 3;
            this.dd_fakulteler.DisabledColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_fakulteler.ForeColor = System.Drawing.Color.White;
            this.dd_fakulteler.Items = new string[0];
            this.dd_fakulteler.Location = new System.Drawing.Point(18, 63);
            this.dd_fakulteler.Margin = new System.Windows.Forms.Padding(7);
            this.dd_fakulteler.Name = "dd_fakulteler";
            this.dd_fakulteler.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_fakulteler.onHoverColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.selectedIndex = -1;
            this.dd_fakulteler.Size = new System.Drawing.Size(215, 43);
            this.dd_fakulteler.TabIndex = 72;
            this.dd_fakulteler.onItemSelected += new System.EventHandler(this.dd_fakulteler_onItemSelected);
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
            this.btn_sec.Location = new System.Drawing.Point(681, 63);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sec.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_sec.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sec.selected = false;
            this.btn_sec.Size = new System.Drawing.Size(199, 43);
            this.btn_sec.TabIndex = 72;
            this.btn_sec.Text = "SEÇ";
            this.btn_sec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sec.Textcolor = System.Drawing.Color.White;
            this.btn_sec.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_GuncelOdalar);
            this.panel1.Controls.Add(this.btn_uygula);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dd_GuncelPersonel);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.dd_guncelDepartman);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Location = new System.Drawing.Point(79, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 301);
            this.panel1.TabIndex = 74;
            this.panel1.Visible = false;
            // 
            // txt_GuncelOdalar
            // 
            this.txt_GuncelOdalar.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_GuncelOdalar.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_GuncelOdalar.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_GuncelOdalar.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_GuncelOdalar.BorderThickness = 3;
            this.txt_GuncelOdalar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GuncelOdalar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_GuncelOdalar.ForeColor = System.Drawing.Color.White;
            this.txt_GuncelOdalar.isPassword = false;
            this.txt_GuncelOdalar.Location = new System.Drawing.Point(249, 117);
            this.txt_GuncelOdalar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GuncelOdalar.Name = "txt_GuncelOdalar";
            this.txt_GuncelOdalar.Size = new System.Drawing.Size(214, 43);
            this.txt_GuncelOdalar.TabIndex = 76;
            this.txt_GuncelOdalar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_GuncelOdalar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GuncelOdalar_KeyPress_1);
            // 
            // btn_uygula
            // 
            this.btn_uygula.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_uygula.BorderRadius = 0;
            this.btn_uygula.ButtonText = "UYGULA";
            this.btn_uygula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uygula.DisabledColor = System.Drawing.Color.Gray;
            this.btn_uygula.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_uygula.Iconimage = null;
            this.btn_uygula.Iconimage_right = null;
            this.btn_uygula.Iconimage_right_Selected = null;
            this.btn_uygula.Iconimage_Selected = null;
            this.btn_uygula.IconMarginLeft = 0;
            this.btn_uygula.IconMarginRight = 0;
            this.btn_uygula.IconRightVisible = true;
            this.btn_uygula.IconRightZoom = 0D;
            this.btn_uygula.IconVisible = true;
            this.btn_uygula.IconZoom = 90D;
            this.btn_uygula.IsTab = false;
            this.btn_uygula.Location = new System.Drawing.Point(249, 190);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_uygula.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uygula.selected = false;
            this.btn_uygula.Size = new System.Drawing.Size(215, 43);
            this.btn_uygula.TabIndex = 75;
            this.btn_uygula.Text = "UYGULA";
            this.btn_uygula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_uygula.Textcolor = System.Drawing.Color.White;
            this.btn_uygula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click_1);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(24, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 24);
            this.bunifuCustomLabel2.TabIndex = 71;
            this.bunifuCustomLabel2.Text = "DEPARTMAN İSMİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 15);
            this.label1.TabIndex = 69;
            this.label1.Text = "! Güncellenmesini istediğiniz oda bilgilerini yukarıdaki bölümden seçerek,aşağıda" +
    "ki alanlarla güncelleyebilirsiniz.";
            // 
            // dd_GuncelPersonel
            // 
            this.dd_GuncelPersonel.BackColor = System.Drawing.Color.White;
            this.dd_GuncelPersonel.BorderRadius = 3;
            this.dd_GuncelPersonel.DisabledColor = System.Drawing.Color.Gray;
            this.dd_GuncelPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_GuncelPersonel.ForeColor = System.Drawing.Color.White;
            this.dd_GuncelPersonel.Items = new string[0];
            this.dd_GuncelPersonel.Location = new System.Drawing.Point(470, 117);
            this.dd_GuncelPersonel.Name = "dd_GuncelPersonel";
            this.dd_GuncelPersonel.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_GuncelPersonel.onHoverColor = System.Drawing.Color.Gray;
            this.dd_GuncelPersonel.selectedIndex = -1;
            this.dd_GuncelPersonel.Size = new System.Drawing.Size(215, 43);
            this.dd_GuncelPersonel.TabIndex = 68;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(245, 90);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel5.TabIndex = 67;
            this.bunifuCustomLabel5.Text = "ODA İSMİ";
            // 
            // dd_guncelDepartman
            // 
            this.dd_guncelDepartman.BackColor = System.Drawing.Color.White;
            this.dd_guncelDepartman.BorderRadius = 3;
            this.dd_guncelDepartman.DisabledColor = System.Drawing.Color.Gray;
            this.dd_guncelDepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_guncelDepartman.ForeColor = System.Drawing.Color.White;
            this.dd_guncelDepartman.Items = new string[0];
            this.dd_guncelDepartman.Location = new System.Drawing.Point(28, 117);
            this.dd_guncelDepartman.Name = "dd_guncelDepartman";
            this.dd_guncelDepartman.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_guncelDepartman.onHoverColor = System.Drawing.Color.Gray;
            this.dd_guncelDepartman.selectedIndex = -1;
            this.dd_guncelDepartman.Size = new System.Drawing.Size(215, 43);
            this.dd_guncelDepartman.TabIndex = 66;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(466, 90);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(153, 24);
            this.bunifuCustomLabel4.TabIndex = 65;
            this.bunifuCustomLabel4.Text = "PERSONEL İSMİ";
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(274, 486);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(300, 33);
            this.pnl_uyari.TabIndex = 75;
            this.pnl_uyari.Visible = false;
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyari.ForeColor = System.Drawing.Color.White;
            this.lbl_uyari.Location = new System.Drawing.Point(95, 7);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(123, 20);
            this.lbl_uyari.TabIndex = 1;
            this.lbl_uyari.Text = "İşlem Başarısız !";
            // 
            // OdaGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_uyari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.dd_fakulteler);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.dd_odalar);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dd_departmanlar);
            this.Name = "OdaGuncelle";
            this.Size = new System.Drawing.Size(899, 564);
            this.Load += new System.EventHandler(this.OdaGuncelle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown dd_departmanlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown dd_odalar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuDropdown dd_fakulteler;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sec;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown dd_GuncelPersonel;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDropdown dd_guncelDepartman;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_uygula;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_GuncelOdalar;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
    }
}
