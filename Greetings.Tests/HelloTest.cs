using Greetings.Lib;
using Xunit;

namespace Greetings.Tests;

public class HelloTest
{
    [Theory]
    [InlineData("Andrew")]
    [InlineData("Nikolay")]
    public void SayHello(string name)
    {
        var actual = new Hello().GetText(name);
        Assert.Equal($"Hello, {name}!!!", actual);
    }
}