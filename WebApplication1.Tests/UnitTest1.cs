using System.Diagnostics;

namespace WebApplication1.Tests;

public class UnitTest1
{
    [Fact]
    public void Test()
    {
        Assert.True(true);
    }

    [Fact]
    public void The_Test()
    {
        Assert.True(false);
    }
}