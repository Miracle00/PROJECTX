using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YS_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        List<String[]> kullanici;
        Boolean yetki;
        private void btn_login_Click(object sender, EventArgs e)//LOGİN BUTONU İŞLEVLERİ
        {
            string kullaniciAdi;
            string sifre;
            //KULLANICI ADI: ÖZEL KARAKTER-DOLULUK-UZUNLUK KONTROLÜ
            if (TxtKontrol.SayiveyaHarfKontrol(txt_kullanciAdi.Text) == true && TxtKontrol.dolulukKontrol(txt_kullanciAdi.Text) == true && TxtKontrol.uzunlukKontrol(txt_kullanciAdi.Text) == true)
            {
                kullaniciAdi = txt_kullanciAdi.Text;
                //ŞİFRE: ÖZEL KARAKTER-DOLULUK-UZUNLUK KONTROLÜ
                if (TxtKontrol.SayiveyaHarfKontrol(txt_sifre.Text) == true && TxtKontrol.dolulukKontrol(txt_sifre.Text) == true && TxtKontrol.uzunlukKontrol(txt_sifre.Text) == true)
                {
                    sifre = txt_sifre.Text;
                    baglan(kullaniciAdi, sifre);
                } 
                else
                    pnl_uyari.Visible = true;
            } 
            else
                pnl_uyari.Visible = true;
                                     
        }
        //SQL CONNECTİON
        public void baglan(string kullaniciAdi,string sifre)
        {
            DB_Operation dbo = new DB_Operation();
            List<String> gelenBilgiler = new List<string>() { kullaniciAdi, sifre };

            kullanici = dbo.Select(sqlConnectionString.kullaniciGirisi, sqlConnectionString.kullaniciGirisiParametreler, gelenBilgiler);
            if (kullanici.Count > 0)
            {
                MainScreen ms = new MainScreen(kullanici);
                ms.Show();
                this.Hide();

            }

            else
            {
                pnl_uyari.Visible = true;
            }

        }
        private void pBox_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void txt_kullanciAdi_OnValueChanged(object sender, EventArgs e)
        {
            pnl_uyari.Visible = false;
        }

        private void txt_sifre_OnValueChanged(object sender, EventArgs e)
        {
            pnl_uyari.Visible = false;
        }
    }
}
