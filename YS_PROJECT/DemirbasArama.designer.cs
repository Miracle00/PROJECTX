namespace YS_PROJECT
{
    partial class DemirbasArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemirbasArama));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_arama = new System.Windows.Forms.Panel();
            this.panel_fiyat = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_minFiyat = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_maxFiyat = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btn_AramaKriteri = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btn_temizle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.selectedRowsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_arama.SuspendLayout();
            this.panel_fiyat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(201, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 512);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Demirbas Adı";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Demirbas Türü";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fiyatı";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Alım Tarihi";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adet";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(422, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tüm Demirbasların Listesi";
            // 
            // panel_arama
            // 
            this.panel_arama.Controls.Add(this.panel_fiyat);
            this.panel_arama.Location = new System.Drawing.Point(1, 108);
            this.panel_arama.Name = "panel_arama";
            this.panel_arama.Size = new System.Drawing.Size(196, 42);
            this.panel_arama.TabIndex = 25;
            // 
            // panel_fiyat
            // 
            this.panel_fiyat.Controls.Add(this.label5);
            this.panel_fiyat.Controls.Add(this.label3);
            this.panel_fiyat.Controls.Add(this.label2);
            this.panel_fiyat.Controls.Add(this.txt_minFiyat);
            this.panel_fiyat.Controls.Add(this.txt_maxFiyat);
            this.panel_fiyat.Location = new System.Drawing.Point(7, 0);
            this.panel_fiyat.Name = "panel_fiyat";
            this.panel_fiyat.Size = new System.Drawing.Size(181, 42);
            this.panel_fiyat.TabIndex = 26;
            this.panel_fiyat.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "-";
            // 
            // txt_minFiyat
            // 
            this.txt_minFiyat.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_minFiyat.Location = new System.Drawing.Point(22, 15);
            this.txt_minFiyat.Multiline = true;
            this.txt_minFiyat.Name = "txt_minFiyat";
            this.txt_minFiyat.Size = new System.Drawing.Size(66, 24);
            this.txt_minFiyat.TabIndex = 26;
            // 
            // txt_maxFiyat
            // 
            this.txt_maxFiyat.BorderColor = System.Drawing.Color.SeaGreen;
            this.txt_maxFiyat.Location = new System.Drawing.Point(111, 15);
            this.txt_maxFiyat.Multiline = true;
            this.txt_maxFiyat.Name = "txt_maxFiyat";
            this.txt_maxFiyat.Size = new System.Drawing.Size(66, 24);
            this.txt_maxFiyat.TabIndex = 27;
            // 
            // btn_AramaKriteri
            // 
            this.btn_AramaKriteri.BackColor = System.Drawing.Color.Transparent;
            this.btn_AramaKriteri.BorderRadius = 3;
            this.btn_AramaKriteri.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AramaKriteri.ForeColor = System.Drawing.Color.White;
            this.btn_AramaKriteri.Items = new string[] {
        "Demirbas Adı",
        "Demirbas Türü",
        "Fiyat",
        "Alım Tarihi"};
            this.btn_AramaKriteri.Location = new System.Drawing.Point(3, 49);
            this.btn_AramaKriteri.Name = "btn_AramaKriteri";
            this.btn_AramaKriteri.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AramaKriteri.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_AramaKriteri.selectedIndex = -1;
            this.btn_AramaKriteri.Size = new System.Drawing.Size(196, 42);
            this.btn_AramaKriteri.TabIndex = 24;
            this.btn_AramaKriteri.onItemSelected += new System.EventHandler(this.btn_AramaKriteri_onItemSelected_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Arama Kriteri Seçimi";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, 154);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(199, 10);
            this.bunifuSeparator2.TabIndex = 21;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(2, 97);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(199, 10);
            this.bunifuSeparator1.TabIndex = 20;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_temizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_temizle.BorderRadius = 0;
            this.btn_temizle.ButtonText = "FİLTREYİ KALDIR";
            this.btn_temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_temizle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_temizle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_temizle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_temizle.Iconimage")));
            this.btn_temizle.Iconimage_right = null;
            this.btn_temizle.Iconimage_right_Selected = null;
            this.btn_temizle.Iconimage_Selected = null;
            this.btn_temizle.IconMarginLeft = 0;
            this.btn_temizle.IconMarginRight = 0;
            this.btn_temizle.IconRightVisible = true;
            this.btn_temizle.IconRightZoom = 0D;
            this.btn_temizle.IconVisible = true;
            this.btn_temizle.IconZoom = 90D;
            this.btn_temizle.IsTab = false;
            this.btn_temizle.Location = new System.Drawing.Point(1, 165);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_temizle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_temizle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_temizle.selected = false;
            this.btn_temizle.Size = new System.Drawing.Size(198, 48);
            this.btn_temizle.TabIndex = 22;
            this.btn_temizle.Text = "FİLTREYİ KALDIR";
            this.btn_temizle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_temizle.Textcolor = System.Drawing.Color.White;
            this.btn_temizle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // selectedRowsButton
            // 
            this.selectedRowsButton.Location = new System.Drawing.Point(12, 249);
            this.selectedRowsButton.Name = "selectedRowsButton";
            this.selectedRowsButton.Size = new System.Drawing.Size(146, 62);
            this.selectedRowsButton.TabIndex = 26;
            this.selectedRowsButton.Text = "button1";
            this.selectedRowsButton.UseVisualStyleBackColor = true;
            // 
            // DemirbasArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedRowsButton);
            this.Controls.Add(this.panel_arama);
            this.Controls.Add(this.btn_AramaKriteri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DemirbasArama";
            this.Size = new System.Drawing.Size(899, 564);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_arama.ResumeLayout(false);
            this.panel_fiyat.ResumeLayout(false);
            this.panel_fiyat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_arama;
        private Bunifu.Framework.UI.BunifuDropdown btn_AramaKriteri;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_temizle;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_minFiyat;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_maxFiyat;
        private System.Windows.Forms.Panel panel_fiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectedRowsButton;
    }
}
