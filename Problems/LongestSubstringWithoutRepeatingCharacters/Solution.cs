using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution {
        public int LengthOfLongestSubstring(string s) {

            int head = 0;
            int limit = s.Length;
            int longestNoRepeating = 0;
            int currentNoRepeating = 0;
            string testingString = string.Empty;

            if(string.IsNullOrEmpty(s) || s.Length > (5*100000))
                return 0;

            for(int i = 1; i <= limit; i++)
            {
                testingString = s.Substring(head, i);

                //Check for duplicates
                if(DuplicatedCharacters(testingString.ToCharArray()))
                {
                    if(head < s.Length-1)
                    {
                        head++; //room for optimization : abcdefghdijkl head is moving 1 by 1,
                        // it could jump from 1(a) to 5(e)
                        // el ultimo caracter 9(d) es el repetido, volver por la cadena desde atras
                        // hasta encontrar el otro repetido 4(d) y mover head a esa posicion
                        // tener en cuanta la posicion  global no local

                        i = longestNoRepeating;
                        limit = s.Length - head;
                        currentNoRepeating = longestNoRepeating;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    currentNoRepeating++;
                    if(longestNoRepeating <= currentNoRepeating)
                        longestNoRepeating = currentNoRepeating;
                }
            }

            return longestNoRepeating;
        }

        private bool DuplicatedCharacters(char[] charArr)
        {
        return charArr.GroupBy(x => x)
                        .Where(g => g.Count() > 1)
                        // .Select(s => s.Key)
                        .Any();
    }
}
}