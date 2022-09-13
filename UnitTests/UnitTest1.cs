using Xunit;
using CLib;
using System.Collections.Generic;
namespace UnitTests;
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
    [Theory]
    [InlineData(2,1,10)]
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
    // Make a test for subtraction of the MyMath.cs
    // Tests each maths function with a known correct solution.
    // Make a test for division by zero. (It should fail)
    [Theory]
    [InlineData(5,1,4)]
    // [InlineData(1,0,0)]
    public void SubtractTest(int inp1, int inp2, int expected)
    {
        MyMath M = new MyMath();

        int result = M.Subtract(inp1, inp2);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1,2,3,6)]
    public void AddTest(int inp1, int inp2, int inp3, int expected)
    {
        MyMath M = new MyMath();

        List<int> nums = new List<int>()
        {
            inp1,
            inp2,
            inp3
        };

        int result = M.Add(nums);
        Assert.Equal(expected, result);
    }
}