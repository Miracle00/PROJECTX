using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YS_PROJECT;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace YS_ProjectTest
{
    [TestClass]
    public class ProjectTest
    {
        [TestMethod]
        public void STOKDBConnection()
        {
            //STOKDB ye bağlantı yapabiliyor mu
            string baglanti = @"Data Source=TOSHIBAPC\SQLEXPRESS;Initial Catalog=StokDB;Integrated Security=True";
            SqlConnection baglan = new SqlConnection(baglanti);
            baglan.Open();
        }

        [TestMethod]
        public void SelectFuncCalisiyormu()
        {
            //fakülteler tablosunda HFTTF varmı?
            DB_Operation db = new DB_Operation();
            List<string[]> ll = db.Select(sqlConnectionString.fakulteIsimleri);            
            Assert.AreEqual("HFTTF", ll[0][1]);
        }

        [TestMethod]
        public void SaveFuncCalisiyormu()
        {
            //personellere veri ekleyebiliyormu ?
            DB_Operation db = new DB_Operation();
            List<string> test = new List<string>() { "XXX", "YYY" };
            bool result = db.Save(sqlConnectionString.personelEkle, sqlConnectionString.personelParam, test);
            Assert.AreEqual(true,result);
        }

    }
}
