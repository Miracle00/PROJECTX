namespace YS_PROJECT
{
    partial class OdaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaEkle));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_fakulteler = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_departmanlar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_OdaAd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_uygula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.pnl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(207, 52);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(141, 24);
            this.bunifuCustomLabel2.TabIndex = 29;
            this.bunifuCustomLabel2.Text = "FAKULTE  İSMİ";
            // 
            // dd_fakulteler
            // 
            this.dd_fakulteler.BackColor = System.Drawing.Color.White;
            this.dd_fakulteler.BorderRadius = 3;
            this.dd_fakulteler.DisabledColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_fakulteler.ForeColor = System.Drawing.Color.White;
            this.dd_fakulteler.Items = new string[0];
            this.dd_fakulteler.Location = new System.Drawing.Point(211, 81);
            this.dd_fakulteler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_fakulteler.Name = "dd_fakulteler";
            this.dd_fakulteler.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_fakulteler.onHoverColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.selectedIndex = -1;
            this.dd_fakulteler.Size = new System.Drawing.Size(444, 43);
            this.dd_fakulteler.TabIndex = 27;
            this.dd_fakulteler.onItemSelected += new System.EventHandler(this.dd_fakulteler_onItemSelected);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(207, 138);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 24);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "DEPARTMAN İSMİ";
            // 
            // dd_departmanlar
            // 
            this.dd_departmanlar.BackColor = System.Drawing.Color.White;
            this.dd_departmanlar.BorderRadius = 3;
            this.dd_departmanlar.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.dd_departmanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dd_departmanlar.ForeColor = System.Drawing.Color.White;
            this.dd_departmanlar.Items = new string[0];
            this.dd_departmanlar.Location = new System.Drawing.Point(211, 167);
            this.dd_departmanlar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dd_departmanlar.Name = "dd_departmanlar";
            this.dd_departmanlar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_departmanlar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.selectedIndex = -1;
            this.dd_departmanlar.Size = new System.Drawing.Size(444, 43);
            this.dd_departmanlar.TabIndex = 32;
            this.dd_departmanlar.onItemSelected += new System.EventHandler(this.dd_departmanlar_onItemSelected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(207, 227);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel3.TabIndex = 35;
            this.bunifuCustomLabel3.Text = "ODA İSMİ";
            // 
            // txt_OdaAd
            // 
            this.txt_OdaAd.BackColor = System.Drawing.SystemColors.GrayText;
            this.txt_OdaAd.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_OdaAd.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_OdaAd.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_OdaAd.BorderThickness = 3;
            this.txt_OdaAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OdaAd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_OdaAd.ForeColor = System.Drawing.Color.White;
            this.txt_OdaAd.isPassword = false;
            this.txt_OdaAd.Location = new System.Drawing.Point(211, 256);
            this.txt_OdaAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OdaAd.Name = "txt_OdaAd";
            this.txt_OdaAd.Size = new System.Drawing.Size(444, 43);
            this.txt_OdaAd.TabIndex = 38;
            this.txt_OdaAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_uygula.Location = new System.Drawing.Point(211, 322);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_uygula.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uygula.selected = false;
            this.btn_uygula.Size = new System.Drawing.Size(444, 48);
            this.btn_uygula.TabIndex = 28;
            this.btn_uygula.Text = "UYGULA";
            this.btn_uygula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uygula.Textcolor = System.Drawing.Color.White;
            this.btn_uygula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(211, 463);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(444, 33);
            this.pnl_uyari.TabIndex = 39;
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
            // OdaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_uyari);
            this.Controls.Add(this.txt_OdaAd);
            this.Controls.Add(this.btn_uygula);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dd_departmanlar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dd_fakulteler);
            this.Name = "OdaEkle";
            this.Size = new System.Drawing.Size(899, 564);
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown dd_fakulteler;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown dd_departmanlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_uygula;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_OdaAd;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
    }
}
