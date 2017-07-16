---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week02-types
---

# Week 02:
## Rules, Conventions, Variables, Operators and Decisions

<a href="./week02-index.html" class="btn btn-default">Week 2 Topics</a> 

---

When declaring variables we need to know what data type we are going to be dealing with.  
In some cases these types need to be set explicitly and at other times, these are inferred.

In the table below you can see the most common data types we will be dealing with.

| Datatype | Description |
| :---: | --- |
| `int` | Whole Numbers |
| `double`<br>`decimal`<br>`float` | Numbers with a decimal places, each are slightly different in the way they deal with the decimal numbers. |
| `string` | A value of characters wrapped inside of a pair of `"` |
| `char` | A single characters wrapped inside of a pair of `'` |
| `bool` | Boolean hold a value of true of false |

# Explicitly typed

Depending on your coding preference and perhaps more common 10 - 15 years ago when the IDE's and compilers weren't as advanced as they are today, variables where always declared explicitly.

By writing the type of the variable before the variable name you are specifying what is required on the right side of the assignment operator.

```csharp
string fname = "Bob";
```

This works for anything, later when we look at arrays you can explicitly set what type the array needs to be.

# Inferred typed

With modern languages you will often see the option of using the `var` keyword and then the datatype is inferred based on what is typed on the right side of the assignment operator.

Using type inferrence is the only way to declare a variable when using Javascript, in C# it came an option at a later stage.

```csharp
var fname = "Bob"; //this will be seen as a string (hover your mouse over the word var)
```

```javascript
var fname = "Bob"; //this will be seen as a string
```

Wether you use one or the other is up to the developer and it is really a preference thing, but a couple of things should be noted:

* As a developer, use on or the other. Don't mix the two, Especially not in the same app.
* Be aware of both. When reading someone else's code someone else might use the one you don'table
* Decide as a team. A teamleader may decide what rules the app should follow


