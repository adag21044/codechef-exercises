using System;
using System.Collections.Generic;

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
            int Y = int.Parse(line1[2]);

            string[] line2 = Console.ReadLine().Split();
            List<int> prices = new List<int>();
            for (int i = 0; i < N; i++)
            {
                prices.Add(int.Parse(line2[i]));
            }

            string result = ShouldUseCoupon(N, X, Y, prices);
            Console.WriteLine(result);
        }
    }


    public static string ShouldUseCoupon(int N, int X, int Y, List<int> prices)
    {
        int itemsPrice = 0;
        int itemsWithCouponPrice = 0;
        
        for(int i = 0; i < N; i++)
        {
            itemsPrice += prices[i];
        }
        
        itemsWithCouponPrice += X;
        
        for(int i = 0; i < N; i++)
        {
            if (prices[i] > Y)
                itemsWithCouponPrice += prices[i] - Y;
            else
                itemsWithCouponPrice += 0;
        }    
        
        if(itemsWithCouponPrice < itemsPrice)
            return "COUPON";
        
        return "NO COUPON";
    }
}
