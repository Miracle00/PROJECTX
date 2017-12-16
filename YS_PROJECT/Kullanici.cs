using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class Kullanici
    {
        private int kullaniciID;
        private string kullaniciAdi;
        private Personel personelID;
        private byte yetkiID;
        private string sifre;

        //FONKSİYONLAR BURAYA YAZILACAK



        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }


        public byte YetkiID
        {
            get { return yetkiID; }
            set { yetkiID = value; }
        }

        public string KullaniciAdi
        {
            get { return kullaniciAdi; }
            set { kullaniciAdi = value; }
        }

        public Personel PersonelID
        {
            get { return personelID; }
            set { personelID = value; }
        }

        public int KullaniciID
        {
            get { return kullaniciID; }
            set { kullaniciID = value; }
        }

    }
}
