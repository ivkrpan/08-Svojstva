using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Reflection;
using static Vsite.CSharp.Definicija;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestDefinicijeSvojstva
    {
        [TestMethod]
        public void Definicija_PrezimeJeSvojstvoKojeSeMožeSamoČitati()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            Assert.AreEqual("Šafranek", o.Prezime);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("Prezime");
            Assert.IsNotNull(pi);
            Assert.IsFalse(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);
        }

        [TestMethod]
        public void Definicija_ImeJeSvojstvoKojeSeMožeČitatiAKodZadavanjaBacaIznimkuZaPraznoIme()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            Assert.AreEqual("Franjo", o.Ime);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("Ime");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);

            try
            {
                o.Ime = "";
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Definicija_DatumRođenjaJeSvojstvoKojeSeMožeČitatiAKodZadavanjaBacaIznimkuZaBudućiDatum()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            o.DatumRođenja = new DateTime(1923, 12, 5);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("DatumRođenja");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);

            try
            {
                o.DatumRođenja = DateTime.Now.AddDays(3);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
