using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_PROJECT
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            i++;
            if (i== 3)
            {
                timer1.Stop();
                login lgn = new login();
                this.Hide();
                lgn.Show();
                
            }
        }
    }
}
