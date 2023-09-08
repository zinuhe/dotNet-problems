using System;

namespace RemoveElement;
public class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Remove Element!");

        int[] input = { 1, 2, 2, 4, 5, 9 }; // Input array
        int valToRemove = 2; // Value to remove from the array

        Console.WriteLine($"Input : {string.Join(",", input)}, Value to remove = {valToRemove}");
        int k = RemoveDuplicatesAndShiftLeft(input, valToRemove);
        Console.WriteLine($"Output: {string.Join(",", input)}, k = {k}");
    }


    public static int RemoveDuplicatesAndShiftLeft(int[] array, int val)
    {
        int countRemoved = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == val)  // found value to remove
            {
                ShiftLeft(array, i); // call the funtion to shift
                i--;
                countRemoved++;
            }
        }

        return array.Length - countRemoved;
    }

    private static void ShiftLeft(int[] array, int index)
    {
        for (int i = index; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }
        array[^1] = 0; // array[array.Length] - replacing by 0 the last position
    }
}
