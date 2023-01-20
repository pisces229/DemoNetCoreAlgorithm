using System;

namespace DemoNetCoreAlgorithm.App
{
    public class Factory
    {
        public static void Run(FactoryType type)
        {
            switch (type)
            {
                case FactoryType.EightQueens:
                    new EightQueens.Runner().Debug();
                    break;
                case FactoryType.QuickSort:
                    new QuickSort.Runner().Debug();
                    break;
            }
        }
    }
    public enum FactoryType
    {
        EightQueens,
        QuickSort,
    }
}
