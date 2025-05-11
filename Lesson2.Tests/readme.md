## Tests
Most college classes wait way to long to even bring up testing, we're going to start right away. 
Tests exist to ensure your code is meeting the requirements. There are several forms of testing, ex:
* Unit tests
* Integration tests
* Manual testing
* E2E testing
* Automation testing
* etc..

For the purpose of this lesson we wil be covering unit tests using [xunit](https://xunit.net/), there are a variety of testing frameworks, although they are mostly the same and team preference.   
You will notice a project named 'Lesson2.Tests' which has a project reference to 'Lesson2' and has the xunit [nuget](https://www.nuget.org/) packages installed in the csproj file.

## Test Layout
A good test will have a system under test (SUT), this means we are only testing one thing.
Think about science classes where when you are testing something you are trying to isolate a single thing and see how other factors affect it.  

A good template for organizing your tests is by behavior (behavior driven design/BDD). Some people start by writing their tests firsts before even writing code (test driven design/TDD) 
to help organize their thoughts on how the code should actually function (this typically only works in textbook situations).

To organize the test itself it can be broken apart into 3 parts: Arrange, Act, Assert (AAA)  
* The arrange section is where you setup your stubs, mocks, or inputs
* The act section is where you set up your SUT and call the method you're testing
* The assert section is where you check to see the result of your method happened

## Interview Questions
An interviewer will be looking for testing philosophies, however those are typically senior questions.  
If you can talk about BDD, TDD, SUT, and AAA they will be drooling. They won't expect juniors or mid-levels to understand the why's, just that they have some experience writting them.