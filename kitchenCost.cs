using System;

public class Test
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            string[] line1 = Console.ReadLine().Split();
            int N = int.Parse(line1[0]);
            int X = int.Parse(line1[1]);

            string[] freshnessStr = Console.ReadLine().Split();
            string[] costStr = Console.ReadLine().Split();

            int[] A = new int[N];
            int[] B = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(freshnessStr[i]);
                B[i] = int.Parse(costStr[i]);
            }

            int result = CalculateTotalCost(N, X, A, B); 
            Console.WriteLine(result);
        }
    }

    public static int CalculateTotalCost(int N, int X, int[] A, int[] B)
    {
        int cost = 0;
        
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] >= X)
            {
                cost += B[i];
            }
        }
        
        return cost;
    }

}
