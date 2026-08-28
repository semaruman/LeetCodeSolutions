using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeArraySolutions.Medium.ValidSudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            /*
            алгоритм: 
            1) для каждой строки, для каждого столбца, для каждого блока создаю множества
            2) иду по полю. И если там цифра, то проверяю её во множестве строк, столбцов, блоков
            */

            var rowHashSets = new List<HashSet<char>>();
            var colHashSets = new List<HashSet<char>>();
            var blockHashSets = new List<HashSet<char>>();

            for(int i=0; i < board.Length; i++)
            {
                rowHashSets.Add(new HashSet<char>());
                colHashSets.Add(new HashSet<char>());
                blockHashSets.Add(new HashSet<char>());
            }

            for (int i=0; i < board.Length;i++)
            {
                for (int j=0;j<board[i].Length;j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    int blockIndex = (i / 3) * 3 + (j / 3);

                    var chr = board[i][j];
                    //если не могу добавить в строку, столбец или в блок, то возвращаю false
                    if (!rowHashSets[i].Add(chr) || !colHashSets[j].Add(chr) || !blockHashSets[blockIndex].Add(chr))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
