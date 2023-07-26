namespace tests;

public class UnitTest1
{
    [Fact]
    public void AlwaysPassing()
    {
        Assert.True(true);
        Assert.False(false);
        Assert.Equal(0, 0);
    }

    [Fact]
    public void AlwaysNotPassing()
    {
        Assert.NotEqual(0, 1);
    }
}