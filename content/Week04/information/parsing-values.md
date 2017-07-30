---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week04-csharp-parsing-values
---

# Week 04:

## Parsing Values

<a href="./week04-index.html" class="btn btn-default">Week 4 Topics</a> 

---

# Changing the data type (Parse)

Sometimes we need to change the datatype so that we can do other things with our data.  
For example when doing number conversion, we cannot do this using strings.

To be able convert strings to a numeric value (`int`, `double`, `floats`) we use the `.Parse()` method.  
If we want to convert a string to a whole number we would use `int.Parse(string)` and store that value into a variable.

For a conversion to happen successfully the input from the user needs to be a number, or else you will get a value of 0 or a program crash.

```csharp
Console.WriteLine("Please enter in a number");
var input1 = Console.ReadLine();
var number1 = int.Parse(input1);

Console.WriteLine(number1 * 2);
```

# Using TryParse

As the name implies, a `tryParse()` tries to parse the string. This is a boolean operation, which returns `true` or `false`
For this we need to setup 2 variables, one that holds a number (`int`, `double`, `floats`) and one that holds the `boolean` value.

```csharp
//Get input from user
Console.WriteLine("Please enter in a number");
var input1 = Console.ReadLine();

//Check if the input from the user is a number
var number1 = 0;
var isNumber = int.TryParse(input1, out number1);

//If the value is a number, go on with the program, or else tell the user they made an error
if(isNumber) {
    Console.WriteLine(number1 * 2);
}
else {
    Console.WriteLine("Please type in a number next time.");
}
```








