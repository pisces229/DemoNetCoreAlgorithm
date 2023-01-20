using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNetCoreAlgorithm.App.QuickSort
{
    public class Runner
    {
        public void Debug()
        { 
        }
        public int[] Run(int[] r)
        {
            Do(r, 0, r.Length - 1);
            return r;
        }
        private void Do(int[] r, int left, int right)
        {
            if (left >= right) return;
            var start = left;
            var end = right;
            var pivot = r[left];
            ++start;
            while (start < end)
            {
                if (r[start] < pivot)
                {
                    ++start;
                    continue;
                }
                if (r[end] >= pivot)
                {
                    --end;
                    continue;
                }
                if (r[start] >= pivot && r[end] < pivot)
                    (r[start], r[end]) = (r[end], r[start]);
            }
            if (r[left] > r[start])
                (r[left], r[start]) = (r[start], r[left]);
            Do(r, left, start - 1);
            Do(r, start, right);
        }
    }
}
