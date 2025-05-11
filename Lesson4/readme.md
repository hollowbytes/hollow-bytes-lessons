## Control Flow
To actually do anything with a program we have to make logical decisions by evaluating statements called _predicates_. 
To put simply, does something evaluate to true or false. 
There are entire college courses dedicate to boolean logic and simplifying expressions, you've probably have already done truth tables if you've taken a comp sci course, and for the most part...that course is useless.


### If
In C#, like many languages, have if, else if, and else statements to control the decisions the application should take based on the evaluated predicates.

Something that is true will execute what is in the brackets
```
if (true) {
    Console.WriteLine("Hello World");
}
```

Something that is false will not execute what is in the brackets
```
if (false) {
    // This is not written to the console because the statement is false
    Console.WriteLine("Goodbye World");
}
```

## If, else
When we want to perform an action on a predicate on either it's truthy or falsey condition we can use the if/else

```
if (true) {
    Console.WriteLine("Hello World");
} else {
// This is not written to the console because the statement is false
    Console.WriteLine("Goodbye World");
}
```
Take note here, this block is **NOT** the same as the above two disjoint if statements. 
The if else statement will only evaluate the predicate once to determine which branch it should take, the two if statements will be evaluated for each if statement. 
While this is not a big issue on efficiency, I see a lot of beginners miss the nuance which can result in code smell and sometimes even buggy code, especially when multiple decisions need to be made.

### If, else if, else
When there are multiple decisions that can be taken that is when we use if, else if, and else. Let's say we have some input from the user like their age and we output different messages for different ages.

```
var age = ...;

if (age < 10) {
    Console.WriteLine("They're just a baby!");
} else if (age >= 10 && < 30) {
    Console.WriteLine("They're so young!");
} else if (age >= 30 && < 50) {
    Console.WriteLine("Im so old!");
} else {
    Console.WriteLine("I'm really old!");
}

```

### Common Mistakes
When evaluating a chain a branches it will stop on the first predicate that is evaluated as true so it is important you have your logic ordered correctly. Take for example the slightly reorganized code
```
var age = ...;
if (age >= 10 && < 30) {
    Console.WriteLine("They're so young!");
} else if (age < 10) {
    Console.WriteLine("They're just a baby!");
} else if (age >= 30 && < 50) {
    Console.WriteLine("Im so old!");
} else {
    Console.WriteLine("I'm really old!");
}
```
While logically it makes sense, it does not read well. You want to set things up so when you are reading it top down you are crossing out decisions. 
When I come to the second branch checking for people younger than 10, I naturally jump to the beginning because intuitively anyone less than 10 is awkward to be evaluated after people older than 10.
Making sure our code is not just formatted cleanly, but logically organized allows us to understand the code without necessarily needing to run the code.

Lastly, I often see people not make use of the else keyword

```
var age = ...;
if (age >= 10 && < 30) {
    Console.WriteLine("They're so young!");
} 

if (age < 10) {
    Console.WriteLine("They're just a baby!");
} 

if (age >= 30 && < 50) {
    Console.WriteLine("Im so old!");
} else {
    Console.WriteLine("I'm really old!");
}
```

The intended result is to output a single line of text, however because the missing 'else' statements this code will have two lines of text for ages 0-30, and one line of text for ages 30-50.

## Interview Questions
You **WILL** at some point in your career, regardless of title, be expected to perform a coding exercise. This is typically something like [fizzbuzz](https://en.wikipedia.org/wiki/Fizz_buzz). You'd be surprised at how many people cannot complete this small little exercise that aims to see if a candidate has an understanding of control flow and the [modulus operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/arithmetic-operators#remainder-operator-).