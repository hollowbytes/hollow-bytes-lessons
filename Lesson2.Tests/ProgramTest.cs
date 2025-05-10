namespace Lesson2.Tests;

public class ProgramTest
{
    [Fact]
    // The test name is the behavior described in Gherkin Syntax
    public void GivenTheProgramIsRan_ThenItDisplaysHelloWorld()
    {
        // Arrange
        // Redirect console output to a string writer so we can assert the text later
        var output = new StringWriter();
        Console.SetOut(output);
        
        // Setup some empty parameters to satisfy the 'Main' method signature
        var fakeArgs = Array.Empty<string>();

        // Act
        // Program here is the SUT
        Program.Main(fakeArgs);
        var actual = output.ToString();

        // Assert
        Assert.Contains("Hello World", actual);
    }
}