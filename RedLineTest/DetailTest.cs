using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedLineProject.Classes;

namespace RedLineTest
{
    [TestClass]
    public class DetailTest
    {
        [TestMethod]
        public void TestCompareGreater()
        {
            Detail x = new Detail(5, 3, 1);
            Detail y = new Detail(4, 2, 1);
            Assert.AreEqual(Detail.CompareDetails(x, y), -1);
        }

        [TestMethod]
        public void TestCompareEqual()
        {
            Detail x = new Detail(5, 5, 1);
            Detail y = new Detail(5, 5, 1);
            Assert.AreEqual(Detail.CompareDetails(x, y), 0);
        }

        [TestMethod]
        public void TestCompareLess()
        {
            Detail x = new Detail(4, 2, 1);
            Detail y = new Detail(5, 3, 1);
            Assert.AreEqual(Detail.CompareDetails(x, y), 1);
        }
    }
}
