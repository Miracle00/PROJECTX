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
    public partial class DemirbasIslemleri : UserControl
    {
        public DemirbasIslemleri()
        {
            InitializeComponent();
        }
        Boolean yetki;
        public void yetkiKontrol(Boolean yetki)
        {
            this.yetki = yetki;
        }

        private void btn_DemirbasArama_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new DemirbasArama());
        }

        private void btn_DemirbasAtama_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new DemirbasAtama());
        }
    }
}
