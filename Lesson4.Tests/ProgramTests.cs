using Shouldly;

namespace Lesson4.Tests;

public class ProgramTests
{
    [Fact]
    public void GivenNoFirstNameIsEntered_ThenDisplayMissingFirstName()
    {
        // Arrange
        Console.SetIn(new StringReader(string.Empty));
        
        var output = new StringWriter();
        Console.SetOut(output);
        
        var fakeArgs = Array.Empty<string>();

        // Act
        Program.Main(fakeArgs);
        var actual = output.ToString();
        
        // Assert
        actual.ShouldEndWith("Missing first name\r\n");
    }
    
    [Fact]
    public void GivenNoAgeIsEntered_ThenDisplayMissingAge()
    {
        // Arrange
        Console.SetIn(new StringReader("test\n"));
        
        var output = new StringWriter();
        Console.SetOut(output);
        
        var fakeArgs = Array.Empty<string>();

        // Act
        Program.Main(fakeArgs);
        var actual = output.ToString();
        
        // Assert
        // TODO: Use shouldly to test for missing age
    }
    
    [Fact]
    public void GivenAgeIsEntereed_WhenAgeIsBelow10_ThenDisplayTooYoung()
    {
        // Arrange
        Console.SetIn(new StringReader("test\n8\n"));
        
        var output = new StringWriter();
        Console.SetOut(output);
        
        var fakeArgs = Array.Empty<string>();

        // Act
        Program.Main(fakeArgs);
        var actual = output.ToString();
        
        // Assert
        // TODO: Use shouldly to test for too yung
    }
    
    [Fact]
    public void GivenCorrenctInformationIsEntered_ThenDisplayCongrats()
    {
        // Arrange
        Console.SetIn(new StringReader("test\n30\n"));
        
        var output = new StringWriter();
        Console.SetOut(output);
        
        var fakeArgs = Array.Empty<string>();

        // Act
        Program.Main(fakeArgs);
        var actual = output.ToString();
        
        // Assert
        // TODO: Use shouldly to test for congrats
    }
}