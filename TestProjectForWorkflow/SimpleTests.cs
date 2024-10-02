using FluentAssertions;

namespace TestProjectForWorkflow;

public class SimpleTests
{
    [Fact]
    public void SuccessfulTest()
    {
        int a = 17;

        a.Should().Be(17);
    }

    [Fact]
    public void FailedTest()
    {
        int a = 17;

        a.Should().Be(16);
    }
}