using System;

namespace DemoNetCoreAlgorithm.App.QuickSort
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner(new int[] { 0, 9, 5, 5, 5, 7, 1, 4, 7, 4 });
            var result = runner.Run();
            Console.WriteLine(string.Join(",", result));
        }
        private int[] _value;
        public Runner(int[] args) 
        { 
            _value = args;
        }
        public int[] Run()
        {
            Do(0, _value.Length - 1);
            Console.WriteLine(string.Join(",", _value));
            return _value;
        }
        private void Do(int left, int right)
        {
            if (left >= right) return;
            var start = left;
            var end = right;
            var pivot = _value[left];
            ++start;
            while (start < end)
            {
                if (_value[start] < pivot)
                {
                    ++start;
                    continue;
                }
                if (_value[end] >= pivot)
                {
                    --end;
                    continue;
                }
                if (_value[start] >= pivot && _value[end] < pivot)
                    (_value[start], _value[end]) = (_value[end], _value[start]);
            }
            if (_value[left] > _value[start])
                (_value[left], _value[start]) = (_value[start], _value[left]);
            Do(left, start - 1);
            Do(start, right);
        }
    }
}
