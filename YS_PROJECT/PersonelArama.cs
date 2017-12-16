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
    public partial class PersonelArama : UserControl
    {
        public PersonelArama()
        {
            InitializeComponent();
            personelGetir();
        }
        DB_Operation dbo = new DB_Operation();
        List<string[]> prsnl = new List<string[]>();
        
        string adsoyad;
        public void personelGetir()
        {
            prsnl = dbo.Select(sqlConnectionString.personeller);
            foreach (string[] item in prsnl)
            {
                string ad=item[1];
                string soyad =item[2];
                adsoyad = ad + " " + soyad;
                listBox1.Items.Add(adsoyad);
            }           
        }
        void FillGrid(List<string[]> d)
        {
            dataGridView1.Rows.Clear();
            foreach (string[] rowArray in d)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }

        private void txt_PersonelArama_OnTextChange(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string[] item in prsnl)
            {
                string ad = item[1];
                string soyad = item[2];
                adsoyad = ad + " " + soyad;
                if(adsoyad.IndexOf(txt_PersonelArama.text)!=-1)
                listBox1.Items.Add(adsoyad);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string adsoyad=listBox1.SelectedItem.ToString();
           string[] tmp = adsoyad.Split(' ');
           string id="";
           
            foreach (string[] item in prsnl)
            {
                if (item[1] == tmp[0] && item[2] == tmp[1]) id = item[0];
            }
            List<string> pID = new List<string> { id };
            List<string[]> data = dbo.Select(sqlConnectionString.personelinDemirbaslari, sqlConnectionString.personelID, pID);
            FillGrid(data);
        }

        private void PersonelArama_Load(object sender, EventArgs e)
        {

        }
    }
}