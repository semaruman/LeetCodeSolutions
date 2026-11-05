using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeNewWay.VeryEasyTasks._1672;

public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int res = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int currentSum = 0;
            for (int j = 0; j < accounts[i].Length; j++ )
            {
                currentSum += accounts[i][j];
            }

            res = Math.Max( res, currentSum );
        }

        return res;
    }
}