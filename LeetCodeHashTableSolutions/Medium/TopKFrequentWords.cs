namespace LeetCodeHashTableSolutions.Medium.TopKFrequentWords
{
    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var distinctWords = words.Distinct().ToArray();
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                if (!dict.ContainsKey(words[i]))
                {
                    dict[words[i]] = 0;
                }
                dict[words[i]] += 1;
            }
            Array.Sort(distinctWords, (x, y) =>
            {
                int freqCompare = dict[y].CompareTo(dict[x]);
                if (freqCompare != 0)
                    return freqCompare;
                return x.CompareTo(y);
            });
            return distinctWords.Take(k).ToList();
        }
    }
}