namespace YS_PROJECT
{
    partial class OdaSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaSil));
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_departmanlar = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dd_fakulteler = new Bunifu.Framework.UI.BunifuDropdown();
            this.btn_uygula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dd_oda = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.pnl_uyari.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(392, 178);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(92, 24);
            this.bunifuCustomLabel3.TabIndex = 42;
            this.bunifuCustomLabel3.Text = "ODA İSMİ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(474, 88);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(170, 24);
            this.bunifuCustomLabel1.TabIndex = 41;
            this.bunifuCustomLabel1.Text = "DEPARTMAN İSMİ";
            // 
            // dd_departmanlar
            // 
            this.dd_departmanlar.BackColor = System.Drawing.Color.White;
            this.dd_departmanlar.BorderRadius = 3;
            this.dd_departmanlar.DisabledColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.ForeColor = System.Drawing.Color.White;
            this.dd_departmanlar.Items = new string[0];
            this.dd_departmanlar.Location = new System.Drawing.Point(478, 115);
            this.dd_departmanlar.Name = "dd_departmanlar";
            this.dd_departmanlar.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_departmanlar.onHoverColor = System.Drawing.Color.Gray;
            this.dd_departmanlar.selectedIndex = -1;
            this.dd_departmanlar.Size = new System.Drawing.Size(300, 43);
            this.dd_departmanlar.TabIndex = 40;
            this.dd_departmanlar.onItemSelected += new System.EventHandler(this.dd_departmanlar_onItemSelected);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(94, 88);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(141, 24);
            this.bunifuCustomLabel2.TabIndex = 39;
            this.bunifuCustomLabel2.Text = "FAKULTE  İSMİ";
            // 
            // dd_fakulteler
            // 
            this.dd_fakulteler.BackColor = System.Drawing.Color.White;
            this.dd_fakulteler.BorderRadius = 3;
            this.dd_fakulteler.DisabledColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.ForeColor = System.Drawing.Color.White;
            this.dd_fakulteler.Items = new string[0];
            this.dd_fakulteler.Location = new System.Drawing.Point(98, 115);
            this.dd_fakulteler.Name = "dd_fakulteler";
            this.dd_fakulteler.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_fakulteler.onHoverColor = System.Drawing.Color.Gray;
            this.dd_fakulteler.selectedIndex = -1;
            this.dd_fakulteler.Size = new System.Drawing.Size(300, 43);
            this.dd_fakulteler.TabIndex = 37;
            this.dd_fakulteler.onItemSelected += new System.EventHandler(this.dd_fakulteler_onItemSelected);
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
            this.btn_uygula.Location = new System.Drawing.Point(297, 267);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_uygula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_uygula.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_uygula.selected = false;
            this.btn_uygula.Size = new System.Drawing.Size(300, 48);
            this.btn_uygula.TabIndex = 38;
            this.btn_uygula.Text = "UYGULA";
            this.btn_uygula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_uygula.Textcolor = System.Drawing.Color.White;
            this.btn_uygula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            // 
            // dd_oda
            // 
            this.dd_oda.BackColor = System.Drawing.Color.White;
            this.dd_oda.BorderRadius = 3;
            this.dd_oda.DisabledColor = System.Drawing.Color.Gray;
            this.dd_oda.ForeColor = System.Drawing.Color.White;
            this.dd_oda.Items = new string[0];
            this.dd_oda.Location = new System.Drawing.Point(297, 218);
            this.dd_oda.Name = "dd_oda";
            this.dd_oda.NomalColor = System.Drawing.SystemColors.GrayText;
            this.dd_oda.onHoverColor = System.Drawing.Color.Gray;
            this.dd_oda.selectedIndex = -1;
            this.dd_oda.Size = new System.Drawing.Size(300, 43);
            this.dd_oda.TabIndex = 44;
            this.dd_oda.onItemSelected += new System.EventHandler(this.dd_oda_onItemSelected);
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(297, 462);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(300, 33);
            this.pnl_uyari.TabIndex = 45;
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
            // OdaSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_uyari);
            this.Controls.Add(this.dd_oda);
            this.Controls.Add(this.btn_uygula);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dd_departmanlar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dd_fakulteler);
            this.Name = "OdaSil";
            this.Size = new System.Drawing.Size(899, 564);
            this.Load += new System.EventHandler(this.OdaSil_Load);
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btn_uygula;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown dd_departmanlar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown dd_fakulteler;
        private Bunifu.Framework.UI.BunifuDropdown dd_oda;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
    }
}
