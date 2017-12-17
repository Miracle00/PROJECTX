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
    public partial class DemirbasAtama : UserControl
    {
        public DemirbasAtama()
        {
            InitializeComponent();
            FakulteleriGetir();
        }
        List<string[]> data;
        DB_Operation dbo = new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<String[]> odalar;
        List<String> sOdaID;
        List<String[]>demirbasTur;
        List<String[]> demirbas;
        List<String[]> odaDemirbasAtama;
        private void btn_sec_Click(object sender, EventArgs e)//FAKULTE-DEPARTMAN VE ODA SEÇİMİ KONTROL
        {
            if (dd_fakulteler.selectedIndex != -1 && dd_departmanlar.selectedIndex != -1 && dd_odalar.selectedIndex != -1)
            {
                dd_demirbasTur.Clear();
                FillGrid();
                DemirbasTurGetir();
                pnl_uyari.Visible = false;
            }
            else
            {
                panel_uyari(false);
            }
            
        }
        public void panel_uyari(Boolean x)//UYARI PANELİ
        {
            if (x == false)//İŞLEM HATALIYSA
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "İşlem Başarısız !";
                pnl_uyari.BackColor = Color.OrangeRed;
            }
            else if (x == true)//İŞLEM DOĞRUYSA
            {
                pnl_uyari.Visible = true;
                lbl_uyari.Text = "Atama başarılı.";
                pnl_uyari.BackColor = Color.Lime;
            }
        }
        public void FillGrid()//TÜM VERİLERİ
        {
            string index = odalar[dd_odalar.selectedIndex][0].ToString();
            int oID = Convert.ToInt32(index);
            sOdaID = new List<string>() { index };
            data = new List<string[]>();
            data = dbo.Select(sqlConnectionString.odaDemirbasGetir, sqlConnectionString.odaDemirbasGetirParam, sOdaID);

            dataGridView1.Rows.Clear();
            foreach (string[] rowArray in data)
            {
                dataGridView1.Rows.Add(rowArray);
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
            departmanlar = dbo.Select(sqlConnectionString.dprt, sqlConnectionString.fID, gelenbilgiler);

            for (int i = 0; i < departmanlar.Count; i++)
            {
                dd_departmanlar.AddItem(departmanlar[i][1]);

            }
        }
        public void OdalariGetir(List<string> gelenbilgiler)
        {
            odalar = dbo.Select(sqlConnectionString.odaIsimleri, sqlConnectionString.odaIsimleriParametreler, gelenbilgiler);

            for (int i = 0; i < odalar.Count; i++)
            {
                dd_odalar.AddItem(odalar[i][1]);

            }
        }
        public void DemirbasGetir(List<string> gelenbilgiler)
        {
            demirbas = dbo.Select(sqlConnectionString.demirbaslar2, sqlConnectionString.demirbaslar2Parametreler, gelenbilgiler);

            for (int i = 0; i < demirbas.Count; i++)
            {
                dd_demirbaslar.AddItem(demirbas[i][1]);

            }
        }
        public void DemirbasTurGetir()
        {
            demirbasTur = dbo.Select(sqlConnectionString.demirbasTur);

            for (int i = 0; i < demirbasTur.Count; i++)
            {
                dd_demirbasTur.AddItem(demirbasTur[i][1]);

            }
        }
        public int KullanılanStokHesaplama()
        {
            odaDemirbasAtama = dbo.Select(sqlConnectionString.odaDemirbasGetir2);
            int kullanılanStok = 0;
            for (int i = 0; i < odaDemirbasAtama.Count; i++)
            {
                
                if (odaDemirbasAtama[i][2] == demirbas[dd_demirbaslar.selectedIndex][0])
                {
                    kullanılanStok += Convert.ToInt16(odaDemirbasAtama[i][3]);
                }

            }
            return kullanılanStok;
        }
        private void dd_fakulteler_onItemSelected(object sender, EventArgs e)
        {

            string index = fakulteler[dd_fakulteler.selectedIndex][0].ToString();
            List<string> i = new List<string>() { index };
            DepartmanlariGetir(i);
            pnl_uyari.Visible = false;

        }

        private void dd_departmanlar_onItemSelected(object sender, EventArgs e)
        {
            dd_odalar.Clear();
            string index = departmanlar[dd_departmanlar.selectedIndex][0].ToString();
            List<string> i = new List<string>() { index };
            OdalariGetir(i);
            pnl_uyari.Visible = false;

        }

        private void dd_demirbasTur_onItemSelected(object sender, EventArgs e)
        {
            dd_demirbaslar.Clear();
            string index = demirbasTur[dd_demirbasTur.selectedIndex][0].ToString();
            List<string> i = new List<string>() { index };
            DemirbasGetir(i);
            pnl_uyari.Visible = false;
        }

        private void dd_demirbaslar_onItemSelected(object sender, EventArgs e)
        {
            int stokMiktari = Convert.ToInt16(demirbas[dd_demirbaslar.selectedIndex][8]) - KullanılanStokHesaplama();
            txt_stokMiktari.Text = stokMiktari.ToString();
            pnl_uyari.Visible=false;
        }

        private void btn_demirbasEkle_Click(object sender, EventArgs e)
        {
            if (dd_fakulteler.selectedIndex != -1 && dd_departmanlar.selectedIndex != -1 && dd_odalar.selectedIndex != -1
                && dd_demirbasTur.selectedIndex != -1 && dd_demirbaslar.selectedIndex != -1)
            {
                if (TxtKontrol.SayiKontrol(txt_adet.Text) && TxtKontrol.dolulukKontrol(txt_adet.Text) && TxtKontrol.uzunlukKontrol2(txt_adet.Text))
                {
                    if (Convert.ToInt16(txt_stokMiktari.Text) > Convert.ToInt32(txt_adet.Text))
                    {                 
                        string secilenDemirbasID = demirbas[dd_demirbaslar.selectedIndex][0];
                        string secilenOdaID = odalar[dd_odalar.selectedIndex][0];
                        List<string> value = new List<string>() { secilenOdaID, secilenDemirbasID, txt_adet.Text };
                        dbo.Select(sqlConnectionString.odaDemirbasEkle, sqlConnectionString.odaDemirbasEkleParametre, value);
                        FillGrid();
                        dd_demirbasTur.Clear();
                        dd_demirbaslar.Clear();
                        txt_stokMiktari.Text = "";
                        txt_adet.Text = "";

                        panel_uyari(true);
                    }
                    else
                    {
                        panel_uyari(false);
                        lbl_uyari.Text = "Adet sayısı fazla";
                    }


                }
                else
                {
                    panel_uyari(false);
                    lbl_uyari.Text = "İşlem başarısız";
                   
                }
            }
            else
            {
                panel_uyari(false);
                lbl_uyari.Text = "İşlem başarısız";
            }
          


        }

        private void dd_odalar_onItemSelected(object sender, EventArgs e)
        {
            pnl_uyari.Visible=false;
        }
    }
}
