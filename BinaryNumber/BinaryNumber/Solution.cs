using System;

namespace BinaryNumber
{
    public class Solution
    {
        static void Main(string[] args)
        {
            int operations = 0;
            char lastDigit = '0';
            // string binaryString = "011100"; //number 28 - return 7
            string binaryString = "1111010101111"; //number 7855 - return 22

            // Remove leading zeros from binary string
            string trimmedBinary = binaryString.TrimStart('0');

            while (trimmedBinary != "0")
            {
                lastDigit = trimmedBinary[trimmedBinary.Length - 1];

                if (lastDigit == '0') // if input is even, divide it by 2
                {
                    trimmedBinary = DivideBinaryBy2(trimmedBinary);
                    operations++;
                }
                else if (lastDigit == '1') // if input is odd, substrat 1 from it
                {
                    trimmedBinary = SubtractOneFromBinary(trimmedBinary);
                    operations++;
                }
            }

            Console.WriteLine("Operations: " + operations);
        }

        /// <summary>
        /// Same as Main to be able to call Main from console and
        /// to call Operations from the unit testing suit
        /// </summary>
        public static int Operations(string binaryString)
        {
            int operations = 0;
            char lastDigit = '0';

            // Remove leading zeros from binary string
            string trimmedBinary = binaryString.TrimStart('0');

            while (trimmedBinary != "0")
            {
                lastDigit = trimmedBinary[trimmedBinary.Length - 1];

                if (lastDigit == '0') // if input is even, divide it by 2
                {
                    trimmedBinary = DivideBinaryBy2(trimmedBinary);
                    operations++;
                }
                else if (lastDigit == '1') // if input is odd, substrat 1 from it
                {
                    trimmedBinary = SubtractOneFromBinary(trimmedBinary);
                    operations++;
                }
            }

            return operations;
        }

        static string DivideBinaryBy2(string binary)
        {
            if (binary.Length == 0)
                return "0"; // Edge case

            // Remove the last digit (rightmost bit) and shift the rest
            string dividedBinary = binary.Substring(0, binary.Length - 1);

            return dividedBinary;
        }

        static string SubtractOneFromBinary(string binary)
        {
            char[] binaryArray = binary.ToCharArray();

            // Starting from the rightmost digit, find the first '1' and convert it to '0'
            for (int i = binaryArray.Length - 1; i >= 0; i--)
            {
                if (binaryArray[i] == '1')
                {
                    binaryArray[i] = '0';
                    break;
                }
                else
                {
                    binaryArray[i] = '1'; // Borrow and convert '0' to '1'
                }
            }

            return new string(binaryArray);
        }
    }
}
