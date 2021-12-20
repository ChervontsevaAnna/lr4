using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _345test
{
    [TestClass]
    public class Vetochka
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 7, 33, 6, 3, 7 };
            int b = 6;
            int expected = 4;

            int actual = Zuzya.Palochka.Kolvo_elementov(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { };
            int b = 6;
            int expected = 0;

            int actual = Zuzya.Palochka.Kolvo_elementov(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int b = 6;
            int expected = 0;

            int actual = Zuzya.Palochka.Kolvo_elementov(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
