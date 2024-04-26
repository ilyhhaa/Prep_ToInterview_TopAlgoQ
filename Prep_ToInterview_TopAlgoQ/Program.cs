using System;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        SolutionRotate solutionRotate = new SolutionRotate();
      
        int[] ints =  new int[] { -1, -100, 3, 99 };
        
         solutionRotate.Rotate(ints, 2);

        Console.WriteLine();
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

/*Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.

 

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]
Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]*/

public class SolutionRotate
{
    public void Rotate(int[] nums, int k)
    {
            k %= nums.Length;
            int[] copy = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                copy[(i + k) % nums.Length] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = copy[i];
            }
           
    }
}
//0-1-2    10-11-12


/*
 Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]
Output: true
Example 2:

Input: nums = [1,2,3,4]
Output: false
Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true*/

public class SolutionDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {

        return nums.GroupBy(n => n).Any(g => g.Count() > 1);

        //Можно через HashSet и потом сравнить HashSet.Count с nums.Count
    }

}