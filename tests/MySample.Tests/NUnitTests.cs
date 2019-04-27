using MySample.ClassLibrary;
using NUnit.Framework;

namespace MySample.NUnitTests
{
    public class NUnitTests
    {
        [TestCase(1,2,3)]
        [TestCase(2,3,5)]
        [TestCase(3,3,6)]
        public void AddTestInt(int x, int y, int z)
        {
            Assert.AreEqual(ImportantLib.Add(x, y), z);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 3, 6)]
        public void AddTest(double x, double y, double z)
        {
            Assert.AreEqual(ImportantLib.Add(x, y), z);
        }

        [TestCase(3, 2, 1)]
        [TestCase(5, 3, 2)]
        [TestCase(6, 3, 3)]
        public void SubstractTest(int x, int y, int z)
        {
            Assert.AreEqual(ImportantLib.Substract(x, y), z);
        }

        [TestCase(-3, 3)]
        [TestCase(-5, 5)]
        public void PartialTest(int x, int y)
        {
            Assert.AreEqual(ImportantLib.PartiallyTestedCode(x), y);
        }
    }
}