## Unit Testing Tooling
Everyone hates testing and college courses do no favors of exposing students to the vast amount of tooling out there that aims to make unit testing easier.  
We will be introducing [shouldly](https://docs.shouldly.org/). It is a library that aims to make assertations more digestible and adds a lot of helper methods the built-in [MS.Test asserts](https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?view=mstest-net-3.7) do not provide.  
Another library vary similar to shouldly, was [Fluent Assertions](https://fluentassertions.com/), however they recently shifted to a premium library and the community has jumped ship. 

There are many, many, many more libraries like [moq](https://github.com/devlooped/moq), [auto fixture](https://github.com/AutoFixture/AutoFixture), [bogus](https://github.com/bchavez/Bogus), [test containers](https://testcontainers.com/guides/getting-started-with-testcontainers-for-dotnet/), etc... that we will explore later as project complexity grows. Just like a mechanic has different tools for the job, so should you. 

## Interview Questions
One thing many people don't keep track of is their tooling or their stack. Form opinions earlier on why you use things. If you can come into an interview with how you would build something and why you chose those tools to build it, you will rise to the top.
Focusing on what we've covered thus far, you're adopting a 'C#/.NET stack' that uses 'xUnit' and 'shouldly'. Although you won't have much of an answer to 'why' besides 'I was told to by my senior' until you get into advanced features, which is fine.