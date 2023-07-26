using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problems.ReverseInteger
{
    public class Solution {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse Integer!");
        }

        public int Reverse(int x) {
            bool negative = false;

            if(x < 0)
            {
                negative = true;
                x = -x;
            }

            // To array
            char[] number = x.ToString().ToCharArray();

            // Invert
            Array.Reverse(number);

            // if(!Int32.TryParse(string.Concat(number), out int newx))
             //     return 0;

            // if(!Int32.TryParse(new string(number), out int newx))
            //     return 0;

            // Seems to be the best performance
            if(!Int32.TryParse(string.Join<char>("", number), out int newx))
                return 0;

            if(negative)
                newx = -newx;

            x = Int32.Parse(newx.ToString());

            return x;
        }
    }
}