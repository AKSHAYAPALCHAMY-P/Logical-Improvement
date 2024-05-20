namespace LogicalImprovement.PatternProblems
{
    /*
      
    * * * * *
    * * * * * 
    * * * * *
    * * * * *
    * * * * *

    */

    internal static class PatternA
    {
        internal static void Solve()
        {
            int start = 1;
            int end = 6;

            for (int i = start; i < end; i++)
            {
                for (int j = start; j < end; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
