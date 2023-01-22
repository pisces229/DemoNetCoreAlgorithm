using System;

namespace DemoNetCoreAlgorithm.App.BinaryTreeTraversal
{
    public class Runner
    {
        public static void Debug()
        {
            var runner = new Runner();
            runner.RunPreorderTraversal();
            runner.RunInorderTraversal();
            runner.RunPostorderTraversal();
            runner.RunLevelOrderTraversal();
        }
        private readonly TreeNode root;
        public Runner() 
        {
            root = new TreeNode(1)
            {
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(4)
                    {
                        Left = new TreeNode(7),
                        Right = new TreeNode(8),
                    },
                    Right = new TreeNode(5),
                },
                Right = new TreeNode(3)
                {
                    Right = new TreeNode(6)
                    {
                        Left = new TreeNode(9),
                        Right = new TreeNode(10),
                    },
                },
            };
        }
        public void RunPreorderTraversal()
        {
            PreorderTraversal(root);
            Console.WriteLine("");
        }
        private void PreorderTraversal(TreeNode? node)
        { 
            if (node != null) 
            {
                Console.Write($" {node.Value},");
                PreorderTraversal(node.Left);
                PreorderTraversal(node.Right);
            }
        }
        public void RunInorderTraversal()
        {
            InorderTraversal(root);
            Console.WriteLine("");
        }
        private void InorderTraversal(TreeNode? node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                Console.Write($" {node.Value},");
                InorderTraversal(node.Right);
            }
        }
        public void RunPostorderTraversal()
        {
            PostorderTraversal(root);
            Console.WriteLine("");
        }
        private void PostorderTraversal(TreeNode? node)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left);
                PostorderTraversal(node.Right);
                Console.Write($" {node.Value},");
            }
        }
        public void RunLevelOrderTraversal()
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                Console.Write($" {node.Value},");
                if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                }
                if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                }
            }
            Console.WriteLine("");
        }
        private class TreeNode
        { 
            public int Value;
            public TreeNode? Left;
            public TreeNode? Right;
            public TreeNode(int value)
            { 
                Value = value;
            }
        }
    }
}
