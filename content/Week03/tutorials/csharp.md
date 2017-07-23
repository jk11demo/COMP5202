---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week03-csharp-tutorials
---

# Week 03:
## Recap on Variables, Loops and Arrays

<a href="./week03-index.html" class="btn btn-default">Week 3 Topics</a> 

---

# Setup a new project

This should be a familiar process by now, but needs to be practices regularly.

For good habits, we will always create a project with a git repository. Even if we only keep track off it on our local machine. 

>Once you loose your work or make a fatal mistake using github will become second nature, however I hope it does not come to that

Remember to setup a new project to do this:  
## Note: replace <name> with a name for your repo

* Open git bash
* Go to desktop : `cd ~/Desktop`
* Create a folder with a git repo :  `git init <name>`
* Go into the folder : `cd <name>`
* Create dotnet project : `dotnet new console`
* Open the project in vscode : `code .`

Once you are in your project, open the integrated terminal (`Ctrl + Backtick`) or (`⌘+backtick`)
Now you are in the project folder and could close the git bash windows (this is optional)

Run your project:

* Setup all the packages for your project : `dotnet restore`
* Check if you have any errors : `dotnet build`
* Run your project : `dotnet run`

Commit your project to git and upload it to github
`<url>` = your github repository link, you will need to create one

* Add files to git repository : `git add .` (`.` represents current directory)
* Commit files to your repository : `git commit -m "Your commit message"`
* Add your remote github link : `git remote add origin <url>`
* Push your content to github : `git push origin master`

> Note: all git options can be done from selecting the commands in the command  (`Ctrl+Shift+p`) or (`⌘+Shift+p` on macos)

> The above commands should become second nature. Keep practising this until you do not need to look at your notes anymore

---

# Creating Code Snippets

You will have noticed that when you run your project there is a lot of code noise around your output.
To prevent that from happening we can create a little code snippet. 

## <a href="http://to-bcs.nz/Toolbox/VSCode/code-snippet" target="_blank">Setup a code snippet</a>

---

# Playing with Loops

## loops-pg01 - Simple Loops

Create a new project and call it loops-pg01 (Loops Playground 01)

***Do a git commit and call it `Initial Commit`***

Setup a constant that will serve as your counter.
* Set the value to 5

Setup a constant that will serve as your index.
* Set the value to 0

Next create a for loop that will print the line `Hello World` the number of times to which the counter has been set. 

Next create another for loop that will print the line `Hello World` again for the number of times to which the counter has been set, but also add the value of the current counter position. 

If you do not know how to setup a loop, go back to the slides and add it to yoru coding journal.

***Do a git commit and call it `added simple forloop`***

Now comment out the code from the previous loop and its setup.

Setup a constant that will serve as your counter.
* Set the value to 50

Setup a constant that will serve as your index.
* Set the value to 0

In a code block of a loop you can use if statements.

Setup a code block of a loop that will print out all the even number values. Hint, for this we use the `modulus` operator.

***Do a git commit and call it `added forloop that displays even numbers`***

Comment out the code from the previous loop and its setup.

Create a `while loop`

Set the counter constant to 50, but this time instead of displaying the even numbers, display the odd numbers.

***Do a git commit and call it `added while loop that displays odd numbers`***

Comment out the code from the previous loop and its setup.

Setup a counter constant with the value of 100  
Setup an index variable with a value of 200

In the code block of the loop run an if statement that checks if the index number can be divided by 25.

This should be printed only once

***Do a git commit and call it `added do-while loop that displays odd numbers`***

---

# Playing with Lists<T>

## loops-pg02 - List<T> Loops

Create a new project and call it loops-pg02 (Loops Playground 02)

***Do a git commit and call it `Initial Commit`***

Using loops with arrays and lists is exactly the same as what you did above with numbers.

The length of the Lists will serve as your counter.

If the following code is your list:
```csharp
var fruits = new List<string> {"apple", "banana", "orange", "tomato", "pear"}
```
Then your counter would be setup as

```csharp
var counter = fruits.Count; //this returns an int
```

> To be able to work with [`Lists<T>`](https://msdn.microsoft.com/en-us/library/6sh2ey19(v=vs.110).aspx) make sure you add the following namespace at the top:
[`System.Collections.Generic;`](https://msdn.microsoft.com/en-us/library/system.collections.generic(v=vs.110).aspx)

In your project use the list from above with the fruits and create a forloop that prints them to the screen.

***Do a git commit and call it `added forloop that displays all fruits`***

Comment out the previous code.

Create a list of 50 random names, for this you can use this website:

<a href="http://listofrandomnames.com" target="_blank">http://listofrandomnames.com</a>

Set them up in a List<T>, the best way is to use this syntax:

```csharp
var randomnames = new List<string>();
randomnames.Add('name'); //do this 50 times.
```
>Hint: VSCode has shortcuts that help you with doing repetitive stuff like this:<a href="https://github.com/Microsoft/vscode-tips-and-tricks" target="_blank">Check this document out under the section Editing Hacks</a>

In C# you can find the first character of a string using this: `MyString[0]` where MyString is the name of a string variable.

Your task: Print out all the names that start with B, M and P - now this is completely random, you may not get any names with some or any of these characters.

***Do a git commit and call it `Forloop displays names starting with B, M or P`***

Comment out the previous code.

*	Create an List<T> with 5 movie titles and display
	them each on a new line.

*	Change the title of the first movie and the
	title of the 3rd movie

*	Sort the array of task b) in alphabetical order

*	Display on the screen the length of the array

*	Display on the screen the whole array as a
	string

***Do a git commit and call it `Added a List<T> about movies`***




















