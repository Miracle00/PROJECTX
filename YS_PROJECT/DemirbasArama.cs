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
    public partial class DemirbasArama : UserControl
    {
        public DemirbasArama()
        {
            InitializeComponent();
            TumDemirbaslar();
        }
        List<string[]> data;
        List<string[]> dataID;
        DB_Operation dbo;
        Bunifu.Framework.UI.BunifuTextbox bt_arama;
        Bunifu.Framework.UI.BunifuDatepicker bd_arama;
        List<String[]> odaDemirbasAtama;
        private void btn_AramaKriteri_onItemSelected_2(object sender, EventArgs e)//ARAMA KRİTERİ SEÇİLİRKEN TÜM DEMİRBAŞLAR GÖRÜNSÜN.
        {
            panel_fiyat.Visible = false;
            panel_arama.Visible = true;
            dataGridView1.Rows.Clear();
            FillGrid(data);
       
            if (btn_AramaKriteri.selectedIndex == 0)//DROPDOWN DEMİRBAS ADINA GÖRE ARAMA
            {
                bt_arama = new Bunifu.Framework.UI.BunifuTextbox();
                bt_arama.text = "";
                bt_arama.Size = new Size(185, 42);
                panel_arama.Controls.Clear();
                panel_arama.Controls.Add(bt_arama);
                bt_arama.OnTextChange += new EventHandler(DemirbasAdArama);
            }
            else if (btn_AramaKriteri.selectedIndex == 1)//DROPDOWN DEMİRBAS TURUNE GÖRE ARAMA
            {
                bt_arama = new Bunifu.Framework.UI.BunifuTextbox();
                bt_arama.text = "";
                bt_arama.Size = new Size(185, 42);
                panel_arama.Controls.Clear();
                panel_arama.Controls.Add(bt_arama);
                bt_arama.OnTextChange += new EventHandler(DemirbasTurArama);
            }
            else if (btn_AramaKriteri.selectedIndex == 2)//DROPDOWN MAX-MİN FİYATA GÖRE ARAMA
            {
                panel_arama.Controls.Clear();
                panel_arama.Controls.Add(panel_fiyat);
                panel_fiyat.Visible = true;
                txt_minFiyat.TextChanged += new EventHandler(FiyatArama);
                txt_maxFiyat.TextChanged += new EventHandler(FiyatArama);
            }
            else if (btn_AramaKriteri.selectedIndex == 3)//DROPDOWN ALIM TARİHİNE GÖRE ARAMA
            {
                bd_arama = new Bunifu.Framework.UI.BunifuDatepicker();
                bd_arama.Format = DateTimePickerFormat.Custom;
                bd_arama.FormatCustom = "dd-MM-yyyy";
                bd_arama.onValueChanged+=new EventHandler(alimTarihArama);
                panel_arama.Controls.Clear();
                panel_arama.Controls.Add(bd_arama);
            }
        }

        private void alimTarihArama(object sender, EventArgs e)//ALIM TARİHİ SEÇİLDİĞİNDE GELECEK OLAN VERİLER.
        {
           string gelenTarih;
            string secilenTarih = Convert.ToDateTime(bd_arama.Value).ToString("dd.MM.yyyy");
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                    gelenTarih = Convert.ToDateTime(item[3]).ToString("dd.MM.yyyy");
                    if (gelenTarih.CompareTo(secilenTarih) == 0)
                        dataGridView1.Rows.Add(item);
                }
            
        }

        private void FiyatArama(object sender, EventArgs e)//FİYAT TEXTCHANGE
        {
            /*
             MAX_FİYAT BOŞ OLMASIN ,MİN_FİYAT BOŞ OLMASIN, UZUNLUKLAR MAX=15,ÖRNEK SAYI 1234,3214
             */
            if (txt_maxFiyat.Text != "" && txt_minFiyat.Text != "" && TxtKontrol.uzunlukKontrol(txt_maxFiyat.Text) == true && TxtKontrol.SayiKontrol2(txt_maxFiyat.Text) == true && TxtKontrol.uzunlukKontrol(txt_minFiyat.Text) == true && TxtKontrol.SayiKontrol2(txt_minFiyat.Text) == true)
            {
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                    if (Convert.ToDouble(item[2]) >= Convert.ToDouble(txt_minFiyat.Text) && Convert.ToDouble(item[2]) <= Convert.ToDouble(txt_maxFiyat.Text))
                        dataGridView1.Rows.Add(item);
                }
            }
            /*
             MAX_FİYAT BOŞ OLMASIN ,MİN_FİYAT BOŞ OLSUN
             */
            else if (txt_maxFiyat.Text != "" && txt_minFiyat.Text == "" && TxtKontrol.uzunlukKontrol(txt_maxFiyat.Text) == true && TxtKontrol.SayiKontrol2(txt_maxFiyat.Text))
            {
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                    if (Convert.ToDouble(item[2]) <= Convert.ToDouble(txt_maxFiyat.Text))
                        dataGridView1.Rows.Add(item);
                }
            }
            /*
            MAX_FİYAT BOŞ OLSUN ,MİN_FİYAT BOŞ OLMASIN
            */
            else if (txt_maxFiyat.Text == "" && txt_minFiyat.Text != "" && TxtKontrol.uzunlukKontrol(txt_minFiyat.Text) == true && TxtKontrol.SayiKontrol2(txt_minFiyat.Text) == true)
            {
                dataGridView1.Rows.Clear();
                foreach (var item in data)
                {
                    if (Convert.ToDouble(item[2]) >= Convert.ToDouble(txt_minFiyat.Text))
                        dataGridView1.Rows.Add(item);
                }
            }
        }
        private void DemirbasAdArama(object sender, EventArgs e)//DEMİRBAS AD TEXTCHANGE
        {
            dataGridView1.Rows.Clear();
            foreach (var item in data)
            {
                if (item[0].IndexOf(bt_arama.text) != -1)
                {
                    dataGridView1.Rows.Add(item);
                }
            }
        }
        private void DemirbasTurArama(object sender, EventArgs e)//DEMİRBAS TUR TEXTCHANGE
        {
            dataGridView1.Rows.Clear();
            foreach (var item in data)
            {
                if (item[1].IndexOf(bt_arama.text) != -1)
                {
                    dataGridView1.Rows.Add(item);
                }
            }
        }

        public void FillGrid(List<string[]> data)//Tüm demirbaşları DATAGRIDE BAS.
        {
            dataGridView1.Rows.Clear();
            foreach (string[] rowArray in data)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }
    public void TumDemirbaslar()//TUM DEMİRBASLAR ÇEKİLİYOR.
        {
            dbo = new DB_Operation();
            data = new List<string[]>();
            data = dbo.Select(sqlConnectionString.demirbaslar);
            dataID = new List<string[]>();
            dataID = dbo.Select(sqlConnectionString.demirbaslar3);
            FillGrid(data);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            FillGrid(data);
            panel_arama.Controls.Clear();

        }
         public int KullanılanStokHesaplama(string stokDemirbas)
        {
           odaDemirbasAtama = dbo.Select(sqlConnectionString.odaDemirbasGetir2);
            int kullanılanStok = 0;
            for (int i = 0; i < odaDemirbasAtama.Count; i++)
            {

                if (odaDemirbasAtama[i][2] == stokDemirbas)
                {
                    kullanılanStok += Convert.ToInt16(odaDemirbasAtama[i][3]);
                }

            }
            return kullanılanStok;
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            Int32 selectedRowCount =dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                string selectR = dataGridView1.SelectedRows[0].Index.ToString();
                string stokDemirbasID = dataID[Convert.ToInt32(selectR)][0];
                int toplamDemirbas =Convert.ToInt16(dataID[Convert.ToInt32(selectR)][8]);
                label_stok.Text=(toplamDemirbas-KullanılanStokHesaplama(stokDemirbasID)).ToString();

                        MessageBox.Show(dataID[Convert.ToInt16(selectR)][0].ToString());
            }
            //SUANDA DEMİRBASIN İDSİNİ ÇEKİYORUZ STOK HESAPLAMA ÇAĞIRARAK NE KADAR KALDIĞINI HESAPLIYACAĞIZ OLAY BİTER.
        }
    }
}
