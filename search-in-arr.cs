using System;

class Solution
{
    public static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int x = int.Parse(firstLine[1]);

        string[] arrStr = Console.ReadLine().Split();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        
        int c = 0;
        
        foreach(int i in arr)
        {
            if(i == x)
            {    
                Console.Write("YES");
                c++;
                break;
            }
            
            
        }
        
        if(c == 0)    
        {
            Console.Write("NO");

        }
    }
}
