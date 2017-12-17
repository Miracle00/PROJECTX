namespace YS_PROJECT
{
    partial class PersonelGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelGuncelle));
            this.lst_personeller = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_PersonelArama = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_soyad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_ad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lst_odalar = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_yetki = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_sil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_yetki = new System.Windows.Forms.Panel();
            this.txt_sifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_kullaniciAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cb_nKullanici = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cb_admin = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.btn_uygula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_yetki.SuspendLayout();
            this.pnl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_personeller
            // 
            this.lst_personeller.FormattingEnabled = true;
            this.lst_personeller.Location = new System.Drawing.Point(3, 71);
            this.lst_personeller.Name = "lst_personeller";
            this.lst_personeller.Size = new System.Drawing.Size(232, 277);
            this.lst_personeller.TabIndex = 31;
            this.lst_personeller.SelectedIndexChanged += new System.EventHandler(this.lst_personeller_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(201, 19);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "İşlem yapılacak personel";
            // 
            // txt_PersonelArama
            // 
            this.txt_PersonelArama.BackColor = System.Drawing.Color.Silver;
            this.txt_PersonelArama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_PersonelArama.BackgroundImage")));
            this.txt_PersonelArama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_PersonelArama.ForeColor = System.Drawing.Color.SeaGreen;
            this.txt_PersonelArama.Icon = ((System.Drawing.Image)(resources.GetObject("txt_PersonelArama.Icon")));
            this.txt_PersonelArama.Location = new System.Drawing.Point(3, 23);
            this.txt_PersonelArama.Name = "txt_PersonelArama";
            this.txt_PersonelArama.Size = new System.Drawing.Size(232, 42);
            this.txt_PersonelArama.TabIndex = 30;
            this.txt_PersonelArama.text = "";
            this.txt_PersonelArama.OnTextChange += new System.EventHandler(this.txt_PersonelArama_OnTextChange);
            // 
            // txt_soyad
            // 
            this.txt_soyad.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_soyad.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_soyad.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_soyad.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_soyad.BorderThickness = 3;
            this.txt_soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.ForeColor = System.Drawing.Color.White;
            this.txt_soyad.isPassword = false;
            this.txt_soyad.Location = new System.Drawing.Point(240, 33);
            this.txt_soyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(219, 43);
            this.txt_soyad.TabIndex = 48;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(240, 8);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(162, 20);
            this.bunifuCustomLabel3.TabIndex = 47;
            this.bunifuCustomLabel3.Text = "PERSONEL SOYADI";
            // 
            // txt_ad
            // 
            this.txt_ad.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_ad.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_ad.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_ad.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_ad.BorderThickness = 3;
            this.txt_ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ad.Enabled = false;
            this.txt_ad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.ForeColor = System.Drawing.Color.White;
            this.txt_ad.isPassword = false;
            this.txt_ad.Location = new System.Drawing.Point(13, 33);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(219, 43);
            this.txt_ad.TabIndex = 46;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(13, 8);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(128, 20);
            this.bunifuCustomLabel4.TabIndex = 45;
            this.bunifuCustomLabel4.Text = "PERSONEL ADI";
            // 
            // lst_odalar
            // 
            this.lst_odalar.FormattingEnabled = true;
            this.lst_odalar.Location = new System.Drawing.Point(3, 371);
            this.lst_odalar.Name = "lst_odalar";
            this.lst_odalar.Size = new System.Drawing.Size(232, 186);
            this.lst_odalar.TabIndex = 51;
            this.lst_odalar.SelectedIndexChanged += new System.EventHandler(this.lst_odalar_SelectedIndexChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(34, 352);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(183, 16);
            this.bunifuCustomLabel5.TabIndex = 52;
            this.bunifuCustomLabel5.Text = "Personelin Üzerindeki Odalar";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(241, 541);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(515, 16);
            this.bunifuCustomLabel6.TabIndex = 53;
            this.bunifuCustomLabel6.Text = "! Personelin yetkili olduğu odalardan kaldırmak istediğinizin üzerine çift tıklay" +
    "abilirsiniz.";
            // 
            // btn_yetki
            // 
            this.btn_yetki.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yetki.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yetki.BorderRadius = 0;
            this.btn_yetki.ButtonText = "YETKİ VER";
            this.btn_yetki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yetki.DisabledColor = System.Drawing.Color.Gray;
            this.btn_yetki.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_yetki.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_yetki.Iconimage")));
            this.btn_yetki.Iconimage_right = null;
            this.btn_yetki.Iconimage_right_Selected = null;
            this.btn_yetki.Iconimage_Selected = null;
            this.btn_yetki.IconMarginLeft = 0;
            this.btn_yetki.IconMarginRight = 0;
            this.btn_yetki.IconRightVisible = true;
            this.btn_yetki.IconRightZoom = 0D;
            this.btn_yetki.IconVisible = true;
            this.btn_yetki.IconZoom = 90D;
            this.btn_yetki.IsTab = false;
            this.btn_yetki.Location = new System.Drawing.Point(497, 23);
            this.btn_yetki.Name = "btn_yetki";
            this.btn_yetki.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_yetki.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_yetki.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_yetki.selected = false;
            this.btn_yetki.Size = new System.Drawing.Size(250, 42);
            this.btn_yetki.TabIndex = 54;
            this.btn_yetki.Text = "YETKİ VER";
            this.btn_yetki.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_yetki.Textcolor = System.Drawing.Color.White;
            this.btn_yetki.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yetki.Click += new System.EventHandler(this.btn_yetki_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sil.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sil.BorderRadius = 0;
            this.btn_sil.ButtonText = "SİL";
            this.btn_sil.CausesValidation = false;
            this.btn_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sil.DisabledColor = System.Drawing.Color.Gray;
            this.btn_sil.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_sil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_sil.Iconimage")));
            this.btn_sil.Iconimage_right = null;
            this.btn_sil.Iconimage_right_Selected = null;
            this.btn_sil.Iconimage_Selected = null;
            this.btn_sil.IconMarginLeft = 0;
            this.btn_sil.IconMarginRight = 0;
            this.btn_sil.IconRightVisible = true;
            this.btn_sil.IconRightZoom = 0D;
            this.btn_sil.IconVisible = true;
            this.btn_sil.IconZoom = 90D;
            this.btn_sil.IsTab = false;
            this.btn_sil.Location = new System.Drawing.Point(241, 23);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_sil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_sil.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_sil.selected = false;
            this.btn_sil.Size = new System.Drawing.Size(250, 42);
            this.btn_sil.TabIndex = 55;
            this.btn_sil.Text = "SİL";
            this.btn_sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sil.Textcolor = System.Drawing.Color.White;
            this.btn_sil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // pnl_yetki
            // 
            this.pnl_yetki.Controls.Add(this.btn_uygula);
            this.pnl_yetki.Controls.Add(this.bunifuSeparator1);
            this.pnl_yetki.Controls.Add(this.bunifuSeparator2);
            this.pnl_yetki.Controls.Add(this.txt_sifre);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel2);
            this.pnl_yetki.Controls.Add(this.txt_kullaniciAdi);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel7);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel9);
            this.pnl_yetki.Controls.Add(this.cb_nKullanici);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel10);
            this.pnl_yetki.Controls.Add(this.cb_admin);
            this.pnl_yetki.Controls.Add(this.txt_ad);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel4);
            this.pnl_yetki.Controls.Add(this.bunifuCustomLabel3);
            this.pnl_yetki.Controls.Add(this.txt_soyad);
            this.pnl_yetki.Location = new System.Drawing.Point(260, 101);
            this.pnl_yetki.Name = "pnl_yetki";
            this.pnl_yetki.Size = new System.Drawing.Size(465, 296);
            this.pnl_yetki.TabIndex = 56;
            this.pnl_yetki.Visible = false;
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_sifre.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_sifre.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_sifre.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_sifre.BorderThickness = 3;
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.White;
            this.txt_sifre.isPassword = true;
            this.txt_sifre.Location = new System.Drawing.Point(240, 168);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(219, 43);
            this.txt_sifre.TabIndex = 65;
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(240, 143);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(58, 20);
            this.bunifuCustomLabel2.TabIndex = 63;
            this.bunifuCustomLabel2.Text = "ŞİFRE";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_kullaniciAdi.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_kullaniciAdi.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_kullaniciAdi.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_kullaniciAdi.BorderThickness = 3;
            this.txt_kullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txt_kullaniciAdi.isPassword = false;
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(13, 168);
            this.txt_kullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(219, 43);
            this.txt_kullaniciAdi.TabIndex = 61;
            this.txt_kullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(13, 143);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel7.TabIndex = 59;
            this.bunifuCustomLabel7.Text = "KULLANICI ADI";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(82, 101);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(124, 20);
            this.bunifuCustomLabel9.TabIndex = 64;
            this.bunifuCustomLabel9.Text = "Normal Kullanıcı:";
            // 
            // cb_nKullanici
            // 
            this.cb_nKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_nKullanici.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_nKullanici.Checked = false;
            this.cb_nKullanici.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_nKullanici.ForeColor = System.Drawing.Color.White;
            this.cb_nKullanici.Location = new System.Drawing.Point(207, 102);
            this.cb_nKullanici.Name = "cb_nKullanici";
            this.cb_nKullanici.Size = new System.Drawing.Size(20, 20);
            this.cb_nKullanici.TabIndex = 62;
            this.cb_nKullanici.OnChange += new System.EventHandler(this.cb_nKullanici_OnChange);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(240, 101);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(58, 20);
            this.bunifuCustomLabel10.TabIndex = 60;
            this.bunifuCustomLabel10.Text = "Admin:";
            // 
            // cb_admin
            // 
            this.cb_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_admin.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cb_admin.Checked = false;
            this.cb_admin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cb_admin.ForeColor = System.Drawing.Color.White;
            this.cb_admin.Location = new System.Drawing.Point(300, 103);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(20, 20);
            this.cb_admin.TabIndex = 58;
            this.cb_admin.OnChange += new System.EventHandler(this.cb_admin_OnChange);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(13, 84);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(446, 11);
            this.bunifuSeparator2.TabIndex = 66;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 129);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(446, 11);
            this.bunifuSeparator1.TabIndex = 67;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(374, 505);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(250, 33);
            this.pnl_uyari.TabIndex = 57;
            this.pnl_uyari.Visible = false;
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyari.ForeColor = System.Drawing.Color.White;
            this.lbl_uyari.Location = new System.Drawing.Point(50, 7);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(147, 20);
            this.lbl_uyari.TabIndex = 1;
            this.lbl_uyari.Text = "Personel Seçilmedi.";
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
            this.btn_uygula.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_uygula.Iconimage")));
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
            this.btn_uygula.Location = new System.Drawing.Point(119, 219);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_uygula.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uygula.selected = false;
            this.btn_uygula.Size = new System.Drawing.Size(250, 42);
            this.btn_uygula.TabIndex = 58;
            this.btn_uygula.Text = "UYGULA";
            this.btn_uygula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uygula.Textcolor = System.Drawing.Color.White;
            this.btn_uygula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(315, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Bu kullanıcının yetkilendirmesi daha önce yapılmıştır.";
            this.label1.Visible = false;
            // 
            // PersonelGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_uyari);
            this.Controls.Add(this.pnl_yetki);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_yetki);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.lst_odalar);
            this.Controls.Add(this.lst_personeller);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_PersonelArama);
            this.Name = "PersonelGuncelle";
            this.Size = new System.Drawing.Size(899, 564);
            this.pnl_yetki.ResumeLayout(false);
            this.pnl_yetki.PerformLayout();
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_personeller;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuTextbox txt_PersonelArama;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_soyad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ad;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.ListBox lst_odalar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_yetki;
        private Bunifu.Framework.UI.BunifuFlatButton btn_sil;
        private System.Windows.Forms.Panel pnl_yetki;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_sifre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_kullaniciAdi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCheckbox cb_nKullanici;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCheckbox cb_admin;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
        private Bunifu.Framework.UI.BunifuFlatButton btn_uygula;
        private System.Windows.Forms.Label label1;
    }
}
