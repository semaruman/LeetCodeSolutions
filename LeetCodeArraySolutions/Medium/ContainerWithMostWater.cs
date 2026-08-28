namespace LeetCodeArraySolutions.Medium.ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxS = 0;
            int left = 0;
            int right = height.Length - 1;
            while (left < right)
            {
                int s = (right - left) * Math.Min(height[left], height[right]);
                if (maxS < s)
                {
                    maxS = s;
                }

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxS;
        }
    }
}