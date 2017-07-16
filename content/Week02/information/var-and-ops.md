---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week02-var-and-ops
---

# Week 02:
## Rules, Conventions, Variables, Operators and Decisions

<a href="./week02-index.html" class="btn btn-default">Week 2 Topics</a> 

---

# Variables

A variable is a name for a value, so that we can reference to a word rather than a value.
This makes it easier when needing to change the value, because we only have to do in a single place rather than all over our program.

Definition:

![Variables](./assets/images/variables.png)

> The value can change, but the name you define cannot

## Declaring a variable

In most languages variables are defined in the following way:

**C# Example**
```csharp
var a = "This is the value";
```

**JavaScript**
```js
var a = "This is the value"
```

The main reason behind covering C# and Javascript side-by-side is to point out some specific differences.  

For example, once a type has been linked to a variable name in C# you cannot change it later in the program.
When this is done in JavaScript, the type can be changed by redeclaring it later in the program.

## Using a variable

Once a variable has been declared, you can use it in your program by just referring to the name. Instead of displaying the name of the variable, it will print out the value that is associated with it.

> Note: If you are writing a string using `"` and `"` and then use the variable name then it will just see it as the word. If we do want to use the value of the variable you will need to use string interpolation or break the string into several parts.

> In C# we can do string interpolation by placing a `$` in front of the `"` and then placing any variables in the string inside of `{` & `}` brackets.

> In Javascript, we need to break up the string and use the `+` sign to concatenate several strings.
When we end a string by using the `"` we are then using code syntax, rather than text.

<br>
# Constants

Constants are very similar to variables and in fact work exactly the same as a variable with one difference.

**You cannot change the value**

In most cases with modern compilers and interperators, this cost less compute power to process these. So if you know a value is never going to change, use a constant.

**C# Example**
```csharp
const string a = "This is the value";
```

**JavaScript**
```js
const a = "This is the value"
```
<br>
# Variable Scope

Variables genrally can be used in the block that they are declared in and deeper, but not outside of that block.

For example in C# a variable scope will work like this:

```csharp

var a = 10;

if (a <= 10 )
{
    var b = 10;
    a += b;
    Console.WriteLine($"The new value of a = {a}");
}

Console.WriteLine($"The value for variable a is now {a}"); //This will return a value
Console.WriteLine($"The value for variable b is now {b}"); //This will produce an error

```

In Javascript it works like this:

```js

var a = 10;

if (a <= 10 )
{
    var b = 10;
    a += b;
    document.WriteLine("The new value of a = " + a)
}

document.writeLine("The value for variable a is now "+ a) //This will return a value
document.writeLine("The value for variable b is now "+ b) //This will also work

```

To limit the scope of a variable to a code block in Javascript, use `let`. This is the new in the latest version of Javascript (ES6) and should replace var.

```js

let a = 10;

if (a <= 10 )
{
    let b = 10;
    a += b;
    document.WriteLine("The new value of a = " + a)
}

document.writeLine("The value for variable a is now "+ a) //This will return a value
document.writeLine("The value for variable b is now "+ b) //This will no longer work

```














