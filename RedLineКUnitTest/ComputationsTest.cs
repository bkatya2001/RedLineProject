using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RedLineProject.Classes;

namespace RedLineUnitTest
{
    [TestClass]
    public class ComputationsTest
    {
        [TestMethod]
        public void TestCompute()
        {
            Computations computations = new Computations();
            computations.details = new List<Detail> { new Detail(614, 371, 2), new Detail(630, 371, 28), new Detail(630, 414, 30), new Detail(567, 348, 30),
                                                        new Detail(371, 206, 60), new Detail(567, 134, 30), new Detail(598, 206, 30) };
            computations.field = new int[2050, 2780];
            computations.baseDetail = new Detail(2780, 2050, 0);
            computations.edge = 18;
            computations.Compute();
            Assert.AreEqual(computations.baseDetail.GetCount(), 7);
        }
    }
}
