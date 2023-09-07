using System;

namespace Palindrome;
public static class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Palindrome");

        // string input = "abcba"; // odd
        string input = "abccba"; // even
        // string input = "abcdef"; // FALSE
        Console.WriteLine($"Is {input} Palindrome {IsPalindromeV2(input)}");
    }

    public static bool IsPalindromeV1(string input)
    {
        var toReverse = input.ToCharArray();

        Array.Reverse(toReverse);

        return input == string.Join("", toReverse);
    }

    public static bool IsPalindromeV2(string input)
    {
        int right = input.Length - 1;
        for (int left = 0; left < input.Length; left++)
        {
            if (input[left] != input[right])
                return false;
            if (right - left == 2 || right - left == 1)
                return true;

            right--;
        }
        return false;
    }
}
