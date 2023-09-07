using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace RemoveElement;
public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Remove Element!");

        int[] input = { 1, 2, 3, 4 };
        // var result = RemoveElement(input, 3);
        // Console.WriteLine("result:" + result);
        Console.WriteLine("input: " + string.Join(",", input));
        var tmp = RemoveElement(input, 10);
        // Console.WriteLine("input: " + string.Join(",", input));
    }

    public static int RemoveElement(int[] nums, int val)
    {
        // var array = nums.Except(new int[] { val }).ToArray();
        // return nums.Length - array.Length;
        // Console.WriteLine("array:" + string.Join(",", array));
        // Console.WriteLine("k=" + (nums.Length - array.Length - 1));

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == val)
        //     {
        //         nums[i] = nums[i - 1];
        //         //shift left
        //     }
        // }

        nums[0] = val;
        Console.WriteLine("nums: " + string.Join(",", nums));
        ShiftLeft(nums, 0);
        Console.WriteLine("nums: " + string.Join(",", nums));
        return 0;
    }

    public static void ShiftLeft(int[] array, int index)
    {
        for (int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
    }
}

