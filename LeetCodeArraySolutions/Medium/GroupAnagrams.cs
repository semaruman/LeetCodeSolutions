using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeArraySolutions.Medium.GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> anagrams = new Dictionary<string, IList<string>>();

            /*решение задачи: каждую строку в массиве я сортирую.
             * любая анаграмма будет выглядить одинаково, если её отсортировать
             * отсортированная строка - ключ в словаре, а значение - список подходящих слов
            */
            foreach (string str in strs)
            {
                var chars = str.ToCharArray();
                Array.Sort(chars);
                var sortedStr = new string(chars);

                if (!anagrams.TryGetValue(sortedStr, out IList<string> _))
                {
                    anagrams[sortedStr] = new List<string>();
                }
                anagrams[sortedStr].Add(str);
            }

            return new List<IList<string>>(anagrams.Values);
        }
    }
}
