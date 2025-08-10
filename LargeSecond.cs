using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());           // number of test cases
        for (int _ = 0; _ < t; _++)
        {
            int n = int.Parse(Console.ReadLine());       // size of array
            string[] parts = Console.ReadLine()
                .Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(parts[i]);

            int ans = MaxSumOfTwoDistinct(a);             
            
            Console.WriteLine(ans);
        }
    }

    // TODO: Return the maximum sum of two DISTINCT integers in array a.
    // It is guaranteed there exist at least two distinct values.
    static int MaxSumOfTwoDistinct(int[] a)
    {
        int first = 0;
        int second = 0;
        
        List<int> numbers = new List<int>(a);
        
        first = numbers.Max();
        
        numbers.RemoveAll(x => x == first);
        
        second = numbers.Max();
        
        int result = first + second;
        
        return result; 
    }
}
