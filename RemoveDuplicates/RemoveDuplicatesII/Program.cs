namespace RemoveDuplicates;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Remove duplicates II!");

        int[] input = { 0, 0, 1, 1, 1, 1, 2, 2, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7 };
        // int[] input = new int[100];
        // Array.Fill(input, 1);
        Console.WriteLine($"input : {string.Join(",", input)}");
        int newLength = RemoveDuplicate(input);
        int k = RemoveDuplicate_II(input);
        // Console.WriteLine($"output: {string.Join(",", input)} - Length new array:{newLength}");
        Console.WriteLine($"output: {string.Join(",", input)} - k:{newLength}");
    }

    /// <summary>
    /// Second approach, optimized
    /// </summary>
    public static int RemoveDuplicate_II(int[] nums)
    {
        int last = nums.Length;
        int rightIndex = 0;
        for (int i = 0; i < last - 2; i++)
        {
            rightIndex = i++;
            int repeated = 0;
            while (nums[i] == nums[rightIndex] && rightIndex < last - 2)
            {
                repeated++;
                rightIndex++;
            }

            if (repeated > 2)
            {
                ShiftLeft_II(nums, i + 3, repeated - 2, last); // array, position(keep first 2), number repeated, right index
                last--;
                i--;
            }
        }
        return last;
    }


    private static void ShiftLeft_II(int[] arr, int leftIndex, int repeated, int rightIndex)
    {
        for (int i = leftIndex; i < rightIndex - 1; i++)
        {
            arr[i] = arr[repeated];
        }
        arr[rightIndex - 1] = 0; // fill the end gaps with 0
    }

    public static int RemoveDuplicate(int[] nums)
    {
        int last = nums.Length;
        for (int i = 0; i < last - 2; i++)
        {
            if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2]) // Duplicate
            {
                ShiftLeft(nums, i + 1, last);
                last--;
                i--;
            }
        }
        return last;
    }

    private static void ShiftLeft(int[] arr, int leftIndex, int rightIndex)
    {
        for (int i = leftIndex; i < rightIndex - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[rightIndex - 1] = 0; // fill the end gaps with 0
    }
}