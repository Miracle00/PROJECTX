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
    public partial class OdaGuncelle : UserControl
    {
        public OdaGuncelle()
        {
            InitializeComponent();
        }
        DB_Operation dbo = new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<String[]> odalar;
        List<String[]> personeller;
        List<String> gbilgi;
        private void OdaGuncelle_Load(object sender, EventArgs e)
        {
            FakulteleriGetir();
        }
        private void btn_sec_Click(object sender, EventArgs e)
        {
            if (dd_fakulteler.selectedIndex != -1 && dd_departmanlar.selectedIndex != -1 && dd_odalar.selectedIndex != -1)
            {
                panel1.Visible = true;
                panel2.Visible = true;
            }
            else

                pnl_uyari.Visible = true;
        }

        private void btn_uygula_Click_1(object sender, EventArgs e)
        {
            gbilgi = new List<string>();
            string departman;
            string Oda = txt_GuncelOdalar.Text;//güncel oda adı
            if (dd_guncelDepartman.selectedIndex != -1)     //güncel departman      
                departman = departmanlar[dd_guncelDepartman.selectedIndex][0];
            else if (dd_departmanlar.selectedIndex != -1)
                departman = departmanlar[dd_departmanlar.selectedIndex][0];
            else
                departman = "";
             Boolean kontrol = false;
            for (int i = 0; i < odalar.Count; i++)
            {
                if(odalar[i][1]==Oda && odalar[i][2] == departman)
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "Aynı odaya sahipsiniz.";
                    kontrol = true;
                    break;
                }                    
            }

            if (kontrol == false)
            {
                if (dd_odalar.selectedIndex != -1 && departman != "" && Oda != "" && TxtKontrol.SayiveyaHarfKontrol(Oda.ToString()) == false && TxtKontrol.uzunlukKontrol(Oda.ToString()) == true)
                {
                    gbilgi.Add(Oda);
                    gbilgi.Add(departman);
                    gbilgi.Add(odalar[dd_odalar.selectedIndex][0]);//odanın id si
                    if (dbo.Update(sqlConnectionString.odaGuncelle, sqlConnectionString.odaGuncelleParam, gbilgi))
                    {
                        Update();
                    }
                }
                else
                {
                    panel_uyari(false);
                }
            }

        }
        public void Update()
        {
            panel_uyari(true);
            panel1.Visible = false;
            panel2.Visible = false;
            dd_departmanlar.Clear();
            dd_fakulteler.Clear();
            dd_odalar.Clear();
            FakulteleriGetir();

        }
        public void panel_uyari(Boolean x)
        {
            if(x==false)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "İşlem Başarısız !";
                pnl_uyari.BackColor = Color.OrangeRed;
            }
            else if(x==true)
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "Oda güncellendi.";
                pnl_uyari.BackColor = Color.Lime;
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
           
            departmanlar = dbo.Select(sqlConnectionString.dprt, sqlConnectionString.fID, gelenbilgiler);

            for (int i = 0; i < departmanlar.Count; i++)
            {
                dd_departmanlar.AddItem(departmanlar[i][1]);
                dd_guncelDepartman.AddItem(departmanlar[i][1]);

            }
        }
        public void OdalariGetir(List<string> gelenbilgiler)
        {
            dd_odalar.Clear();
           odalar = dbo.Select(sqlConnectionString.odaIsimleri, sqlConnectionString.odaIsimleriParametreler, gelenbilgiler);

            for (int i = 0; i < odalar.Count; i++)
            {
                dd_odalar.AddItem(odalar[i][1]);

            }
        }
        public void PersonelleriGetir(List<string> gelenbilgiler)
        {
            personeller=dbo.Select(sqlConnectionString.personeller);
           
            for (int i = 0; i < personeller.Count; i++)
            {
                dd_GuncelPersonel.AddItem(personeller[i][1]);
                if (gelenbilgiler[0] != "" && personeller[i][0]== gelenbilgiler[0])
                {
                    dd_GuncelPersonel.selectedIndex =i;
                }
               

            }
        }

        private void dd_departmanlar_onItemSelected(object sender, EventArgs e)
        {
            dd_GuncelPersonel.Clear();
            txt_GuncelOdalar.Text="";
            string index =departmanlar[dd_departmanlar.selectedIndex][0].ToString();
            List<string> i = new List<string>() { index };
            OdalariGetir(i);
            dd_guncelDepartman.selectedIndex = dd_departmanlar.selectedIndex;
            pnl_uyari.Visible = false;
            panel1.Visible = false;
        }

        private void dd_fakulteler_onItemSelected(object sender, EventArgs e)
        {
            dd_GuncelPersonel.Clear();
            txt_GuncelOdalar.Text = "";
            dd_guncelDepartman.Clear();
            dd_departmanlar.Clear();
            dd_odalar.Clear();
            string index = (1 + dd_fakulteler.selectedIndex).ToString();
            List<string> i = new List<string>() { index };
            DepartmanlariGetir(i);
            pnl_uyari.Visible = false;
            panel1.Visible = false;
        }

    
        private void dd_odalar_onItemSelected(object sender, EventArgs e)
        {
            dd_GuncelPersonel.Clear();
            txt_GuncelOdalar.Text = "";
            txt_GuncelOdalar.Text = dd_odalar.selectedValue;
            string index = odalar[dd_odalar.selectedIndex][3].ToString();
            List<string> i = new List<string>() { index };
            PersonelleriGetir(i);
            pnl_uyari.Visible = false;
            panel1.Visible = false;

        }
        private void txt_GuncelOdalar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void btn_personelUygula_Click(object sender, EventArgs e)
        {
            gbilgi = new List<string>();
            string departman;
            if (dd_guncelDepartman.selectedIndex != -1)     //güncel departman      
                departman = departmanlar[dd_guncelDepartman.selectedIndex][0];
            else if (dd_departmanlar.selectedIndex != -1)
                departman = departmanlar[dd_departmanlar.selectedIndex][0];
            else
                departman = "";

            if (dd_odalar.selectedIndex != -1 && dd_GuncelPersonel.selectedIndex >= 0 && departman != "")
            {
                gbilgi.Add(personeller[dd_GuncelPersonel.selectedIndex][0].ToString());
                gbilgi.Add(odalar[dd_odalar.selectedIndex][0]);//odanın id si
                if (dbo.Update(sqlConnectionString.odaGuncelle4, sqlConnectionString.odaGuncelleParam4, gbilgi))
                {
                    Update();
                }
            }
            else
            {
                panel_uyari(false);
            }
        }
    }
}
