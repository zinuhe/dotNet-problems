using Dia2Lib;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace RemoveDuplicates.Tests;

public class UnitTest
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 1 }, 1)]
    [InlineData(new int[] { 1, 1, 1 }, 1)]
    [InlineData(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 }, 8)]
    [InlineData(new int[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7 }, 8)]
    public void Test1(int[] input, int expectedLength)
    {
        // Arrange

        // Act
        int resultLength = Program.RemoveDuplicate(input);

        // Assert
        Assert.Equal(resultLength, expectedLength);
    }
}