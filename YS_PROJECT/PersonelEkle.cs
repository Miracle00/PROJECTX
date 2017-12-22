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
    public partial class PersonelEkle : UserControl
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        DB_Operation dbo = new DB_Operation();
        List<String[]> personeller;
        List<String[]> kullanicilar;
        private void btn_yetki_Click(object sender, EventArgs e)
        {
            if(panel1.Visible==false)
                panel1.Visible = true;
            else
                panel1.Visible = false;            
        }
        public bool Kontrol()//PERSONEL AD VE SOYAD KONTROLÜ
        {
            bool flag = false;
            if (TxtKontrol.KarakterKontrol(txt_personelAdi.Text) == false && TxtKontrol.dolulukKontrol(txt_personelAdi.Text) == true && TxtKontrol.uzunlukKontrol(txt_personelAdi.Text) == true)
            {
                if (TxtKontrol.KarakterKontrol(txt_personelSoyadi.Text) == false && TxtKontrol.dolulukKontrol(txt_personelSoyadi.Text) == true && TxtKontrol.uzunlukKontrol(txt_personelSoyadi.Text) == true)
                    flag = true;
                else
                    flag = false;

            }
            else
                flag = false;
                return flag;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string ad = txt_personelAdi.Text.Trim();
            string soyad = txt_personelSoyadi.Text.Trim();
            //string pID="";
            List<string> personelBilgi = new List<string> { ad, soyad };

            if (Kontrol())
            {
                if (Personeller()==0)//PERSONEL EKLENİR.
                {
                    bool flag = dbo.Save(sqlConnectionString.personelEkle, sqlConnectionString.personelParam, personelBilgi);
                    panel_uyari(true);                  
                }
                else if(Personeller()==1)//AYNI PERSONEL VAR.
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Aynı personele sahipsiniz.";
                }
                else if(Personeller()==2)//KULLANICI ALANI DOLUYSA YAPILACAK İŞLEMLER
                {
                    if (cb_admin.Checked == true || cb_nKullanici.Checked == true)
                    {
                        if (TxtKontrol.SayiveyaHarfKontrol(txt_kullaniciAdi.Text) == false && TxtKontrol.dolulukKontrol(txt_kullaniciAdi.Text) == true && TxtKontrol.uzunlukKontrol(txt_kullaniciAdi.Text) == true)
                        {
                            if (TxtKontrol.SayiveyaHarfKontrol(txt_sifre.Text) == false && TxtKontrol.dolulukKontrol(txt_sifre.Text) == true && TxtKontrol.uzunlukKontrol(txt_sifre.Text) == true)
                                KullaniciEkle(true);
                            else
                                KullaniciEkle(false);
                        }
                        else
                            KullaniciEkle(false);
                    }
                    else
                        KullaniciEkle(false);
                }
            }
            else
            {
                panel_uyari(false);
                lbl_uyari.Text = "Personel eklenemedi";
            }


        }
        public void KullaniciEkle(Boolean kontrol)
        {
            if (kontrol == true)
            {
                if (Kullanicilar() == 0)//YENİ EKLENECEK KULLANICI İÇİN DAHA ÖNCE KAYITLI PERSONEL VAR MI KONTROL ET
                {
                    string ad = txt_personelAdi.Text;
                    string soyad = txt_personelSoyadi.Text;
                    List<string> personelBilgi = new List<string> { ad, soyad };
                    personeller = dbo.Select(sqlConnectionString.personeller);
                    Boolean personelKontrol=false;
                    for (int i = 0; i < personeller.Count; i++)
                    {
                        if (personeller[i][1].ToString() == txt_personelAdi.Text && personeller[i][2].ToString() == txt_personelSoyadi.Text)
                        {
                            panel_uyari(false);
                            lbl_uyari.Text = "Aynı personele sahipsiniz.";
                            personelKontrol = true;
                            break;
                        }                     
                    }
                    if(personelKontrol==false)//AYNI PERSONEL YOKSA PERSONEL VE KULLANICIYI EKLE
                    {
                            dbo.Save(sqlConnectionString.personelEkle, sqlConnectionString.personelParam, personelBilgi);
                            string pID = (DB_Operation.sonindex).ToString();
                            string kAd = txt_kullaniciAdi.Text;
                            string sifre = txt_sifre.Text;
                            string yetkiID;
                            if (cb_nKullanici.Checked == true) yetkiID = "0"; else yetkiID = "1";
                            List<string> kullaniciBilgi = new List<string> { pID, kAd, yetkiID, sifre };
                            dbo.Save(sqlConnectionString.kullaniciEkle, sqlConnectionString.kullaniciParam, kullaniciBilgi);
                            panel_uyari(true);
                            lbl_uyari.Text = "Kullanıcı eklendi";
                    }
                   

                }
                else
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Aynı kullanıcıya sahipsiniz.";
                }

            }
            else
            {
                panel_uyari(false);
                lbl_uyari.Text = "Eksik veya hatalı bilgi";
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
        public Byte Personeller()//TÜM PERSONELLERİ ÇEK.
        {
            //AYNI PERSONEL VAR MI KONTROL ET.
            if (txt_kullaniciAdi.Text == "" && txt_sifre.Text == "" && cb_admin.Checked == false && cb_nKullanici.Checked == false)
            {
                personeller = dbo.Select(sqlConnectionString.personeller);
                for (int i = 0; i < personeller.Count; i++)
                {
                    if (personeller[i][1].ToString() == txt_personelAdi.Text && personeller[i][2].ToString() == txt_personelSoyadi.Text)
                    {
                        return 1;
                        break;
                    }

                }
            }
            else
                return 2;

            return 0;
        }
        public Byte Kullanicilar()//TÜM KULLANICILARI ÇEK
        {
            kullanicilar = dbo.Select(sqlConnectionString.kullanicilar);
            for (int i = 0; i < kullanicilar.Count; i++)
            {
                if (kullanicilar[i][2].ToString()==txt_kullaniciAdi.Text)
                {
                    panel_uyari(false);
                    return 1;
                    break;
                }

            }
            return 0;
        }
        private void cb_nKullanici_OnChange(object sender, EventArgs e)//PERSONEL YETKİSİ KULLANICI İSE ADMİNİ FALSE YAP
        {
            cb_admin.Checked = false;
        }

        private void cb_admin_OnChange(object sender, EventArgs e)//PERSONEL YETKİSİ ADMİN İSE KULLANICIYI FALSE YAP.
        {
            cb_nKullanici.Checked = false;
        }

        private void txt_personelAdi_OnValueChanged(object sender, EventArgs e)//PERSONEL ADI DEĞİŞİNCE HATAYI KALDIR
        {
            pnl_uyari.Visible = false;
        }

        private void txt_personelSoyadi_OnValueChanged(object sender, EventArgs e)//PERSONEL SOYADI DEĞİŞİNCE HATAYI KALDIR
        {
            pnl_uyari.Visible = false;
        }

        private void txt_kullaniciAdi_OnValueChanged(object sender, EventArgs e)//KULLANICI ADI DEĞİŞİNCE HATAYI KALDIR
        {
            pnl_uyari.Visible = false;
        }

        private void txt_sifre_OnValueChanged(object sender, EventArgs e)//ŞİFRE DEĞİŞİNCE HATAYI KALDIR
        {
            pnl_uyari.Visible = false;
        }
    }
}
