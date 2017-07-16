---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week02-operators
---

# Week 02:
## Rules, Conventions, Variables, Operators and Decisions

<a href="./week02-index.html" class="btn btn-default">Week 2 Topics</a> 

---

# Operators

Operators are symbols that tell the compiler to perform a Mathematical or Logical Operation.There are slight differences in some of the symbols that are used, but the fundamentals are the same. Most modern languages use the symbols listed below.

There are 6 different types of operators. As an introduction, let's take a look at 4 of them.

* Arithmetic Operators
* Relational Operators
* Logical Operators
* Assignments Operators

For the tables below, let's assume the following variables:

* `var a = 3;`
* `var b = 6;`

## Arithmetic Operators
Simple maths within programming

| Symbols | Description | Example |
| :---: | --- | --- |
| `+` | Addition | a + b (this would be 9) | 
| `-` | Subtraction | b - a (this would be 3)| 
| `/` | Division | b / a (this would be 2) | 
| `*` | Multiplication | a * b (this would be 18)| 
| `%` | Modulus | a + b (this would be 9) | 
| `++` | Increment by one | a++ (this would be 4) | 
| `--` | Decrement by one | b-- (this would be 5) |

## Relational Operators
Relational Operators are used when we compare 2 values  
These are used when using **if statements** and **loops**
Comparisons always give us a true or false value

| Symbols | Description | Example |
| :---: | --- | --- |
| `==` | Check if 2 values are equal | a + b (this would be 9)| 
| `!=` | Check if 2 values are not equal | b - a (this would be 3)| 
| `>` | Check if the left side is greater than the right side | b / a(this would be 2) | 
| `<` | Check if the left side is smaller than the right side | a * b(this would be 18)| 
| `>=` | Check if the left side is greater or equal to the right side| a + b (this would be 9) | 
| `<=` | Check if the left side is smaller or equal to the right side | a++ (this would be 4) | 

## Logical Operators
Logical Operators compares 2 or more **boolean** values  
Each Relational Operator gives a boolean value  
These are also used with **if statements**  
For the examples below assume that `a = true` and `b = false`

| Symbols | Description | Example |
| :---: | --- | --- |
|`&&`| AND operator - Both sides have to be true | `(a && b)`  (this would be false) |
|`||`| OR operator - Only one side needs to be true | `(a || b)`  (this would be true)|
|`!`| OR operator - Only one side needs to be true | `!(a && b)`  (this would be true)
 |

# Assignment Operators

Assignment Operators sets a value to a variable  
a single = is an assignment (not equals like in maths)  
Assume that `a = 3` and `b = 6` and `c = 5` as values. `d` will hold an answer

| Symbols | Description | Example |
| :---: | --- | --- |
| `=` | Assignment | `d = a + b (d = 9)` |
| `+=` | ADD AND adds a value to the left operand in the equation on the right | `c += a;`<br>`c = c + a (c = 8)` |
| `-=` | SUBTRACTS AND removes a value from the left operand in the equation on the right  | `c -= a;`<br>`c = c - a (c = 2)` |
| `*=` | MULTIPLIES AND gets the product of the value on the left and a number on the right | `c *= b;`<br>`c = c * b (c = 30)` |
| `/=` | DIVIDES AND gets the division of the value on the left and a number on the right |  `b /= 3;`<br>`b = b / 3 (b = 2)`|
| `%=` | MODULUS AND gets the modulus of the value on the left and a number on the right |  `c %= a;`<br>`c = c % a (c = 2)`|


