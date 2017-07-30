---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week04-js-userinput
---

# Week 04:

## User input

<a href="./week04-index.html" class="btn btn-default">Week 4 Topics</a> 

---

# Getting information

To interact with data using Javascript we use `alert`, `prompt` and `confirm` boxes.
This data can then be stored into a variable.

For now we will still show information to the console, but we could display this information in a proper website as well.

To display a message without any input we use an `alert` box:

```js
alert("I am an alert box!");
```

To deal with a simple choice input from a user we would use a confirm box.
Next we would use an `if statement` to control what the program does next.

```js
var txt; 

if (confirm("Press a button!") == true) {
    txt = "You pressed OK!";
} else {
    txt = "You pressed Cancel!";
}

console.log(txt);
```

Lastly to deal with user input we would use a prompt
Here the user is asked a question and that value is stored in a variable.

```js
var txt; 

var person = prompt("Please enter your name", "Harry Potter");

if (person == null || person == "") {
    txt = "User cancelled the prompt.";
} else {
    txt = "Hello " + person + "! How are you today?";
}

console.log(person);
console.log(txt);
```

# Displaying Information Better

Javascript relies heavily on the use of functions, so that not everything happens all at once as soon as a page loads.

How functions work will be explained in more detail, for now use the following code to help you out.

```html
<body>
    <button onclick="trythis()">Press me!</button>  <!-- we have a button that calls a function called trythis() -->
    <script src="scripts.js"></script>
</body>
```

```js

let trythis = () => {

    /* 
        This is an empty function, whatever code 
        is placed in here is called when the button is clicked.
    */
}

```

# Number Conversions

Javascript makes use of the functions `parseInt(string)` and `parseFloat(string)` to get a number value from a string.
The functions can be linked to a variable so that the numbers can be used in calculations etc.

```js

var input1 = "32"; //this is a string
var number1 = parseint(input1); //this is now a number

```
