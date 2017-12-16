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
            string Desen = @"^\w*$";
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
        public static Boolean KarakterKontrol(string gelenDeger)
        {
            string Desen = @"[^A-Za-z]";
            reg = new Regex(Desen);
            if (reg.IsMatch(gelenDeger))
                return true;
            else
                return false;
        }
        
    }
}

