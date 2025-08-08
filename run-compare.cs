using System;
using System.Collections.Generic;

public class Test
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine()); 
        
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine()); // Gün sayısı
            
            string[] aliceInput = Console.ReadLine().Split();
            string[] bobInput = Console.ReadLine().Split();
            
            List<int> aliceDistances = new List<int>();
            List<int> bobDistances = new List<int>();

            for (int i = 0; i < N; i++)
            {
                aliceDistances.Add(int.Parse(aliceInput[i]));
                bobDistances.Add(int.Parse(bobInput[i]));
            }

            int result = CountHappyDays(N, aliceDistances, bobDistances);
            Console.WriteLine(result);
        }
    }

    public static int CountHappyDays(int N, List<int> alice, List<int> bob)
    {
        int commonDays = 0;
        
        for(int i = 0; i < N; i++)
        {
            if(bob[i] <= 2 * alice[i] && alice[i] <= 2 * bob[i])
                commonDays++;
        }
        
        return commonDays;
    }
}
