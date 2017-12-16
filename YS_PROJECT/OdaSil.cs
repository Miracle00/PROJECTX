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
    public partial class OdaSil : UserControl
    {
        public OdaSil()
        {
            InitializeComponent();
        }
        DB_Operation dbo = new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<String[]> odalar;
        List<String> silinenOdaID;
        private void btn_uygula_Click(object sender, EventArgs e)
        {
            if (dd_fakulteler.selectedIndex != -1 && dd_departmanlar.selectedIndex != -1 && dd_oda.selectedIndex != -1)
            {
                if (dbo.Delete(sqlConnectionString.odaSil, sqlConnectionString.odaSilParametreler, silinenOdaID))
                {
                    pnl_uyari.Visible = true;
                    lbl_uyari.Text = "Oda başarıyla silindi.";
                    pnl_uyari.BackColor = Color.Lime;
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
        private void OdaSil_Load(object sender, EventArgs e)
        {
            FakulteleriGetir();
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
                dd_oda.AddItem(odalar[i][1]);

            }
        }

        private void dd_fakulteler_onItemSelected(object sender, EventArgs e)
        {
            string index = (1 + dd_fakulteler.selectedIndex).ToString();
            List<string> i = new List<string>() { index };
            DepartmanlariGetir(i);
            pnl_uyari.Visible = false;

        }

        private void dd_departmanlar_onItemSelected(object sender, EventArgs e)
        {
            string index = (1 + dd_departmanlar.selectedIndex).ToString();
            List<string> i = new List<string>() { index };
            OdalariGetir(i);
            pnl_uyari.Visible = false;
        }

        private void dd_oda_onItemSelected(object sender, EventArgs e)
        {
            silinenOdaID = new List<string>();
            silinenOdaID.Add(odalar[dd_oda.selectedIndex][0]);
            MessageBox.Show(silinenOdaID.ToString());
            pnl_uyari.Visible = false;
        }
    }
}
