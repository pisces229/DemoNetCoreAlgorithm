using System;

namespace DemoNetCoreAlgorithm.App.QuickSort
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner();
            var result = runner.Run(new int[] { 0, 9, 5, 5, 5, 7, 1, 4, 7, 4 });
            Console.WriteLine(string.Join(",", result));
        }
        public int[] Run(int[] args)
        {
            Do(args, 0, args.Length - 1);
            Console.WriteLine(string.Join(",", args));
            return args;
        }
        private void Do(int[] values, int left, int right)
        {
            if (left > right)
            {
                return;
            }
            var pivot = values[(left + right) / 2];
            var start = left;
            var end = right;
            while (start <= end)
            {
                while (start <= end && values[start] < pivot)
                //while (start <= end && values[start] > pivot)
                {
                    ++start;
                }
                while (end >= start && values[end] > pivot)
                //while (end >= start && values[end] < pivot)
                {
                    --end;
                }
                if (start <= end)
                {
                    if (start != end)
                    {
                        (values[start], values[end]) = (values[end], values[start]);
                    }
                    ++start;
                    --end;
                }
            }
            Do(values, left, end);
            Do(values, start, right);
        }
    }
}
