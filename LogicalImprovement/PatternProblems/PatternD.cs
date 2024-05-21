namespace LogicalImprovement.PatternProblems
{
    internal class PatternD
    {
       internal static void SolveD()
       {
            int end = 5;

            for(int i = 1; i <= end; i++)
            {
                for(int j = 1; j <= end - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        
    }
}
