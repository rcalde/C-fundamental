using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
   [TestClass]
    public class ReferenceTest
    {
        [TestMethod]
        public void References()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            
            g1.name = "scott";
            Assert.AreEqual(g1.name, g2.name);
        }
        [TestMethod]
        public void StringReferences()
        {
            string name1 = "Scott";
            string name2 = "scott";
            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TypesPassReferences()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            GiveBookAName(g2);
            Assert.AreEqual("A GradeBook", g1.name);
        }
        [TestMethod]
        public void ValuePassReferences()
        {
            int x = 46;
            incrementNumber(ref x);
            Assert.AreEqual(47,x);
        }

        private void incrementNumber(ref int x)
        {
            x = x + 1;
        }

        private void GiveBookAName(GradeBook g2)
        {
            g2.name = "A GradeBook";
        }
    }
}
