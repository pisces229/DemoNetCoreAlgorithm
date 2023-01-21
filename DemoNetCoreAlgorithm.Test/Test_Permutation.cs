using DemoNetCoreAlgorithm.App.Permutation;

namespace DemoNetCoreAlgorithm.Test
{
    [TestClass]
    public class Test_Permutation
    {
        [TestMethod("TestMethod1"), Timeout(1_000)]
        public void TestMethod1()
        {
            var args = new string[] { "A", "B", "C" };
            var runner = new Runner(args);
            var result = runner.Run();
            Assert.AreEqual(6, result);
        }
    }
}