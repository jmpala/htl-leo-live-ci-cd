using System.Diagnostics;

namespace WebApplication1.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void Test2()
    {
        Assert.True(false);
    }
}