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
    public partial class OdaEkle : UserControl
    {
        public OdaEkle()
        {
            InitializeComponent();
            FakulteleriGetir();
         
        }
        DB_Operation dbo = new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<String[]> odalar;
     
        private void btn_uygula_Click(object sender, EventArgs e)
        {
            if (dd_departmanlar.selectedIndex != -1)
            {
                string dAdi = dd_departmanlar.selectedValue;
                if (TxtKontrol.dolulukKontrol(txt_OdaAd.Text) == true && TxtKontrol.SayiveyaHarfKontrol(txt_OdaAd.Text) == false && TxtKontrol.uzunlukKontrol(txt_OdaAd.Text) == true)
                {
                    string oAdi = txt_OdaAd.Text;
                    Boolean odaKontrol = false;
                    string dindex = departmanlar[dd_departmanlar.selectedIndex][0].ToString();
                    OdalariGetir(dindex);
                    for (int i = 0; i < odalar.Count; i++)
                    {

                        if (odalar[i][1].ToString() == oAdi)
                        {
                            pnl_uyari.Visible = true;
                            pnl_uyari.BackColor = Color.OrangeRed;
                            lbl_uyari.Text = "Aynı odaya sahipsiniz.";
                            odaKontrol = true;
                            break;
                        }
                    }
                    if (odaKontrol == false)
                    {
                        List<string> gbilgi = new List<string>() { oAdi, dindex };
                        bool isSave = dbo.Save(sqlConnectionString.odaKayit, sqlConnectionString.odaKayitParametreler, gbilgi);
                        if (isSave)
                        {
                            pnl_uyari.Visible = true;
                            lbl_uyari.Text = "Oda başarıyla eklendi.";
                            pnl_uyari.BackColor = Color.Lime;
                        }
                    }

                }
                else
                {
                    pnl_uyari.Visible = true;
                    lbl_uyari.Text = "İşlem Başarısız !";
                    pnl_uyari.BackColor = Color.OrangeRed;
                }


            }
            else
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "İşlem Başarısız !";
                pnl_uyari.BackColor = Color.OrangeRed;
            }
                



        }
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
            departmanlar = dbo.Select(sqlConnectionString.dprt, sqlConnectionString.fID,gelenbilgiler);
            
            for (int i = 0; i < departmanlar.Count; i++)
            {
                dd_departmanlar.AddItem(departmanlar[i][1]);
                
            }
        }
        public void OdalariGetir(string dindex)
        {
            List<String>bilgi = new List<String>() {dindex};
            odalar = dbo.Select(sqlConnectionString.odaIsimleri,sqlConnectionString.odaIsimleriParametreler, bilgi);
           


        }
        private void dd_fakulteler_onItemSelected(object sender, EventArgs e)
        {
            
            string index = (1+dd_fakulteler.selectedIndex).ToString();
            List<string> i = new List<string>() {index};
            DepartmanlariGetir(i);
            pnl_uyari.Visible = false;
        }

        private void dd_departmanlar_onItemSelected(object sender, EventArgs e)
        {
            pnl_uyari.Visible = false;
        }
    }
}
