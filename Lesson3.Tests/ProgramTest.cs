using Shouldly;

namespace Lesson3.Tests;

public class ProgramTest
{
    [Fact]
    public void GivenTheProgramIsRan_ThenItDisplaysHelloWorld()
    {
        // Arrange
        var output = new StringWriter();
        Console.SetOut(output);
        
        var fakeArgs = Array.Empty<string>();

        // Act
        Program.Main(fakeArgs);
        var actual = output.ToString();

        // Assert
        actual.ShouldContain("Hello World");
        actual.ShouldNotContain("-1");
        actual.ShouldEndWith("\r\n\r\n");
    }
}