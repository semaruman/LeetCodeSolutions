namespace LeetCodeArraySolutions.Medium.ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var resList = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        resList.Add(new List<int> { nums[i], nums[left], nums[right] });

                        left++;
                        right--;

                        while (left < right && nums[left] == nums[left - 1])
                        {
                            left++;
                        }
                        while (left < right && nums[right] == nums[right + 1])
                        {
                            right--;
                        }
                    }
                    else if (nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else if (nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                }
            }

            return resList;
        }
    }
}