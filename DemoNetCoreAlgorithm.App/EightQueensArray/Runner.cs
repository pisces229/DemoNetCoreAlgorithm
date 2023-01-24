using System;

namespace DemoNetCoreAlgorithm.App.EightQueensArray
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner(8);
            var result = runner.Run();
            Console.WriteLine($"[{result}]");
        }
        private int _count;
        private bool _unique = true;
        private bool[] _column;
        private bool[] _rightSlash;
        private bool[] _leftSlash;
        private int[] _queen;
        private int _resultCount;
        private string[] _solution = Array.Empty<string>();
        public Runner(int args)
        {
            _count = args;
            _column = new bool[args];
            _rightSlash = new bool[args * 2 - 1];
            _leftSlash = new bool[args * 2 - 1];
            _queen = new int[args];
        }
        public int Run() 
        {
            Do(0);
            Console.WriteLine();
            if (_unique)
            {
                Console.WriteLine($"unique:[{_resultCount}]");
                Console.WriteLine($"solution:[{_solution.Count()}]");
            }
            else
            {
                Console.WriteLine($"result:[{_resultCount}]");
            }
            return _resultCount;
        }
        private void Do(int current)
        {
            if (current == _count)
            {
                if (_unique)
                {
                    if (!_solution.Contains(string.Join("|", _queen)))
                    {
                        ++_resultCount;
                        Print(_queen);
                        var rotate = new int[_count];
                        for (var i = 0; i < _count; ++i) 
                            rotate[i] = _queen[i];
                        for (var r = 0; r < 4; ++r)
                        {
                            if (r > 0)
                            {
                                var temp = new int[_count];
                                for (var i = 0; i < _count; ++i)
                                {
                                    // counterclockwise
                                    temp[(rotate[i] * -1) + (_count - 1)] = i;
                                    // clockwise
                                    //temp[rotate[i]] = (i * -1) + (_count - 1);
                                }
                                rotate = temp;
                            }
                            if (!_solution.Contains(string.Join("|", rotate)))
                            {
                                Array.Resize(ref _solution, _solution.Length + 1);
                                _solution[^1] = string.Join("|", rotate);
                            }
                            {
                                // mirror
                                var temp = new int[_count];
                                for (var i = 0; i < _count; ++i)
                                    temp[i] = (rotate[i] * -1) + (_count - 1);
                                if (!_solution.Contains(string.Join("|", temp)))
                                {
                                    Array.Resize(ref _solution, _solution.Length + 1);
                                    _solution[^1] = string.Join("|", temp);
                                }
                            }
                        }
                    }
                }
                else
                {
                    ++_resultCount;
                    Print(_queen);
                }
                return;
            }
            for (var i = 0; i < _count; ++i)
            {
                var rightSlashIndex = current + i;
                var leftSlashIndex = (_count - 1) + current - i;
                if (!_column[i] && !_rightSlash[rightSlashIndex] && !_leftSlash[leftSlashIndex])
                {
                    _queen[current] = i;
                    _column[i] = _rightSlash[rightSlashIndex] = _leftSlash[leftSlashIndex] = true;
                    Do(current + 1);
                    _column[i] = _rightSlash[rightSlashIndex] = _leftSlash[leftSlashIndex] = false;
                }
            }
        }
        private void Print(int[] content)
        {
            //Console.WriteLine();
            //foreach (var q in content)
            //{
            //    for (var i = 0; i < _count; ++i)
            //    {
            //        Console.Write(q == i ? "Q" : ".");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
