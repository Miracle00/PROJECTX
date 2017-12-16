using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class Departman
    {
        private int departmanID;
        private string departmanAdi;
        private Fakulte fakulteID;

        public Fakulte FakulteID
        {
            get { return fakulteID; }
            set { fakulteID = value; }
        }

        public string DepartmanAdi
        {
            get { return departmanAdi; }
            set { departmanAdi = value; }
        }

        public int DepartmanID
        {
            get { return departmanID; }
            set { departmanID = value; }
        }

    }
}
