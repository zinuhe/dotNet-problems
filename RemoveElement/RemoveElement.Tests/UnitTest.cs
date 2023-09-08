using Xunit;
using RemoveElement;

namespace RemoveElement.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new int[] { 1 }, 0, 1)]
    [InlineData(new int[] { 1 }, 1, 0)]
    [InlineData(new int[] { 1, 2 }, 1, 1)]
    [InlineData(new int[] { 1, 2 }, 0, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 2, 2)]
    [InlineData(new int[] { 1, 1, 1 }, 1, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, 4)]
    [InlineData(new int[] { 1, 2, 2, 4, 5 }, 2, 3)]
    [InlineData(new int[] { 2, 2, 2, 2, 2 }, 2, 0)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 7, 5)]
    public void Remove_Element_All_Passing(int[] arr, int val, int k)
    {
        // Act
        int expectedK = Solution.RemoveDuplicatesAndShiftLeft(arr, val);

        // Assert
        Assert.Equal(expectedK, k);
    }
}
