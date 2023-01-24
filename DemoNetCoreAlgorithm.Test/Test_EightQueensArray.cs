﻿using DemoNetCoreAlgorithm.App.EightQueensArray;

namespace DemoNetCoreAlgorithm.Test
{
    [TestClass]
    public class Test_EightQueensArray
    {
        [TestMethod("TestMethod1"), Timeout(1_000)]
        public void TestMethod1()
        {
            var runner = new Runner(8);
            var result = runner.Run();
            Assert.AreEqual(12, result);
        }
    }
}
