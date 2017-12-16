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
            string aciklama = txt_aciklama.Text;
            string fiyat = txt_demirbasFiyat.Text;
            string adet = txt_demirbasAdet.Text;
            string tarih = Convert.ToDateTime(dp_alimTarihi.Value).ToString("dd.MM.yyyy");

            MessageBox.Show(demirbasAdi + " " + aciklama + " " + fiyat + " " + tarih + " " + dtindex + " " + fID + " " + dindex + " " + adet);
            List<string> demirbasBilgi = new List<string> { demirbasAdi, aciklama, fiyat, tarih, dtindex, fID, dindex, adet };
            bool flag = dbo.Save(sqlConnectionString.demirbasEkle, sqlConnectionString.demirbasParam, demirbasBilgi);
            if (flag)
                MessageBox.Show("demirbas eklendi");
            else
                MessageBox.Show("demirbas eklenmedi");
        }

        private void dd_fakulteler_onItemSelected_1(object sender, EventArgs e)
        {
            string index = (1 + dd_fakulteler.selectedIndex).ToString();
            fID = index;
            List<string> i = new List<string>() { index };
            DepartmanlariGetir(i);
        }
    }
}

