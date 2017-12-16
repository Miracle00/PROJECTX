using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
namespace YS_PROJECT
{
    public partial class OdaBilgileri : UserControl
    {
        public OdaBilgileri()
        {
            InitializeComponent();
            FakulteleriGetir();
        }
        DB_Operation dbo=new DB_Operation();
        List<String[]> fakulteler;
        List<String[]> departmanlar;
        List<String[]> odalar;
        List<String[]> personeller;
        List<String> sOdaID;

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
                bunifuDropdown1.AddItem(odalar[i][1]);

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
            bunifuDropdown1.Clear();
            string index = departmanlar[dd_departmanlar.selectedIndex][0].ToString();
            List<string> i = new List<string>() { index };
            OdalariGetir(i);
            pnl_uyari.Visible = false;
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            txtPersonelAd.Text = "";
            string index = odalar[bunifuDropdown1.selectedIndex][0].ToString() ;
            int oID = Convert.ToInt32(index);
            sOdaID = new List<string>() { index };

            personeller = dbo.Select(sqlConnectionString.personeller);
            for (int i = 0; i <odalar.Count; i++)
            {               
                if (odalar[i][0] ==index)
                {
                    for (int j = 0; j < personeller.Count; j++)
                    {
                        if (odalar[i][3] == personeller[j][0])
                            txtPersonelAd.Text = personeller[j][1].ToString();
                    }
                    
                }
            }

            List<string[]> data = new List<string[]>();
            data=dbo.Select(sqlConnectionString.odaDemirbasGetir3, sqlConnectionString.odaDemirbasGetirParam3, sOdaID);

            FillGrid(data);
            pnl_uyari.Visible = false;
        }
        public void FillGrid(List<string[]> d)
        {
            dataGridView1.Rows.Clear();
           
            List<string[]> ltemp = new List<string[]>();
            foreach (string[] item in d)
            { string[] tmp = new string[5];
                
                    string t="";
                    t += item[0].ToString();
                    t += item[1].ToString();
                    t += item[2].ToString();
                    t += item[3].ToString();
                tmp[0] = t;
                tmp[1] = item[4];
                tmp[2] = item[5];
                tmp[3] = item[6];
                tmp[4] = item[7];
                ltemp.Add(tmp);

            }

            foreach (string[] rowArray in ltemp)
            {
                dataGridView1.Rows.Add(rowArray);
                
            }
        }

        private void btn_uygula_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                Excel.Application excel = new Excel.Application();
                excel.Visible = true;
                object Missing = Type.Missing;
                Workbook workbook = excel.Workbooks.Add(Missing);
                Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }
                StartRow++;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {

                        Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        myRange.Select();


                    }
                }
            }
            else
            {
                panel_uyari(false);
            }

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
                lbl_uyari.Text = "Çıktı alındı.";
                pnl_uyari.BackColor = Color.Lime;
            }
        }
    }
}
