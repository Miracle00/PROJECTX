namespace YS_PROJECT
{
    partial class login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sifre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_kullanciAdi = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pnl_uyari = new System.Windows.Forms.Panel();
            this.lbl_uyari = new System.Windows.Forms.Label();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pBox_cancel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnl_uyari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.txt_sifre);
            this.groupBox1.Controls.Add(this.txt_kullanciAdi);
            this.groupBox1.Controls.Add(this.pnl_uyari);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 255);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİSTEM GİRİŞİ";
            // 
            // txt_sifre
            // 
            this.txt_sifre.BackColor = System.Drawing.Color.White;
            this.txt_sifre.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_sifre.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_sifre.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_sifre.BorderThickness = 3;
            this.txt_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sifre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sifre.ForeColor = System.Drawing.Color.DimGray;
            this.txt_sifre.isPassword = true;
            this.txt_sifre.Location = new System.Drawing.Point(28, 88);
            this.txt_sifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(370, 49);
            this.txt_sifre.TabIndex = 40;
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_sifre.OnValueChanged += new System.EventHandler(this.txt_sifre_OnValueChanged);
            this.txt_sifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sifre_KeyPress);
            // 
            // txt_kullanciAdi
            // 
            this.txt_kullanciAdi.BackColor = System.Drawing.Color.White;
            this.txt_kullanciAdi.BorderColorFocused = System.Drawing.Color.Empty;
            this.txt_kullanciAdi.BorderColorIdle = System.Drawing.Color.Empty;
            this.txt_kullanciAdi.BorderColorMouseHover = System.Drawing.Color.Empty;
            this.txt_kullanciAdi.BorderThickness = 3;
            this.txt_kullanciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_kullanciAdi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_kullanciAdi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_kullanciAdi.isPassword = false;
            this.txt_kullanciAdi.Location = new System.Drawing.Point(28, 37);
            this.txt_kullanciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_kullanciAdi.Name = "txt_kullanciAdi";
            this.txt_kullanciAdi.Size = new System.Drawing.Size(370, 49);
            this.txt_kullanciAdi.TabIndex = 39;
            this.txt_kullanciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_kullanciAdi.OnValueChanged += new System.EventHandler(this.txt_kullanciAdi_OnValueChanged);
            this.txt_kullanciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kullanciAdi_KeyPress);
            // 
            // pnl_uyari
            // 
            this.pnl_uyari.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_uyari.Controls.Add(this.lbl_uyari);
            this.pnl_uyari.Location = new System.Drawing.Point(28, 214);
            this.pnl_uyari.Name = "pnl_uyari";
            this.pnl_uyari.Size = new System.Drawing.Size(370, 33);
            this.pnl_uyari.TabIndex = 7;
            this.pnl_uyari.Visible = false;
            // 
            // lbl_uyari
            // 
            this.lbl_uyari.AutoSize = true;
            this.lbl_uyari.Location = new System.Drawing.Point(104, 6);
            this.lbl_uyari.Name = "lbl_uyari";
            this.lbl_uyari.Size = new System.Drawing.Size(162, 20);
            this.lbl_uyari.TabIndex = 0;
            this.lbl_uyari.Text = "Giriş İşlemi Başarısız !";
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "GİRİŞ";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Font = new System.Drawing.Font("MS Office Symbol Regular", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = null;
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = true;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(28, 140);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(370, 48);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "GİRİŞ";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pBox_cancel
            // 
            this.pBox_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.pBox_cancel.Image = global::YS_PROJECT.Properties.Resources.cancel;
            this.pBox_cancel.Location = new System.Drawing.Point(439, 9);
            this.pBox_cancel.Name = "pBox_cancel";
            this.pBox_cancel.Size = new System.Drawing.Size(21, 17);
            this.pBox_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_cancel.TabIndex = 5;
            this.pBox_cancel.TabStop = false;
            this.pBox_cancel.Click += new System.EventHandler(this.pBox_cancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(468, 286);
            this.Controls.Add(this.pBox_cancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "logincs";
            this.groupBox1.ResumeLayout(false);
            this.pnl_uyari.ResumeLayout(false);
            this.pnl_uyari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_cancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;
        private System.Windows.Forms.PictureBox pBox_cancel;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_sifre;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_kullanciAdi;
        private System.Windows.Forms.Panel pnl_uyari;
        private System.Windows.Forms.Label lbl_uyari;
    }
}