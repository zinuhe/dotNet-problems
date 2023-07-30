using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.LongestPalindromicSubstring
{
    public class Solution
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Palindromic Substring!");
            var s = new Solution();
            // "jrjnbctoqgzimtoklkxcknwmhiztomaofwwzjnhrijwkgmwwuazcowskjhitejnvtblqyepxispasrgvgzqlvrmvhxusiqqzzibcyhpnruhrgbzsmlsuacwptmzxuewnjzmwxbdzqyvsjzxiecsnkdibudtvthzlizralpaowsbakzconeuwwpsqynaxqmgngzpovauxsqgypinywwtmekzhhlzaeatbzryreuttgwfqmmpeywtvpssznkwhzuqewuqtfuflttjcxrhwexvtxjihunpywerkktbvlsyomkxuwrqqmbmzjbfytdddnkasmdyukawrzrnhdmaefzltddipcrhuchvdcoegamlfifzistnplqabtazunlelslicrkuuhosoyduhootlwsbtxautewkvnvlbtixkmxhngidxecehslqjpcdrtlqswmyghmwlttjecvbueswsixoxmymcepbmuwtzanmvujmalyghzkvtoxynyusbpzpolaplsgrunpfgdbbtvtkahqmmlbxzcfznvhxsiytlsxmmtqiudyjlnbkzvtbqdsknsrknsykqzucevgmmcoanilsyyklpbxqosoquolvytefhvozwtwcrmbnyijbammlzrgalrymyfpysbqpjwzirsfknnyseiujadovngogvptphuyzkrwgjqwdhtvgxnmxuheofplizpxijfytfabx";
            // babad, cbbd, ac, eabcb, bb, ccc, abacdefedghi
            Console.WriteLine(s.LongestPalindrome("abxyxfghijklmnmlkjxyz"));
            //   2 3
            // abxyxfgh - 8
            //     3 3
            // hgfxyxba
            //
        }

        public string LongestPalindrome(string s)
        {
            int left = 0;
            int right = s.Length;
            int sLength = s.Length;
            string sub = string.Empty;
            string sReverse = string.Join("", s.ToCharArray().Reverse());
            string subReverse = string.Empty;
            string palindrome = string.Empty;

            // Console.WriteLine($"s: {s} - s.Length:{s.Length}");
            if(sLength < 2)
            {
                return s;
            }

            while(left < sLength - 1)
            {
                sub = s.Substring(left, right);
                if(sub.Length < 1 || sub.Length <= palindrome.Length)
                {
                    right = sLength - left;
                    left++;
                }
                else
                {
                    // Console.WriteLine($"sub:{sub}, left:{left}, right:{right}");
                    // subReverse = string.Join("", sub.ToCharArray().Reverse());
                    subReverse = sReverse.Substring(sLength-(left+right), right);
                    if(sub == subReverse && sub.Length > palindrome.Length)
                    {
                        // Console.WriteLine($"sub:{sub} -palindrome-");
                        palindrome = sub;
                        right = sLength - left;
                        left++;
                        if(palindrome.Length > (sLength/2))
                        {
                            break;
                        }
                    }
                }
                right--;
            }
            return palindrome;
        }

        public string LongestPalindrome2(string s)
        {

            int count = s.Length;
            int sLength = s.Length;
            string sReverse = string.Empty;
            string pal = string.Empty;
            string palindrome = string.Empty;

            // Console.WriteLine($"s: {s} - s.Length:{s.Length}");
            // abaxacdef
            // fedcaxaba
            // leer la primera de izq. a der. y la otra de der. a izq. si los caracteres son
            // iguales es palindrome

            if(sLength < 2)
            {
                return s;
            }

            sReverse = string.Join("", s.ToCharArray().Reverse());

            for(int i = 0; i < sLength; i++)
            {
                Console.WriteLine($"s[{i}]:{s[i]} - sReverse[{sLength-i-1}]:{sReverse[sLength-i-1]}");
                if(s[i] == sReverse[sLength-i-1])
                {
                    pal += s[i];
                    count++;
                }
                if(count > palindrome.Length)
                {
                    palindrome = pal;
                }
            }

            return palindrome;
        }
    }
}