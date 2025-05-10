## Variables
C# is a statically typed language, that means [variables](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables) that are defines are very picky about what value they can have.
Other languages like python or javascript are dynamically typed languages.
This means types are inferred at runtime based on context. This is when you see those funky javascript questions of '5' + 5 results in the string '55' and not the number 55. The interpreter sees the first variable is a string and the operator is a + so it performs string concatenation regardless of the next variable. This is very confusing to both new and seasoned developers so all dynamically languages end up getting type hint support.

In C# you have a wide variety [built in types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types) which are broken into two categories: [value types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types) and [reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types).  

A value type is normally a very basic type (int, bool, char, etc...NOT STRING) whereas a reference type can be your typical class.

### Creation
A variable can be Creation by defining its type and its name and optionally a value. Value types all have a default value of some sort, for example an int defaults to 0. Whereas reference types default to null.
By default, starting with .NET6 [nullability](https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references) is enabled. If a non-nullable reference type is assigned without a value you will get a warning. 

##### An integer test without an explicit value assigned defaults to 0  
```
int test;
```

#### A variable bool with an explicit value assigned to true (default false)
```
bool test = true;
```

#### A non-nullable reference type without an explicit value assigned defaults to null, this will throw a warning
```
Object test;
```

#### A non-nullable reference type without an explicit value assigned, this will _not_ throw a warning
```
Object test = new Object();
```

#### A nullable reference type without an explicit value assigned, this will _not_ throw a warning
```
Object? test;
```

Alternatively, compilers have become smart over the years. If the right hand side of the variable is assigned a value, the compiler can determine the type on its own, in which-case you can use var. Using var is preferred when possible.

#### A variable without an explicit type is assumed an integer due to the value 0
```
var test = 0;
```

#### A variable without an explicit type is assumed an bool due to the value true
```
var test = true;
```

#### A variable without an explicit type is assumed an Object due to the instantiated object Object
```
var test = new Object();
```

### Assignment/Reassignment
You can also assign variables to other variables to perform calculation, or reassign variables to update their values.

#### Assigning a variable to another variable and performing arithmetic
```
var x = 10;
var xSquared = x * x;
```

#### Reassigning a variable because some behavior happened
```
var x = 10;
...some behavior has happened that requires x to be updated
x = 100;
```

### Interview questions
Sometimes you are required to take an interactive programming quiz, for example https://coachmatt.io/algo. 
Other times you might be asked to white board in person [fizzbuzz](https://en.wikipedia.org/wiki/Fizz_buzz)
The point being is that these are the most basics of basics and you probably won't get asked a direct question on variable assignment.