namespace LogicalImprovement.PatternProblems
{
    internal static class PatternB
    {
        internal static void SolveB()
        {
            //int start = 5;
            int end = 1;

            for(int i = 5; i >= end-1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
