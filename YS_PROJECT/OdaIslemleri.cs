using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_PROJECT
{
    public partial class OdaIslemleri : UserControl
    {
        public OdaIslemleri()
        {
            InitializeComponent();
            
        }
        Boolean yetki;
       public void yetkiKontrol(Boolean yetki)
        {
            this.yetki = yetki;
        }
        private void btn_OdaEkle_Click(object sender, EventArgs e)
        {
            
            panel2.Controls.Clear();
            if (yetki == false)
                MessageBox.Show("Bu alana erişiminiz yok !");
            else
                panel2.Controls.Add(new OdaEkle());

            btn_OdaEkle.Normalcolor = Color.FromArgb(255,36, 129, 77);
            btn_guncelle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_sil.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_bilgiler.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new OdaSil());

            btn_sil.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_guncelle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_OdaEkle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_bilgiler.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new OdaGuncelle());

            btn_guncelle.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_OdaEkle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_sil.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_bilgiler.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }

        private void btn_bilgiler_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new OdaBilgileri());

            btn_bilgiler.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_guncelle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_sil.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_OdaEkle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }
    }
}
