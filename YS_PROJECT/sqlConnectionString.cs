using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YS_PROJECT
{
    public class sqlConnectionString
    {
        public static string kullaniciGirisi = "SELECT * FROM tblKullanicilar WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre";
        public static List<string> kullaniciGirisiParametreler = new List<string>() { "kullaniciAdi", "sifre" };

        public static string fakulteIsimleri = "SELECT * FROM tblFakulteler";
        public static string departmanIsimleri ="SELECT * FROM tblDepartmanlar";
        public static string kullanicilar = "SELECT * FROM tblKullanicilar";

        public static string odaIsimleri = "SELECT * FROM tblOda WHERE departmanID=@departmanID";
        public static List<string> odaIsimleriParametreler = new List<string>() { "departmanID" };

        public static string odaIsimleri2 = "SELECT * FROM tblOda WHERE personelID=@personelID";
        public static List<string> odaIsimleriParametreler2 = new List<string>() { "personelID" };

        public static string personeller = "SELECT * FROM tblPersonel";

        public static string demirbaslar = "SELECT d.demirbasAdi,dt.demirbasTuruAdi,d.fiyat,d.alimTarihi,d.adet FROM tblDemirbas d INNER JOIN tblDemirbasTurleri dt ON d.demirbasTuruID=dt.demirbasTuruID";

        public static string demirbaslar2 = "SELECT * FROM tblDemirbas where demirbasTuruID=@demirbasTuruID";
        public static List<string> demirbaslar2Parametreler = new List<string>() { "demirbasTuruID" };

        public static string demirbasTur = "SELECT * FROM tblDemirbasTurleri";

        public static string odaDemirbasGetir2 = "select * from tblOdaDemirbasAtama ";

        public static string odaSil = "DELETE FROM tblOda where odaID=@odaID";
        public static List<string> odaSilParametreler = new List<string>() { "odaID" };

        public static string dprt = "select * from tblDepartmanlar where fakulteID=@fakulteID";
        public static List<string> fID = new List<string>() { "fakulteID" };

        public static string odaKayit = "INSERT INTO tblOda(odaAdi,departmanID) VALUES(@odaAdi,@departmanID)";
        public static List<string> odaKayitParametreler = new List<string>() { "odaAdi", "departmanID" };


        public static string odaGuncelle = "update tblOda set odaAdi=@odaAdi,departmanID=@departmanID where odaID=@odaID";
        public static List<string> odaGuncelleParam = new List<string>() { "odaAdi", "departmanID", "odaID" };

        public static string odaGuncelle2 = "update tblOda set odaAdi=@odaAdi,departmanID=@departmanID,personelID=@personelID where odaID=@odaID";
        public static List<string> odaGuncelleParam2 = new List<string>() { "odaAdi", "departmanID", "personelID", "odaID" };

        public static string odaGuncelle3 = "update tblOda set personelID=NULL WHERE odaID=@odaID";
        public static List<string> odaGuncelleParam3 = new List<string>() {"odaID" };

        public static string odaGuncelle4 = "update tblOda set personelID=@personelID WHERE odaID=@odaID";
        public static List<string> odaGuncelleParam4 = new List<string>() { "personelID","odaID" };


        public static string odaDemirbasGetir= "select dt.demirbasTuruAdi,d.demirbasAdi,d.aciklama,SUM(oda.adet) from (tblOdaDemirbasAtama oda inner join (tblDemirbas d inner join tblDemirbasTurleri dt on d.demirbasTuruID = dt.demirbasTuruID) on oda.demirbasID=d.demirbasID) inner join tblOda o  on o.odaID=oda.odaID where o.odaID=@odaID GROUP BY d.demirbasID,dt.demirbasTuruAdi,d.demirbasAdi,d.aciklama";
        public static List<string> odaDemirbasGetirParam = new List<string>() { "odaID" };


        // seçilen personel in id sine göre sorumlu olduğu odaların içlerindeki demirbaşları gösteren sql kodu
        public static string personelinDemirbaslari="select o.odaAdi,dt.demirbasTuruAdi,d.demirbasAdi,oda.adet from (tblOdaDemirbasAtama oda inner join (tblDemirbas d inner join tblDemirbasTurleri dt on d.demirbasTuruID=dt.demirbasTuruID) on oda.demirbasID=d.demirbasID) inner join tblOda o  on o.odaID=oda.odaID where o.personelID= @personelID";
        public static List<string> personelID = new List<string>() { "personelID" };

        // personel ekleme
        public static string personelEkle= "Insert into tblPersonel(personelAdi,personelSoyad) values(@personelAdi,@personelSoyad)";
        public static List<string> personelParam = new List<string>() { "personelAdi","personelSoyad" };

        //oda demirbaş ekleme
        public static string odaDemirbasEkle = "Insert into tblOdaDemirbasAtama(odaID,demirbasID,adet) values(@odaID,@demirbasID,@adet)";
        public static List<string> odaDemirbasEkleParametre=new List<string>() { "odaID", "demirbasID", "adet" };

        // kullanici ekleme
        public static string kullaniciEkle = " Insert into tblKullanicilar(personelID,kullaniciAdi,yetkiID,sifre) values (@personelID,@kullaniciAdi,@yetkiID,@sifre)";
        public static List<string> kullaniciParam = new List<string>() { "personelID", "kullaniciAdi","yetkiID","sifre" };

        public static string demirbasEkle = "Insert into tblDemirbas(demirbasAdi,aciklama,fiyat,alimTarihi,demirbasTuruID,fakulteID,departmanID,adet)values(@demirbasAdi,@aciklama,@fiyat,@alimTarihi,@demirbasTuruID,@fakulteID,@departmanID,@adet)";
        public static List<string> demirbasParam = new List<string>() { "demirbasAdi", "aciklama", "fiyat", "alimTarihi", "demirbasTuruID", "fakulteID", "departmanID", "adet" };



        public static string odaDemirbasGetir3 = " select d.fakulteID,d.departmanID,d.demirbasTuruID,d.demirbasID,dt.demirbasTuruAdi,d.demirbasAdi,d.aciklama,oda.adet from (tblOdaDemirbasAtama oda inner join (tblDemirbas d inner join tblDemirbasTurleri dt on d.demirbasTuruID = dt.demirbasTuruID) on oda.demirbasID=d.demirbasID) inner join tblOda o  on o.odaID=oda.odaID where o.odaID=@odaID";
        public static List<string> odaDemirbasGetirParam3 = new List<string>() { "odaID" };

        public static string personelSil = "DELETE FROM tblPersonel where personelID=@personelID";
        public static List<string> personelSilParametreler = new List<string>() { "personelID" };

        public static string kullanciSil = "DELETE FROM tblKullanicilar where personelID=@personelID";
        public static List<string> kullaniciSilParametreler = new List<string>() { "personelID" };
    }
}
