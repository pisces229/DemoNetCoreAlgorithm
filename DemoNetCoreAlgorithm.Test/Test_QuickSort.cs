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
            var args = new int[len].ToList().Select(s => random.Next(0, 10)).ToArray();
            //var args = new int[] { 0, 9, 5, 5, 5, 7, 1, 4, 7, 4 };
            var success = args.ToList();
            success.Sort();
            var runner = new Runner();
            var result = runner.Run(args);
            Console.WriteLine(string.Join(",", args));
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine(string.Join(",", success));
            for (var i = 0; i < len; ++i)
            {
                Assert.AreEqual(success[i], result[i]);
            }
        }
    }
}