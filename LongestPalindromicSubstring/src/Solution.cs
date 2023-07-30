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
            // Console.WriteLine(s.LongestPalindrome("abxyxfghijklmnmlkjxyz"));
            Console.WriteLine(s.LongestPalindrome2("abcxyyxada"));
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
                    if(sub.Length > palindrome.Length && sub == subReverse)
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

            Console.WriteLine($"s: {s} - s.Length:{s.Length}");
            //    3-4
            // abcxyyxada - 10
            //    3-4
            // adaxyyxcba | 10-(3+4)=3
            // emepzar buscando de a 3 caracteres, que el primero y el ultimo sean iguales
            // esa cadena ir y buscarla en la inversa con la formula de arriba
            //
            // otro puede ser buscar los repetidos y luego sacar la(s) cadena(s) entre los repetidos
            // invertir (o usar la formula) y validar
            // caso de arriba:
                // repetidos son: a, x
                // abcxyyxada, abcxyyxa, ada*
                // xyyx*
            // hay una funcion que regresa un array con los repetidos, iterar sobre ese array
            // funcion que regrese las posiciones de esos repetidos
            // sacar las cadenas entre esos repetidos y validarlas

            if(sLength < 2)
            {
                return s;
            }

            // find duplicates
            var duplicates = s.GroupBy(c => c).Where(g => g.Count() > 1);
            foreach(var duplicate in duplicates)
            {
                Console.WriteLine(duplicate.Key);
                // var index = s.IndexOf(duplicate.Key);
                // Console.WriteLine($"index:{string.Join("", index)}");
                var split = s.Split(duplicate.Key);
                Console.WriteLine($"split:{string.Join(",", split)}");
            }

            return palindrome;
        }
    }
}