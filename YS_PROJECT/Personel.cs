using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class Personel
    {
        private int personelID;
        private string personelAdi;
        private string personelSoyadi;

        public string PersonelSoyadi
        {
            get { return personelSoyadi; }
            set { personelSoyadi = value; }
        }

        public string PersonelAdi
        {
            get { return personelAdi; }
            set { personelAdi = value; }
        }

        public int PersonelID
        {
            get { return personelID; }
            set { personelID = value; }
        }

    }
}
