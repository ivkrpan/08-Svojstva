using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using static Vsite.CSharp.ReferentniTipovi;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestSvojstvaReferentnogTipa
    {
        [TestMethod]
        public void ReferentniTipovi_GetSvojstvoVraćaKopijuPaOnemogućujePromjenuSadržaja()
        {
            Smočnica s = new Smočnica();
            int brojNamirnica = s.Namirnice.Count();
            s.Namirnice.Add("kulen");
            Assert.AreEqual(brojNamirnica, s.Namirnice.Count());
        }
    }
}
