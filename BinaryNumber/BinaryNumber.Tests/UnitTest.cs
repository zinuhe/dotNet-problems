using Xunit;
using System.Text;

namespace BinaryNumber.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("011100", 7)]
    [InlineData("1111010101111", 22)]
    public void BinaryNumber_ReturnValidOperations(string input, int expected)
    {
        // Act
        var result = Solution.Operations(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void BigBinaryNumber_ReturnValidOperation()
    {
        // Arrange
        string bigNumber = BigNumber();
        int expected = 799999;

        // Act
        var result = Solution.Operations(bigNumber);

        // Assert
        Assert.Equal(expected, result);
    }

    /// <summary>
    /// It generates a string consisting of "1" repeated 400,000 times
    /// This test is going to take some time but it will pass
    /// </summary>
    static string BigNumber()
    {
        StringBuilder bigNumber = new StringBuilder();
        for (int i = 0; i < 400000; i++)
        {
            bigNumber.Append('1');
        }

        return bigNumber.ToString();
    }
}

// from console run: dotnet test