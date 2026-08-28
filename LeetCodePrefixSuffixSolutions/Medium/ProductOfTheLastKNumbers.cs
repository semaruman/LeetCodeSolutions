using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePrefixSufixSolutions.Medium.ProductOfTheLastKNumbers
{
    public class ProductOfNumbers
    {
        private List<int> prefix;
        public ProductOfNumbers()
        {
            prefix = new List<int> { 1 };
        }

        public void Add(int num)
        {
            if (num == 0)
            {
                prefix = new List<int> { 1 };
            }
            else
            {
                prefix.Add(num * prefix[prefix.Count - 1]);
            }
        }

        public int GetProduct(int k)
        {
            if (k >= prefix.Count) return 0;

            return prefix[prefix.Count - 1] / prefix[prefix.Count - 1 - k];
        }
    }

    /**
     * Your ProductOfNumbers object will be instantiated and called as such:
     * ProductOfNumbers obj = new ProductOfNumbers();
     * obj.Add(num);
     * int param_2 = obj.GetProduct(k);
     */
}
