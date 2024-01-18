using System;

namespace DemoNetCoreAlgorithm.App.TowerOfHanoi
{
    public class Runner
    {
        public static void Debug()
        {
            for (int i = 1; i < 5; i++)
            {
                var runner = new Runner(i);
                var result = runner.Run();
                Console.WriteLine($"[{result}]");
            }
        }
        private readonly int _count = 0;
        private int _result = 0;
        public Runner(int args) 
        {
            _count = args;
        }
        public int Run()
        {
            var n = _count; // 設定圓盤的數量
            var source = 'A';
            var auxiliary = 'B';
            var target = 'C';
            // 將 source 移動到 target 
            Do(n, source, target, auxiliary);
            Console.WriteLine($"..................................................");
            return _result;
        }
        private void Do(int n, char source, char target, char auxiliary)
        {
            if (n > 0)
            {
                // 將 n - 1 個圓盤從 source 移動到 auxiliary 
                Do(n - 1, source, auxiliary, target);
                // 將最後的圓盤從 source 移動到 target
                Console.WriteLine($"Move disk {n} from {source} to {target}");
                _result++;
                // 將 auxiliary 移動到 target 
                Do(n - 1, auxiliary, target, source);
            }
        }
    }
}
