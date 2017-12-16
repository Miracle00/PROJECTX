using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class Demirbas
    {
        private int demirbasID;
        private long demirbasKodu;
        private string demirbasAdi;
        private float fiyat;
        private DateTime alimTarihi;
        private DemirbasTur demirbasTurID;
        private Fakulte fakulteID;
        private Departman departmanID;
        private int adet;

        public long DemirbasKodu
        {
            get { return demirbasKodu; }
            set { demirbasKodu = value; }
        }

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        public Departman DepartmanID
        {
            get { return departmanID; }
            set { departmanID = value; }
        }

        public Fakulte FakulteID
        {
            get { return fakulteID; }
            set { fakulteID = value; }
        }

        public DemirbasTur DemirbasTurID
        {
            get { return demirbasTurID; }
            set { demirbasTurID = value; }
        }

        public DateTime AlimTarihi
        {
            get { return alimTarihi; }
            set { alimTarihi = value; }
        }

        public float Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        public string DemirbasAdi
        {
            get { return demirbasAdi; }
            set { demirbasAdi = value; }
        }

        public int DemirbasID
        {
            get { return demirbasID; }
            set { demirbasID = value; }
        }

    }
}
