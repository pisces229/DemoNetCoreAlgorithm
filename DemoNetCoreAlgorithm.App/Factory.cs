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
                case FactoryType.BinaryTreeTraversal:
                    BinaryTreeTraversal.Runner.Debug();
                    break;
                case FactoryType.EightQueensArray:
                    EightQueensArray.Runner.Debug();
                    break;
                case FactoryType.EightQueensSwap:
                    EightQueensSwap.Runner.Debug();
                    break;
                case FactoryType.FisherYatesShuffle:
                    FisherYatesShuffle.Runner.Debug();
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
        BinaryTreeTraversal,
        EightQueensArray,
        EightQueensSwap,
        FisherYatesShuffle,
        Permutation,
        QuickSort,
    }
}
