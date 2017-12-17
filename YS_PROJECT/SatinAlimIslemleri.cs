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
    public partial class SatinAlimIslemleri : UserControl
    {
        public SatinAlimIslemleri()
        {
            InitializeComponent();
            FakulteleriGetir();
        }
        Boolean yetki;
        string fID = "";
        public void yetkiKontrol(Boolean yetki)
        {
            this.yetki = yetki;
        }
        DB_Operation dbo = new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<string[]> demirbasTurleri;
        public void FakulteleriGetir()
        {
            fakulteler = dbo.Select(sqlConnectionString.fakulteIsimleri);
            for (int i = 0; i < fakulteler.Count; i++)
            {
                dd_fakulteler.AddItem(fakulteler[i][1]);
            }

        }
        public void DepartmanlariGetir(List<string> gelenbilgiler)
        {
            dd_departmanlar.Clear();
            departmanlar = dbo.Select(sqlConnectionString.dprt, sqlConnectionString.fID, gelenbilgiler);

            for (int i = 0; i < departmanlar.Count; i++)
            {
                dd_departmanlar.AddItem(departmanlar[i][1]);

            }
            DemirbasTuruGetir();
        }

        public void DemirbasTuruGetir()
        {
            demirbasTurleri = dbo.Select(sqlConnectionString.demirbasTur);
            foreach (string[] item in demirbasTurleri)
            {
                dd_demirbasTur.AddItem(item[1]);
            }
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (dd_departmanlar.selectedIndex != -1 && dd_fakulteler.selectedIndex != -1 && dd_demirbasTur.selectedIndex != -1 &&
                TxtKontrol.KarakterKontrol(txt_demirbasAdi.Text) == false && TxtKontrol.dolulukKontrol(txt_demirbasAdi.Text) == true &&
                txt_demirbasAdi.Text.Length <= 30)
            {
                string dAdi = dd_departmanlar.selectedValue;
                string dtAdi = dd_demirbasTur.selectedValue;
                string dindex = "";
                string dtindex = "";
                foreach (string[] item in departmanlar)
                {
                    if (item[1] == dAdi)
                        dindex = item[0];
                }
                foreach (string[] item in demirbasTurleri)
                {
                    if (item[1] == dtAdi)
                        dtindex = item[0];
                }
                string demirbasAdi = txt_demirbasAdi.Text;
                string aciklama = "";
                string fiyat = txt_demirbasFiyat.Text;
                string adet = txt_demirbasAdet.Text;
                string tarih = dp_alimTarihi.Text;
                if (TxtKontrol.dolulukKontrol(txt_aciklama.Text) == true && txt_aciklama.Text.Length <= 200 && TxtKontrol.KarakterKontrol(txt_aciklama.Text) == false)
                    aciklama = txt_aciklama.Text;
                else
                    aciklama = "";
                if (TxtKontrol.SayiKontrol(txt_demirbasFiyat.Text) == true && TxtKontrol.uzunlukKontrol(txt_demirbasFiyat.Text) == true && TxtKontrol.dolulukKontrol(txt_demirbasFiyat.Text) == true &&
                    TxtKontrol.SayiKontrol(txt_demirbasAdet.Text) == true && TxtKontrol.uzunlukKontrol(txt_demirbasAdet.Text) == true && TxtKontrol.dolulukKontrol(txt_demirbasAdet.Text) == true)
                {
                    MessageBox.Show(demirbasAdi + " " + aciklama + " " + fiyat + " " + tarih + " " + dtindex + " " + fID + " " + dindex + " " + adet);
                    List<string> demirbasBilgi = new List<string> { demirbasAdi, aciklama, fiyat, tarih, dtindex, fID, dindex, adet };
                    bool flag = dbo.Save(sqlConnectionString.demirbasEkle, sqlConnectionString.demirbasParam, demirbasBilgi);
                    if (flag)
                    {
                        panel_uyari(true);
                        lbl_uyari.Text = "Satın alım başarılı.";
                    }
                    else
                    {
                        panel_uyari(false);
                        lbl_uyari.Text = "Eksik veya hatalı bilgi";
                    }
                }
                else
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Eksik veya hatalı bilgi";
                }
            }
            else
            {
                panel_uyari(false);
                lbl_uyari.Text = "Eksik veya hatalı bilgi";
            }
          
           

         
        }

        private void dd_fakulteler_onItemSelected_1(object sender, EventArgs e)
        {
            string index = (1 + dd_fakulteler.selectedIndex).ToString();
            fID = index;
            List<string> i = new List<string>() { index };
            DepartmanlariGetir(i);
        }
        public void panel_uyari(Boolean x)
        {
            if (x == false)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "İşlem Başarısız !";
                pnl_uyari.BackColor = Color.OrangeRed;
            }
            else if (x == true)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "Oda güncellendi.";
                pnl_uyari.BackColor = Color.Lime;
            }
        }

        private void SatinAlimIslemleri_Load(object sender, EventArgs e)
        {
            dp_alimTarihi.Text= DateTime.Now.ToShortDateString();
        }
    }
}

