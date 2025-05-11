## C# Program Structure
Although this is your typical introductory 'HelloWorld' application we are going to look at everything but the Console.WriteLine line. There is a lot to learn from the solution template a lot of entry level developers overlook.

C# is organized into three main components: 
* [Solutions](https://learn.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2022#solutions) (*.sln)
* [projects](https://learn.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2022#projects) (*.csproj),
* [csharp files](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/) (*.cs)  

Your *solution* files keep track of your project structure and build information. Repositories typically have 1 solution, however a monorepo could have many.  

Your *project* files keep class of dependencies, such as other projects and [NuGet packages](https://www.nuget.org/), and also more granular build information. Solutions typically have many projects.   

Your *csharp* files house the actual code. Projects typically have many csharp* files.

## Program.cs
Another, albeit, small detail that is overlooked is how this program is actually executed. Like most languages it is expected to have an entry point, but the simpler interpreted languages like python allow you to jump in and program right away!  
If you look at the of the 'Program.cs' the structure of this file is using '[top level statements](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/top-level-statements)'. It is meant to simplify starting up a new project by removing the boilerplate 'main' method you see in other languages,
However, this is still considered a 'class' and assumes a lot of defaults for you (namespace, class name, method name).  

Because of this, *projects* can only have 1 top level statement class. A lot of new project templates you generate are now using top level statements by default.
Languages are constantly evolving, no matter what point in time you come in there will always be new features. However, companies will not always be up to date on their versioning. 
When working with any syntax sugar like top level statements, it is good to understand the underlying implementation so you can be fluid between projects.

## Interview Questions
You might be asked to write a small program. If you start with this format an interviewer might ask  you about top level statements to see if you understand what you're using, and if you are fluent between the two.