using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Vsite.CSharp.VirtualnaSvojstva;
using System.Reflection;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestVirtualnogSvojstva
    {
        [TestMethod]
        public void VirtualnoSvojstvo_UIzvedenojKlasiBitĆePozvanoNadglasujućeSvojstvo()
        {
            Student s = new Student("Pero", 3);
            Assert.AreEqual("Pero, 3. godina", s.Identifikacija);

            Type tipOsoba = typeof(Student);
            PropertyInfo pi = tipOsoba.GetProperty("Identifikacija");
            Assert.IsNotNull(pi);
            Assert.AreEqual(typeof(Student), pi.DeclaringType);
            MethodInfo mi = pi.GetMethod;
            Assert.IsTrue(mi.IsVirtual);
        }
    }
}
