## C# Program Structure
C# is organized into three main components: 
[Solutions](https://learn.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2022#solutions) (*.sln), 
[projects](https://learn.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2022#projects) (*.csproj),
and [csharp files](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/) (*.cs)  
* Repositories ([Github](https://github.com/)) typically have 1 solution, however a monorepo could have many  
* Solutions typically have many projects  
* Projects typically have many csharp files 

Your *solution* files keep track of your project structure and build information.  
Your *project* files keep class of dependencies and more granular build information.  
Your *csharp* files house the actual code.  

## Program.cs
The structure of this file is using '[top level statements](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/top-level-statements)'. 
It is meant to simplify starting up a new project by removing the boilerplate 'main' method you see in other languages,
However, this is still considered a 'class' and assumes a lot of defaults for you (namespace, class name, method name).
Because of this *projects* can only have 1 top level statement class.

## Interview Questions
You might be asked to write a small program. If you start with this format an interviewer might ask  you about top level statements to see if you understand what you're using.