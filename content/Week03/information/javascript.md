---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week03-javascript
---

# Week 03:
## Recap on Variables, Loops and Arrays

<a href="./week03-index.html" class="btn btn-default">Week 3 Topics</a> 

---

# Extra note on if statements (javascript only)

When declaring variaubles in javascript we can use any datatype and infer the type for the variable.

The difference between languages like C# and javascript is that in js the type can be changed.

So this can cause an issue when comparing values in an `if statement`

Take for example this code example:

```js

if ("5" == 5)
{
    //Execute the true block  <-- this is true
}
else {
    //Execute the else block
}

```

This would be true, because we are comparing **values** only.

```js

if ("5" === 5)
{
    //Execute the true block
}
else {
    //Execute the else block  <-- this is false
}

```

The second block would return false, because we are also comparing the type.

# Loops in javascript

Loops in javascript work exactly the same as they do in C#. Just watch out for the syntax details.

## For Loop:

```js
let counter = 5;

for (let i = 0; i < counter; i++) {
    let a = i + 1;
    console.log("This is line number " + a);
}
```

## While Loop:

```js
let counter = 5;
let index = 0;

while(index < counter) {

    let a = i + 1;
    console.log("This is line number " + a);

}
```

## Do Loop:

```js
let counter = 5;
let index = 0;

 do {

    let a = i + 1;
    console.log("This is line number " + a);

}while(index < counter);
```
## NaN as a result of a Loop

```js
var multiples = [1064, 256, 374, 102, "sheep", "camel"];
var newArray = [];
for (var i = 0; i < multiples.length; i++) {
//checking if it is a number
 if (!isNaN(multiples[i])) 
  {  
     console.log(multiples[i])  //showing us the number
     newArray[i] = multiples[i] //add numbers to a new array
  }
}
console.log("Only Numbers - ", newArray)
```

## The result of the above code is:

```
1064
256
374
102
Only Numbers -  [ 1064, 256, 374, 102 ]
```

---

# Using Arrays in javascript

Arrays work also very similar in Javascript, but there are no lists.

## Create a new array:

```js
var multiples = [1064, 256, 374, 102, "sheep", "camel"];
```

## The VIP Reference

```js
var multiples = [1064, 256, 374, 102, "sheep", "camel"]; [v] (value)
index =            0    1    2    3      4        5      [i] (index)
position =       1st   2nd  3rd  4th    5th      6th     [p] (position)
```

## Some extra Javascript methods

```js
var multiples = [1064, 256, 374, 102, "sheep", "camel"];
var firstItem = multiples[0];     //1064
var length = multiples.length     //6
var allItems = multiples.join()   //"1064,256,374,102,sheep,camel"
var sorting = multiples.sort()    //102, 1064, 256, 374, "camel", "sheep"
var reverse = multiples.reverse() //"camel", "sheep", 102, 374, 256, 1064
```

## Adding items into an array
### Adding to the end of the array

```js
var newLength = fruits.push('Orange');
// ["Apple", "Banana", "Orange"]
```

## Removing the last item of the array

```js
var last = fruits.pop(); // remove Orange (from the end)
// ["Apple", "Banana"];
```

## Finding a position of an item in an array

```js
var pos = fruits.indexOf('camel'); //5
```

> ## [Arrays => Javascript Documentation](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array)

---

