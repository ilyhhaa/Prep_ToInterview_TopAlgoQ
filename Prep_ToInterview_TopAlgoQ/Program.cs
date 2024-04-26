using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new Solution();

        var a = solution.MaxProfit(new int[] { 1, 2, 3, 4, 5 });

        Console.WriteLine(a);
    }
}


/*you are given an integer array prices where prices[i] is the price of a given stock on the ith day.

On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the stock at any time. However, you can buy it then immediately sell it on the same day.

Find and return the maximum profit you can achieve.*/


//Runtime: 45 ms
//Memory Usage: 42.7 MB
public class Solution
{
    public int MaxProfit(int[] prices)
    {

        int p = prices[0];

        int profit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] <= p)
            {
                p= prices[i];
            }
            else 
            {
                profit += prices[i] - p;
                p = prices[i];
            }

        }

        return profit;
    }
}