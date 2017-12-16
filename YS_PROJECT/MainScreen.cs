using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_PROJECT
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        List<String[]> kullanici;
        OdaIslemleri OS;
        PersonelIslemleri PI;
        SatinAlimIslemleri SA;
        DemirbasIslemleri DI;
        public MainScreen(List<String[]> kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
            MainScreenYenileme();
        }
        public void MainScreenYenileme()//Kullanıcı girişi yapıldıktran sonra ekranda olacak değişiklikler
        {
            lbl_kullanici.Text += kullanici[0][2];
            panel1.Visible = true;
        }

        private void pBox_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_odaIslem_Click(object sender, EventArgs e)
        {
            panel5.Controls.Clear();
            OS = new OdaIslemleri();
            panel5.Controls.Add(OS);
            //  OS.yetkiKontrol(Convert.ToBoolean(kullanici[0][3]));
            OS.yetkiKontrol(Convert.ToBoolean(true));
            OS.Show();
            NormalRengeDon();
            btn_odaIslem.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }
        public void NormalRengeDon()
        {
            btn_odaIslem.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_demirbasIslem.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_Personel.Normalcolor = Color.FromArgb(255, 1, 179, 227);
            btn_satinAlim.Normalcolor = Color.FromArgb(255, 1, 179, 227);
        }

        private void btn_Personel_Click(object sender, EventArgs e)
        {
            PI = new PersonelIslemleri();
            panel5.Controls.Clear();
            panel5.Controls.Add(PI);
            PI.yetkiKontrol(Convert.ToBoolean(true));
            PI.Show();
            NormalRengeDon();
            btn_Personel.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }

        private void btn_satinAlim_Click(object sender, EventArgs e)
        {
            SA = new SatinAlimIslemleri();
            panel5.Controls.Clear();
            panel5.Controls.Add(SA);
            SA.yetkiKontrol(Convert.ToBoolean(true));
            SA.Show();
            NormalRengeDon();
            btn_satinAlim.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }

        private void btn_demirbasIslem_Click(object sender, EventArgs e)
        {
            DI = new DemirbasIslemleri();
            panel5.Controls.Clear();
            panel5.Controls.Add(DI);
            DI.yetkiKontrol(Convert.ToBoolean(true));
            DI.Show();
            NormalRengeDon();
            btn_demirbasIslem.Normalcolor = Color.FromArgb(255, 0, 172, 209);
        }

    }
}
