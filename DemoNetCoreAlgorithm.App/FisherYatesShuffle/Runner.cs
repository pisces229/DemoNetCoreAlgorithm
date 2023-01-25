using System;

namespace DemoNetCoreAlgorithm.App.FisherYatesShuffle
{
    public class Runner
    {
        public static void Debug()
        {
            for (var i = 0; i < 20; ++i)
            {
                var runner = new Runner();
                var result = runner.Run();
                Console.WriteLine(string.Join(",", result));
            }
        }
        public Runner()
        { 
        }
        public int[] Run()
        {
            var count = 10;
            var deck = new int[count];
            var random = new Random((int)DateTime.Now.Ticks);
            for (var i = 0; i < count; ++i)
            {
                deck[i] = i + 1;
            }
            for (var i = 0; i < count; ++i)
            {
                var index = random.Next(0, count);
                (deck[count - 1 - i], deck[index]) = (deck[index], deck[count - 1 - i]);
            }
            return deck;
        }
    }
}
