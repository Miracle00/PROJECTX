using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class TxtKontrol
    {
        static Regex reg;
       
        public static Boolean SayiveyaHarfKontrol(string gelenDeger)
        {
            //string Desen = @"^\w*";
            string Desen = @"[^a-z0-9ığüşçö]";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;

        }
        public static Boolean SayiKontrol(string gelenDeger)
        {
            string Desen = @"^\d*$";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;
        }
        public static Boolean dolulukKontrol(string gelenDeger)
        {
            if (gelenDeger!="")
                return true;
            else
                return false;
        }
        public static Boolean uzunlukKontrol(string gelenDeger)
        {
            if (gelenDeger.Length<=15)
                return true;
            else
                return false;
        }
        public static Boolean uzunlukKontrol2(string gelenDeger)
        {
            if (gelenDeger.Length <= 5)
                return true;
            else
                return false;
        }
        public static Boolean KarakterKontrol(string gelenDeger)
        {
            string Desen = @"[^a-zığüşçö]";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;
        }
        public static Boolean KarakterKontrol2(string gelenDeger)
        {
            string Desen = @"[^a-zA-Z0-9IOĞÜŞİÇzığüşçö.,;!=\s]";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;
        }
        public static Boolean SayiKontrol2(string gelenDeger)
        {
            string Desen = @"^[0-9]{1,5}([\,][0-9]{1,5})?$";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;
        }

    }
}

