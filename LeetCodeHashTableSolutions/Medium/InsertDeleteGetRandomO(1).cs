using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHashTableSolutions.Medium.InsertDeleteGetRandomO_1
{
    public class RandomizedSet
    {
        private List<int> list;
        private Dictionary<int, int> dict;
        private Random random;

        public RandomizedSet()
        {
            list = new List<int>();
            dict = new Dictionary<int, int>();
            random = new Random();
        }

        public bool Insert(int val)
        {
            if (dict.ContainsKey(val))
            {
                return false;
            }

            list.Add(val);
            dict[val] = list.Count - 1;
            return true;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val))
            {
                return false;
            }
            if (list[list.Count - 1] == val)
            {
                dict.Remove(val);
                list.RemoveAt(list.Count - 1);
                return true;
            }

            int valIndex = dict[val];

            //меняю удаляемый элемент на последний, затем крайний элемент(дубликат) удаляю
            int tempNumber = list[list.Count - 1];
            list[valIndex] = tempNumber;
            list.RemoveAt(list.Count - 1);
            
            //т.к. элемент последний элемент перемстился обновляю его индекс в словаре
            dict[tempNumber] = valIndex;

            dict.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            return list[random.Next(0, list.Count)];
        }
    }
}
