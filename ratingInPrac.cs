using System;

public class Test
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine()); 
        
        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine()); 
            string[] input = Console.ReadLine().Split();
            int[] difficulties = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                difficulties[i] = int.Parse(input[i]);
            }
            
            CheckDifficultyOrder(N, difficulties);
        }
    }

    public static void CheckDifficultyOrder(int N, int[] difficulties)
    {
        for(int i = 0; i < difficulties.Length; i++)
        { 
            if(i + 1 < difficulties.Length)
            {
                if(difficulties[i] > difficulties[i+1])
                {
                   Console.WriteLine("No"); 
                   return;
                }
            }
        }
        Console.WriteLine("Yes");
    }
}
