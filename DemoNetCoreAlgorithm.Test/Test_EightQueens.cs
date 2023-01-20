using DemoNetCoreAlgorithm.App.EightQueens;

namespace DemoNetCoreAlgorithm.Test
{
    [TestClass]
    public class Test_EightQueens
    {
        [TestMethod("TestMethod1"), Timeout(1_000)]
        public void TestMethod1()
        {
            var result = new Runner().Run(8, false);
            Assert.AreEqual(92, result);
        }
        [TestMethod("TestMethod2"), Timeout(1_000)]
        public void TestMethod2()
        {
            var result = new Runner().Run(8, true);
            Assert.AreEqual(12, result);
        }
    }
}
