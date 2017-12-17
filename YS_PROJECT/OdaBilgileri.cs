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
using System.Collections;

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
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0;
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
            List<string[]> dbkodu = new List<string[]>();
            data =dbo.Select(sqlConnectionString.odaDemirbasGetir3, sqlConnectionString.odaDemirbasGetirParam3, sOdaID);
            dbkodu = dbo.Select(sqlConnectionString.odgdbk, sqlConnectionString.odaDemirbasGetirParam3, sOdaID);
            FillGrid(dbkodu,data);
            pnl_uyari.Visible = false;
        }
        public void FillGrid(List<string[]> k,List<string[]> d)
        {
            dataGridView1.Rows.Clear();
                     
            string[] tmp = new string[k.Count];
            string[] tmp2 = new string[5];
            int i = 0;
            foreach (string[] item2 in k)
            {                
                string t = "";
                t += item2[0].ToString();
                t += item2[1].ToString();
                t += item2[2].ToString();
                t += item2[3].ToString();
                tmp[i] = t;
                i += 1;
            }
            i = 0;
            foreach (string[] item in d)
            {
                tmp2[0] = tmp[i];
                tmp2[1] = item[0];
                tmp2[2] = item[1];
                tmp2[3] = item[2];
                tmp2[4] = item[3];

                
                dataGridView1.Rows.Add(tmp2);
                i += 1;
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int iLeftMargin = e.MarginBounds.Left;
                int iTopMargin = e.MarginBounds.Top;
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;
                bFirstPage = true;

                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;


                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }

                while (iRow <= dataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = dataGridView1.Rows[iRow];

                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;

                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {

                            e.Graphics.DrawString("Çıktı Başlığı", new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height - 13);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

                            e.Graphics.DrawString(strDate, new System.Drawing.Font(dataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Çıktı Başlığı", new System.Drawing.Font(new System.Drawing.Font(dataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height - 13);


                            iTopMargin = e.MarginBounds.Top;
                            foreach (DataGridViewColumn GridCol in dataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new System.Drawing.Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;

                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }

                            e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;
                }


                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cikti_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog onizleme = new PrintPreviewDialog();
            ((Form)onizleme).WindowState = FormWindowState.Maximized;
            onizleme.Document = printDocument1;
            onizleme.ShowDialog();
        }
    }
}
