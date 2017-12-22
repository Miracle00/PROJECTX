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
    public partial class PersonelIslemleri : UserControl
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }
        Boolean yetki;
        List<String[]> kullanici;
        yetkiUyari yu = new yetkiUyari();
        public void yetkiKontrol(List<String[]> kullanici)
        {
            this.kullanici = kullanici;
            this.yetki =Convert.ToBoolean(kullanici[0][3]);
        }
        Label erisim = new Label();
        private void btn_PersonelArama_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new PersonelArama());

            btn_PersonelArama.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_PersonelEkle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_PersonelGuncelle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }

        private void btn_PersonelEkle_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            if (yetki == false)
            { panel2.Controls.Add(new yetkiUyari()); }
            else
            {
                panel2.Controls.Add(new PersonelEkle());
            }
          


            btn_PersonelEkle.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_PersonelArama.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_PersonelGuncelle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }

        private void btn_PersonelGuncelle_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            if (yetki == false)
            {
                panel2.Controls.Add(new yetkiUyari());
            }
            else
            {
                panel2.Controls.Add(new PersonelGuncelle(Convert.ToInt16(kullanici[0][1])));
            }

            btn_PersonelGuncelle.Normalcolor = Color.FromArgb(255, 36, 129, 77);
            btn_PersonelEkle.Normalcolor = Color.FromArgb(255, 46, 139, 87);
            btn_PersonelArama.Normalcolor = Color.FromArgb(255, 46, 139, 87);
        }
           
    }
}
