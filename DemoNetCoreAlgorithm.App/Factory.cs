using System;

namespace DemoNetCoreAlgorithm.App
{
    public class Factory
    {
        public static void Run(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.BinaryTree:
                    BinaryTree.Runner.Debug();
                    break;
                case FactoryType.EightQueens:
                    EightQueens.Runner.Debug();
                    break;
                case FactoryType.Permutation:
                    Permutation.Runner.Debug();
                    break;
                case FactoryType.QuickSort:
                    QuickSort.Runner.Debug();
                    break;
            }
        }
    }
    public enum FactoryType
    {
        BinaryTree,
        EightQueens,
        Permutation,
        QuickSort,
    }
}
