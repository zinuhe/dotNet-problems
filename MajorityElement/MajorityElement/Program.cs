using System;

namespace MajorityElement;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, Majority Element!");
        int[] input = { 1, 2, 3, 4, 5, 5, 5, 5, 5, 5 }; // majority > (n / 2)
        Console.WriteLine($"input: {string.Join(", ", input)}");
        Console.WriteLine($"Majority: {MajorityElement(input)}");
    }

    public static int MajorityElement(int[] nums)
    {
        int majority = nums[0], votes = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (votes == 0)
            {
                majority = nums[i];
                votes++;
            }
            else if (majority == nums[i])
            {
                votes++;
            }
            else
                votes--;
        }
        return majority;
    }
}