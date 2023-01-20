using DemoNetCoreAlgorithm.App.QuickSort;

namespace DemoNetCoreAlgorithm.Test
{
    [TestClass]
    public class Test_QuickSort
    {
        [TestMethod("TestMethod1"), Timeout(1_000)]
        public void TestMethod1()
        {
            var len = 10;
            var random = new Random(DateTime.Now.Millisecond);
            var r = new int[len].ToList().Select(s => random.Next(0, 10)).ToArray();
            //var r = new int[] { 0, 9, 5, 5, 5, 7, 1, 4, 7, 4 };
            var v = r.ToList();
            v.Sort();
            //Console.WriteLine("[{0}]", string.Join(", ", r));
            //Console.WriteLine("[{0}]", string.Join(", ", v));
            new Runner().Run(r);
            //Console.WriteLine("[{0}]", string.Join(", ", r));
            for (var i = 0; i < len; ++i)
                Assert.AreEqual(v[i], r[i]);
        }
    }
}