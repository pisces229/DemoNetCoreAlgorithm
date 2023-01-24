using System;

namespace DemoNetCoreAlgorithm.App.EightQueensSwap
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner(4);
            var result = runner.Run();
            Console.WriteLine($"[{result}]");
        }
        private bool _unique = false;
        private int[] _queen;
        private int _resultCount;
        private string[] _solution = Array.Empty<string>();
        public Runner(int args)
        {
            _queen = new int[args];
            for (int i = 0; i < args; i++)
            {
                _queen[i] = i;
            }
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
            if (current == _queen.Length)
            {
                if (_unique)
                {
                    if (!_solution.Contains(string.Join("|", _queen)))
                    {
                        ++_resultCount;
                        Print(_queen);
                        var rotate = new int[_queen.Length];
                        for (var i = 0; i < _queen.Length; ++i)
                            rotate[i] = _queen[i];
                        for (var r = 0; r < 4; ++r)
                        {
                            if (r > 0)
                            {
                                var temp = new int[_queen.Length];
                                for (var i = 0; i < _queen.Length; ++i)
                                {
                                    // counterclockwise
                                    temp[(_queen.Length - 1) - rotate[i]] = i;
                                    // clockwise
                                    //temp[rotate[i]] = (_queen.Length - 1) - i;
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
                                var temp = new int[_queen.Length];
                                for (var i = 0; i < _queen.Length; ++i)
                                    temp[i] = (_queen.Length - 1) - rotate[i];
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
            for (var i = current; i < _queen.Length; ++i)
            {
                (_queen[current], _queen[i]) = (_queen[i], _queen[current]);
                if (Space(current))
                {
                    Do(current + 1);
                }
                (_queen[current], _queen[i]) = (_queen[i], _queen[current]);
            }
        }
        private bool Space(int current)
        {
            for (var i = 0; i < current; ++i)
            {
                if (current - i == Math.Abs(_queen[current] - _queen[i]))
                    return false;
            }
            return true;
        }
        private void Print(int[] content)
        {
            Console.WriteLine();
            foreach (var q in content)
            {
                for (var i = 0; i < content.Length; ++i)
                {
                    Console.Write(q == i ? "Q" : ".");
                }
                Console.WriteLine();
            }
        }
    }
}
