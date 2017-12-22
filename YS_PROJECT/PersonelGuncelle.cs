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
    public partial class PersonelGuncelle : UserControl
    {
        int kullaniciID;
        public PersonelGuncelle(int kullaniciID)
        {
            this.kullaniciID = kullaniciID;
            InitializeComponent();
            personelGetir();
            kullaniciGetir();
        }
        DB_Operation dbo = new DB_Operation();
        List<string[]> prsnl = new List<string[]>();
        List<string[]> kullanicilar = new List<string[]>();
        List<string[]> odalar = new List<string[]>();
        string pID;
        string adsoyad;
        public void personelGetir()
        {
            prsnl = dbo.Select(sqlConnectionString.personeller);
            foreach (string[] item in prsnl)
            {
                string ad = item[1];
                string soyad = item[2];
                adsoyad = ad + " " + soyad;
                lst_personeller.Items.Add(adsoyad);
            }
        }
        public void odalariGetir(string pID)
        {
            List<string> gelenbilgi = new List<string>() { pID };
            odalar = dbo.Select(sqlConnectionString.odaIsimleri2,sqlConnectionString.odaIsimleriParametreler2,gelenbilgi);
            foreach (string[] item in odalar)
            {               
                lst_odalar.Items.Add(item[1]);
            }
        }
        public void kullaniciGetir()
        {
            kullanicilar = dbo.Select(sqlConnectionString.kullanicilar);
        }
        private void btn_yetki_Click(object sender, EventArgs e)
        {
            if (pnl_yetki.Visible == true)
            {
                pnl_yetki.Visible = false;
            }
            else
                pnl_yetki.Visible = true;
        }

        private void txt_PersonelArama_OnTextChange(object sender, EventArgs e)
        {
            lst_personeller.Items.Clear();
            foreach (string[] item in prsnl)
            {
                string ad = item[1];
                string soyad = item[2];
                adsoyad = ad + " " + soyad;
                if (adsoyad.IndexOf(txt_PersonelArama.text) != -1)
                    lst_personeller.Items.Add(adsoyad);
            }
        }
        public void panel_uyari(Boolean x)//UYARI İŞLEMLERİ
        {
            if (x == false)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "Personel Eklenemedi !";
                pnl_uyari.BackColor = Color.OrangeRed;
            }
            else if (x == true)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "Personel eklendi.";
                pnl_uyari.BackColor = Color.Lime;
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (lst_personeller.SelectedIndex != -1)
            {
                pnl_uyari.Visible = false;
                string[] adsoyad = lst_personeller.SelectedItem.ToString().Split(' ');
                for (int i = 0; i < prsnl.Count; i++)
                {
                    if (prsnl[i][1] == adsoyad[0] && prsnl[i][2] == adsoyad[1])
                    {
                        pID = prsnl[i][0];
                        break;
                    }
                    
                }
                if (pID != "")
                {
                    List<string> gelenbilgi = new List<string>() { pID };
                    for (int j = 0; j < odalar.Count; j++)
                    {
                        List<string> odaKey = new List<string>() { odalar[j][0] };
                        dbo.Update(sqlConnectionString.odaGuncelle3, sqlConnectionString.odaGuncelleParam3, odaKey);
                        
                    }
                    odalariGetir(pID);
                    for (int i = 0; i < kullanicilar.Count; i++)
                    {
                        if (kullanicilar[i][1] == pID)
                        {                       
                          dbo.Delete(sqlConnectionString.kullanciSil, sqlConnectionString.kullaniciSilParametreler, gelenbilgi);
                            break;
                        }
                    }             
                    dbo.Delete(sqlConnectionString.personelSil, sqlConnectionString.personelSilParametreler, gelenbilgi);
                    panel_uyari(true);
                    lbl_uyari.Text = "Personel silindi.";
                    pnl_uyari.Visible = true;
                    lst_personeller.Items.Clear();
                    personelGetir();
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    lst_odalar.Items.Clear();
                    if (Convert.ToInt16(pID) == kullaniciID)
                    {
                        login login1 = new login();
                        login1.Show();
                        this.Hide();
                    }
                    else
                        pID = "";
                        
                        
                }
                else
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Personel silinemedi.";
                    pnl_uyari.Visible = true;
                }
            }
            else
            {
                panel_uyari(false);
                lbl_uyari.Text = "Personel seçilmedi.";
                pnl_uyari.Visible = true;
            }
        }

        private void lst_personeller_SelectedIndexChanged(object sender, EventArgs e)
        {

            pnl_uyari.Visible = false;
            string personelAdSoyad = "";
            string adsoyad = lst_personeller.SelectedItem.ToString();
            for (int i = 0; i < prsnl.Count; i++)
            {
                personelAdSoyad = prsnl[i][1] + " " + prsnl[i][2];
                if (personelAdSoyad==adsoyad)
                {
                    pID = prsnl[i][0];
                    txt_ad.Text = adsoyad[0].ToString();
                    txt_soyad.Text = adsoyad[1].ToString();
                    break;
                }
            }
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                if (kullanicilar[i][1] == pID)
                {
                    pnl_yetki.Visible = false;
                    label1.Visible = true;
                    btn_yetki.Enabled = false;
                    break;
                }
                else
                {
                    btn_yetki.Enabled = true;
                    label1.Visible = false;
                }
            }
            lst_odalar.Items.Clear();
            if (pID!="")
                odalariGetir(pID);
        }

        private void lst_odalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(lst_personeller.SelectedItem.ToString()+" üzerinden "+lst_odalar.SelectedItem.ToString()+" yetksini kaldırmak istediğinizden emin misiniz ?", "Oda yetkisi kaldır", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                List<string> gelenbilgiler=new List<string>() {odalar[lst_odalar.SelectedIndex][0] };
                dbo.Update(sqlConnectionString.odaGuncelle3, sqlConnectionString.odaGuncelleParam3, gelenbilgiler);
                panel_uyari(true);
                lbl_uyari.Text = "Oda kaldırıldı";
                pnl_uyari.Visible = true;
                lst_odalar.Items.Clear();
                odalariGetir(pID);
            }
            
            
        }

        private void cb_nKullanici_OnChange(object sender, EventArgs e)
        {
            cb_admin.Checked = false;
        }

        private void cb_admin_OnChange(object sender, EventArgs e)
        {
            cb_nKullanici.Checked = false;
        }

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text != "" && txt_soyad.Text != "" && (cb_nKullanici.Checked == true || cb_admin.Checked == true))
            {
                if (TxtKontrol.SayiveyaHarfKontrol(txt_kullaniciAdi.Text) == false && TxtKontrol.dolulukKontrol(txt_kullaniciAdi.Text) == true && TxtKontrol.uzunlukKontrol(txt_kullaniciAdi.Text) == true &&
                    TxtKontrol.SayiveyaHarfKontrol(txt_sifre.Text) == false && TxtKontrol.dolulukKontrol(txt_sifre.Text) == true && TxtKontrol.uzunlukKontrol(txt_sifre.Text) == true)
                {
                    string yetkiID;
                    string kAd = txt_kullaniciAdi.Text;
                    string sifre = txt_sifre.Text;
                    Boolean kontrol = false;
                    for (int i = 0; i < kullanicilar.Count; i++)
                    {
                        if (kullanicilar[i][2] == kAd )
                            kontrol = true;
                    }
                    if (kontrol == false)
                    {
                        if (cb_nKullanici.Checked == true) yetkiID = "0"; else yetkiID = "1";
                        List<string> kullaniciBilgi = new List<string> { pID, kAd, yetkiID, sifre };
                        dbo.Save(sqlConnectionString.kullaniciEkle, sqlConnectionString.kullaniciParam, kullaniciBilgi);
                        kullaniciGetir();
                        panel_uyari(true);
                        lbl_uyari.Text = "Kullanıcı eklendi.";
                        pnl_uyari.Visible = true;
                        pnl_yetki.Visible = false;
                        btn_yetki.Enabled = false;
                    }
                    else
                    {
                        panel_uyari(false);
                        lbl_uyari.Text = "Aynı kullanıcı adı.";
                        pnl_uyari.Visible = true;
                    }
                  
                }
                else
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Kullanıcı eklenemedi";
                    pnl_uyari.Visible = true;
                }
            }
        }
    }
}
