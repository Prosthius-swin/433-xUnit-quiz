namespace UnitTests;
using Xunit;
public class UnitTest1
{
    // Different kinds of logic tests
    [Fact]
    public void Test1()
    {
        Assert.Equal(5,3+2);
        Assert.True(5 == 3+2);
        Assert.False(5 == 3*2);   
        Assert.Equal(1,1);
    }

    // Check if x is in range a-b.
    public void Test2(int x, int a, int b)
    {
        Assert.True(a <= x);
        Assert.True(x <= b);
    }

    // A theory is a collection of facts
    [Theory]
    [InlineData(2,1,10)]
    public void Test3(int x, int a, int b)
    {
        Test2(x,a,b);
        Assert.True(a <= x);
        Assert.True(x <= b);
        Assert.False(x < a);
    }
}