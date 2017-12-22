using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Demo;

namespace TestDemoMS
{
    [TestClass]
    public class MathsTest
    {
        [TestMethod]
        public void SumTestMethod()
        {
            Demo.Maths first = new Demo.Maths(1, 2);
            int temp = first.suMem();
            Assert.AreEqual(3, temp);
        }
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 4, 7)]
        [DataRow(4, 5, 9)]
        public void SumsTestMethod(int a, int b, int c)
        {
            Demo.Maths example = new Demo.Maths(a, b);
            Assert.AreEqual(c, example.suMem());
        }

    }
}
