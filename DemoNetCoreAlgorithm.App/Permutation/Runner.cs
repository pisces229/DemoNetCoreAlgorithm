using System;

namespace DemoNetCoreAlgorithm.App.Permutation
{
    public class Runner
    {
        public static void Debug()
        {
            //var runner = new Runner(new string[] { "A", "B", "C" });
            //var runner = new Runner(new string[] { "A", "B", "C", "D" });
            var runner = new Runner(new string[] { "A", "B", "C", "D", "E" });
            var result = runner.Run();
            Console.WriteLine($"[{result}]");
        }
        private int _count;
        private string[] _values;
        private int _result;
        public Runner(string[] args) 
        {
            _count = args.Length;
            _values = args;
        }
        public int Run()
        { 
            Do(0);
            return _result;
        }
        private void Do(int current)
        {
            if (current == _count)
            {
                ++_result;
                Console.WriteLine($"[{string.Join(",", _values!)}]");
                return;
            }
            else
            {
                for (var i = current; i < _count; ++i)
                {
                    (_values![i], _values![current]) = (_values![current], _values![i]);
                    Console.WriteLine($">[{string.Join(",", _values!)}]");
                    Do(current + 1);
                    (_values![i], _values![current]) = (_values![current], _values![i]);
                }
            }
        }
    }
}
