using DemoNetCoreAlgorithm.App;

Console.WriteLine("DemoNetCoreAlgorithm");

//Factory.Run(FactoryType.EightQueensSwap);

// (FIFO)
//Queue<int> queue = new Queue<int>();
// (LIFO)
//Stack<int> stack = new Stack<int>();

var size = 6;
var chessboard = new int[size];
for (int i = 0; i < size; i++)
{
    chessboard[i] = i;
}
run(chessboard, 0);
void run(int[] chessboard, int current)
{
    if (current == chessboard.Length)
    {
        Console.WriteLine();
        foreach (var q in chessboard)
        {
            for (var i = 0; i < chessboard.Length; ++i)
            {
                Console.Write(q == i ? "Q" : ".");
            }
            Console.WriteLine();
        }
        return;
    }
    for (var i = current; i < chessboard.Length; ++i)
    {
        (chessboard[current], chessboard[i]) = (chessboard[i], chessboard[current]);
        var space = true;
        for (var j = 0; j < current; ++j)
        {
            if (current - j == Math.Abs(chessboard[current] - chessboard[j]))
            {
                space = false;
                break;
            }
        }
        if (space)
        {
            run(chessboard, current + 1);
        }
        (chessboard[current], chessboard[i]) = (chessboard[i], chessboard[current]);
    }
}