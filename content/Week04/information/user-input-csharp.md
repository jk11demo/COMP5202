---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week04-csharp-userinput
---

# Week 04:

## User input

<a href="./week04-index.html" class="btn btn-default">Week 4 Topics</a> 

---

# Getting information

In C# we have seen `Console.WriteLine();` a number of times and we can see how to display information.

Note that whatever we put into the `( )` will be converted into a string - even if the value is not.
A screen is only able to display a string.

The same thing happens when we take a value from a user - it is only ever a string.

We are able to get a user input by using `Console.ReadLine()`

## Storing user input

Input from a `Console.ReadLine()` can be linked to a variable. If we use `var` the type will always be a string.
If we want it to be something else, we need to **Parse** or **Convert** the value. 

```c#
var name = Console.ReadLine();
```

In the case above, `name` will be a string and whatever the user types in will be stored in that variable.

## Good Practice

To be able to get information from the user we need to inform them what it is we need from them.

For this we use the `Console.WriteLine()` we already know about. Otherwise the user is simply presented with a blinking cursor.

Let's look at the example below:

```c#

    Console.WriteLine("What is your name?");
    var name = Console.ReadLine();
    
    Console.WriteLine(name);

```

Remember we cannot use constants for user input - why is that?