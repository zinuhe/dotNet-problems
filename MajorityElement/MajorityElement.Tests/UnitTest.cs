using Xunit;
using MajorityElement;

namespace MajorityElement.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 2, 3 }, 2)]
    [InlineData(new int[] { 1, 2, 2, 2, 3 }, 2)]
    [InlineData(new int[] { 4, 4, 4, 4, 1, 2, 3, 5 }, 4)]
    [InlineData(new int[] { 1, 2, 4, 4, 4, 4, 3, 5 }, 4)]
    [InlineData(new int[] { 1, 2, 3, 5, 4, 4, 4, 4 }, 4)]
    [InlineData(new int[] { 1, 2, 3, 4, 4, 4, 4, 5 }, 4)]
    [InlineData(new int[] { 1, 1, 1, 1, 2, 3, 4, 5 }, 1)]
    [InlineData(new int[] { 1, 2, 3, 3, 3, 3, 4, 5 }, 3)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 5, 5, 5 }, 5)]
    public void Test_All_Passing(int[] input, int expected)
    {
        // Arrange

        // Act
        int result = Program.MajorityElement(input);

        // Assert
        Assert.Equal(expected, result);
    }
}