---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week02-decisions
---

# Week 02:
## Rules, Conventions, Variables, Operators and Decisions

<a href="./week02-index.html" class="btn btn-default">Week 2 Topics</a> 

---

In programming we constantly deal with program flow and to create that we need to make decisions.
Decisions follow a very simple construct.

### "Check if a condition is true or false by comparing 2 values"

In the diagram below you can see a simple flow diagram that shows how an if statement works.

<iframe frameborder="0" style="width:50%;height:350px;" src="https://www.draw.io/?lightbox=1&highlight=000000&edit=_blank&layers=1&nav=1&title=basic-if-statement#Uhttps%3A%2F%2Fraw.githubusercontent.com%2FToiOhomaiBCS%2FCOMP5202%2Fgh-pages%2Fassets%2Fimages%2Fbasic-if-statement"></iframe>

To code an if statement we use the following sytax.  
Note that the condition sits inside a pair of parenthesis `( )` and the code blocks are inside a pair of `{ }`.

```
keyword (condition)
{
	//Code block if true
}
```

A codition always needs to answer `true` or `false`. In this case we are check if the value of a variable `studentPrice3D` is greater than 12.00.

If that is the case, we print out a message to the screen. Or else we print nothing. although that is not really clear for the use of the program, it is valid code.

```csharp
if (studentPrice3D > 12.00)
{
    Console.WriteLine("I am not going to the movies");
}
```

In the tutorials, we will do a lot of exercises comparing different types of data.