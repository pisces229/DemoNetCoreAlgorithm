using System;
using System.Xml.Linq;

namespace DemoNetCoreAlgorithm.App.BinaryTree
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner(new int[] { 5, 7, 1, 2, 9, 4, 8, 6, 3 });
            var result = runner.Run();
            //var runner = new Runner(new int[] { 5, 7, 1, 2, 9, 4, 8, 6, 5 });
            //var result = runner.Run();
            //var runner = new Runner(new int[] { 8, 5, 1, 7, 10, 12 });
            //var result = runner.Run();
            //var runner = new Runner(new int[] { 4, 3, 2, 1, 5 });
            //var result = runner.Run();
            //var runner = new Runner(new int[] { 1, 3, 5, 7, 9, 11, 13, 15 });
            //var result = runner.UniquePreorderBalancRun();
            Console.WriteLine(string.Join(",", result));
        }
        private int[] _value;
        private int _len;
        private List<int> _list;
        private int _count;
        public Runner(int[] args) 
        {
            _value = args;
            _len = _value.Length;
            _list = new List<int>();
        }
        public int[] Run()
        {
            var root = new TreeNode(_value[0]);
            for (var i = 1; i < _len; ++i)
            {
                Create(root, _value[i]);
            }
            Order(root);
            Visit(root);
            Console.WriteLine();
            return _list.ToArray();
        }
        private void Create(TreeNode node, int value)
        {
            if (node.Value >= value)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode(value);
                }
                else
                {
                    Create(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode(value);
                }
                else
                {
                    Create(node.Right, value);
                }
            }
        }
        public int[] UniquePreorderBalancRun()
        {
            var middle = _len / 2;
            var root = new TreeNode(_value[middle]);
            UniquePreorderBalancCreate(root, 0, middle - 1, middle + 1, _len - 1);
            Order(root);
            return _list.ToArray();
        }
        private void UniquePreorderBalancCreate(TreeNode node, int leftStart, int leftEnd, int rightStart, int rightEnd)
        {
            if (leftStart <= leftEnd) 
            {
                var middle = leftStart + ((leftEnd - leftStart) / 2);
                node.Left = new TreeNode(_value[middle]);
                UniquePreorderBalancCreate(node.Left, leftStart, middle - 1, middle + 1, leftEnd);
            }
            if (rightStart <= rightEnd)
            {
                var middle = rightStart + ((rightEnd - rightStart) / 2);
                node.Right = new TreeNode(_value[middle]);
                UniquePreorderBalancCreate(node.Right, rightStart, middle - 1, middle + 1, rightEnd);
            }
        }
        private void Order(TreeNode? node)
        {
            if (node != null)
            {
                Order(node.Left);
                _list.Add(node.Value);
                Order(node.Right);
            }
        }
        private void Visit(TreeNode? node)
        {
            if (node != null)
            {
                Console.Write($"{node.Value},");
                Visit(node.Left);
                if (node.Left == null && node.Right != null)
                {
                    Console.Write("null,");
                }
                Visit(node.Right);
                if (node.Left != null && node.Right == null)
                {
                    Console.Write("null,");
                }
            }
        }
        private class TreeNode
        { 
            public int Value;
            public TreeNode? Left;
            public TreeNode? Right;
            public TreeNode(int value, TreeNode? left = null, TreeNode? right = null)
            { 
                Value = value;
                Left = left;
                Right = right;
            }
        }
    }
}
