namespace Palindrome.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("abccba", true)]
    [InlineData("aba", true)]
    [InlineData("123454321", true)]
    [InlineData("12345", false)]
    [InlineData("abcdef", false)]
    public void Testing_IsPalindromeV1(string input, bool expected)
    {
        // Act
        bool result = Solution.IsPalindromeV1(input);

        // Assert;
        Assert.Equal(result, expected);
    }

    [Theory]
    [InlineData("abccba", true)]
    [InlineData("aba", true)]
    [InlineData("123454321", true)]
    [InlineData("12345", false)]
    [InlineData("abcdef", false)]
    public void Testing_IsPalindromeV2(string input, bool expected)
    {
        // Act
        bool result = Solution.IsPalindromeV1(input);

        // Assert;
        Assert.Equal(result, expected);
    }
}
