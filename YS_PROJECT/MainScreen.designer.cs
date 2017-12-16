namespace YS_PROJECT
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Personel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_odaIslem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_demirbasIslem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_satinAlim = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_Personel);
            this.panel1.Controls.Add(this.btn_odaIslem);
            this.panel1.Controls.Add(this.btn_demirbasIslem);
            this.panel1.Controls.Add(this.btn_satinAlim);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 622);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(1, 583);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 38);
            this.panel6.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lbl_kullanici);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(1, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 38);
            this.panel4.TabIndex = 6;
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.ForeColor = System.Drawing.Color.White;
            this.lbl_kullanici.Location = new System.Drawing.Point(55, 16);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(36, 13);
            this.lbl_kullanici.TabIndex = 1;
            this.lbl_kullanici.Text = "Sayın:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞGELDİNİZ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 159);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(250, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 622);
            this.panel5.TabIndex = 2;
            // 
            // btn_Personel
            // 
            this.btn_Personel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_Personel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_Personel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Personel.BorderRadius = 0;
            this.btn_Personel.ButtonText = "Personel İşlemleri";
            this.btn_Personel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Personel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Personel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Personel.Iconimage = global::YS_PROJECT.Properties.Resources.personel;
            this.btn_Personel.Iconimage_right = null;
            this.btn_Personel.Iconimage_right_Selected = null;
            this.btn_Personel.Iconimage_Selected = null;
            this.btn_Personel.IconMarginLeft = 0;
            this.btn_Personel.IconMarginRight = 0;
            this.btn_Personel.IconRightVisible = true;
            this.btn_Personel.IconRightZoom = 0D;
            this.btn_Personel.IconVisible = true;
            this.btn_Personel.IconZoom = 90D;
            this.btn_Personel.IsTab = false;
            this.btn_Personel.Location = new System.Drawing.Point(2, 379);
            this.btn_Personel.Name = "btn_Personel";
            this.btn_Personel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_Personel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_Personel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Personel.selected = false;
            this.btn_Personel.Size = new System.Drawing.Size(250, 60);
            this.btn_Personel.TabIndex = 5;
            this.btn_Personel.Text = "Personel İşlemleri";
            this.btn_Personel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Personel.Textcolor = System.Drawing.Color.White;
            this.btn_Personel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Personel.Click += new System.EventHandler(this.btn_Personel_Click);
            // 
            // btn_odaIslem
            // 
            this.btn_odaIslem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_odaIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_odaIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_odaIslem.BorderRadius = 0;
            this.btn_odaIslem.ButtonText = "Oda İşlemleri";
            this.btn_odaIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_odaIslem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_odaIslem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_odaIslem.Iconimage = global::YS_PROJECT.Properties.Resources.room;
            this.btn_odaIslem.Iconimage_right = null;
            this.btn_odaIslem.Iconimage_right_Selected = null;
            this.btn_odaIslem.Iconimage_Selected = null;
            this.btn_odaIslem.IconMarginLeft = 0;
            this.btn_odaIslem.IconMarginRight = 0;
            this.btn_odaIslem.IconRightVisible = true;
            this.btn_odaIslem.IconRightZoom = 0D;
            this.btn_odaIslem.IconVisible = true;
            this.btn_odaIslem.IconZoom = 90D;
            this.btn_odaIslem.IsTab = false;
            this.btn_odaIslem.Location = new System.Drawing.Point(2, 319);
            this.btn_odaIslem.Name = "btn_odaIslem";
            this.btn_odaIslem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_odaIslem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_odaIslem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_odaIslem.selected = false;
            this.btn_odaIslem.Size = new System.Drawing.Size(250, 60);
            this.btn_odaIslem.TabIndex = 4;
            this.btn_odaIslem.Text = "Oda İşlemleri";
            this.btn_odaIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_odaIslem.Textcolor = System.Drawing.Color.White;
            this.btn_odaIslem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_odaIslem.Click += new System.EventHandler(this.btn_odaIslem_Click);
            // 
            // btn_demirbasIslem
            // 
            this.btn_demirbasIslem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_demirbasIslem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demirbasIslem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_demirbasIslem.BorderRadius = 0;
            this.btn_demirbasIslem.ButtonText = "Demirbaş İşlemleri";
            this.btn_demirbasIslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_demirbasIslem.DisabledColor = System.Drawing.Color.Gray;
            this.btn_demirbasIslem.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_demirbasIslem.Iconimage = global::YS_PROJECT.Properties.Resources.config;
            this.btn_demirbasIslem.Iconimage_right = null;
            this.btn_demirbasIslem.Iconimage_right_Selected = null;
            this.btn_demirbasIslem.Iconimage_Selected = null;
            this.btn_demirbasIslem.IconMarginLeft = 0;
            this.btn_demirbasIslem.IconMarginRight = 0;
            this.btn_demirbasIslem.IconRightVisible = true;
            this.btn_demirbasIslem.IconRightZoom = 0D;
            this.btn_demirbasIslem.IconVisible = true;
            this.btn_demirbasIslem.IconZoom = 90D;
            this.btn_demirbasIslem.IsTab = false;
            this.btn_demirbasIslem.Location = new System.Drawing.Point(2, 259);
            this.btn_demirbasIslem.Name = "btn_demirbasIslem";
            this.btn_demirbasIslem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_demirbasIslem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_demirbasIslem.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_demirbasIslem.selected = false;
            this.btn_demirbasIslem.Size = new System.Drawing.Size(250, 60);
            this.btn_demirbasIslem.TabIndex = 3;
            this.btn_demirbasIslem.Text = "Demirbaş İşlemleri";
            this.btn_demirbasIslem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_demirbasIslem.Textcolor = System.Drawing.Color.White;
            this.btn_demirbasIslem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_demirbasIslem.Click += new System.EventHandler(this.btn_demirbasIslem_Click);
            // 
            // btn_satinAlim
            // 
            this.btn_satinAlim.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_satinAlim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_satinAlim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_satinAlim.BorderRadius = 0;
            this.btn_satinAlim.ButtonText = "Satın Alma İşlemleri";
            this.btn_satinAlim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_satinAlim.DisabledColor = System.Drawing.Color.Gray;
            this.btn_satinAlim.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_satinAlim.Iconimage = global::YS_PROJECT.Properties.Resources.demirbas2;
            this.btn_satinAlim.Iconimage_right = null;
            this.btn_satinAlim.Iconimage_right_Selected = null;
            this.btn_satinAlim.Iconimage_Selected = null;
            this.btn_satinAlim.IconMarginLeft = 0;
            this.btn_satinAlim.IconMarginRight = 0;
            this.btn_satinAlim.IconRightVisible = true;
            this.btn_satinAlim.IconRightZoom = 0D;
            this.btn_satinAlim.IconVisible = true;
            this.btn_satinAlim.IconZoom = 90D;
            this.btn_satinAlim.IsTab = false;
            this.btn_satinAlim.Location = new System.Drawing.Point(2, 199);
            this.btn_satinAlim.Name = "btn_satinAlim";
            this.btn_satinAlim.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btn_satinAlim.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(172)))), ((int)(((byte)(209)))));
            this.btn_satinAlim.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_satinAlim.selected = false;
            this.btn_satinAlim.Size = new System.Drawing.Size(250, 60);
            this.btn_satinAlim.TabIndex = 2;
            this.btn_satinAlim.Text = "Satın Alma İşlemleri";
            this.btn_satinAlim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_satinAlim.Textcolor = System.Drawing.Color.White;
            this.btn_satinAlim.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_satinAlim.Click += new System.EventHandler(this.btn_satinAlim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YS_PROJECT.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 622);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_satinAlim;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Personel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_odaIslem;
        private Bunifu.Framework.UI.BunifuFlatButton btn_demirbasIslem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label label1;
    }
}

