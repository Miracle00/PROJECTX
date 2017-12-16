using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class OdaDemirbasAtama
    {
        private int odaDemirbasAtamaID;
        private Oda odaID;
        private Demirbas demirbasID;
        private int adet;
        private Personel personelID;

        public Personel PersonelID
        {
            get { return personelID; }
            set { personelID = value; }
        }

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        public Demirbas DemirbasID
        {
            get { return demirbasID; }
            set { demirbasID = value; }
        }

        public Oda OdaID
        {
            get { return odaID; }
            set { odaID = value; }
        }

        public int OdaDemirbasAtamaID
        {
            get { return odaDemirbasAtamaID; }
            set { odaDemirbasAtamaID = value; }
        }

    }
}
