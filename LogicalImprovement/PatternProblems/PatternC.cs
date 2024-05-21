namespace LogicalImprovement.PatternProblems;

internal class PatternC
{
    internal static void SolveC()
    {
        int val = 5;

        for(int i = 1; i <= val; i++)
        {
            for(int j = 1; j <= val - i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
        Console.ReadLine();
    }
}