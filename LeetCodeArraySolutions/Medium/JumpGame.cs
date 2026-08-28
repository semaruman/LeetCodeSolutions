namespace LeetCodeArraySolutions.Medium.JumpGame
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int maxDistantion = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxDistantion)
                {
                    return false;
                }

                maxDistantion = Math.Max(maxDistantion, i + nums[i]);

                if (maxDistantion >= nums.Length - 1)
                {
                    return true;
                }
            }

            return true;
        }
    }
}