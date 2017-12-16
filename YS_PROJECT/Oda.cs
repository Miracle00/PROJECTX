using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class Oda
    {
        private int odaID;
        private string odaAdi;
        private Departman departmanID;

        public Departman DepartmanID
        {
            get { return departmanID; }
            set { departmanID = value; }
        }

        public string OdaAdi
        {
            get { return odaAdi; }
            set { odaAdi = value; }
        }

        public int OdaID
        {
            get { return odaID; }
            set { odaID = value; }
        }

    }
}
