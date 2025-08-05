using System;

public class Test
{
    public static void Main()
    {
        
        int t = int.Parse(Console.ReadLine());

        
        for (int test = 0; test < t; test++)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arrStr = Console.ReadLine().Split();

            if (arrStr.Length < n)
            {
                Console.WriteLine("Error: Not enough numbers provided.");
                return;
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            int max = arr[0]; 
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }
    }
}
