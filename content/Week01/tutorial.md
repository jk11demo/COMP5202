---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week01-tutorial
---

# Week 01:
## Into to tools and methods

<a href="/COMP5202/week01-index" class="btn btn-warning">Go back to notes</a> 

---

## Tutorial 1: Get a Peer Coding Partner

---

This tutorial may seem relatively straightforward, but it is one that requires a bit of research. The research is in getting to know your classmates.  
Earlier in this course, there was a video on what Peer Programming is, so have a look through that, if you skipped it or want a refresher.  
Once you have picked a team partner, Go through the next set of tutorials as a peer-coding-team.  

---

## Tutorial 2: Explore Visual Studio Code

---

Visual Studio Code is an open source lightweight code editor. It has the option to add extensions, just like most modern web browsers these days. To learn more about Visual Studio Code read through <a href="//to-bcs.nz//Toolbox/VSCode/walkthrough" target="_blank">this link</a>
<br>


---

## Tutorial 3: Create your first git repo and commit to it

---

Let's have a quick look at how git works and create a repository.
This will not leave your machine, but gives you an introduction of how to start.

<a href="//to-bcs.nz/Toolbox/Git/first-git" target="_blank">My First Git Project</a>

---

## Tutorial 4: Code your first application

---

This task splits up into 2 sections, one is for C# and the other is for JavaScript.

Each button will open in a new tab, follow the steps on each page to complete the task

<a href="./week01-csharp" target="_blank" class="iconlrg btn btn-info"><i class="devicon-csharp-plain">  C# Module</i></a>
<a href="./week01-javascript" target="_blank" class="iconlrg btn btn-warning"><i class="devicon-javascript-plain">  JS Module</i></a>

---

## Tutorial 5: Deploying your application

---

Deploying your application means you are ready to set it up so other people can use it.  
So far you the app(s) you have run have been done inside a development environment. All the tools you need have been installed. What if you want to show your application on a machine that doesn't have these tools installed?  
Full on windows / macOS and Linux apps will need to be packaged and can run from a single file.  

dotNet Core is slightly different, yes there is a single application file, but it is in a folder that has the dependencies with it. This might and hopefully will change in the future, but for now, it is about keeping it all inside a folder.  

Now the platform will still create an executable file and you can still run that by double-clicking on it - so let's have a look at how to do that.  
Once you have published your app you will need to do a git commit to update the changes in your repository  

<a href="//to-bcs.nz/DotNetCore/dotnet-core-deploy" target="_blank">Deploy your app</a>
---

## Tutorial 6: Setting up Code Snippets

---

When we code, we often repeat certain code blocks or patterns quite often. Some of them are complicated and some not so much.  
However, some are tedious - for example, what if every time you started a project you had to retype the beginning and end part of a program?  
Let's have a look at how we make life a little easier using user code snippets.  

<a href="//to-bcs.nz/VSCode/code-snippet" target="_blank">Code Snippets</a>
---

## Tutorial #7 - Looking at Documentation

---

The internet is loaded with documentation and videos to find what we need when learning how to code.
So far we have looked at the console class and how some of the methods work.  
We can find the documentation for the console class here:  

<a href="https://msdn.microsoft.com/en-us/library/system.console(v=vs.110).aspx" target="_blank">MSDN System.Console</a>

To get to that website, it is as simple as searching in Google for MSDN C# Console Class

The Console Class has a lot of properties and methods and we will only use a small selection of them. However, it is interesting to look at some.

Let's have a look at the following methods and properties:
* Foreground Color
* WriteLine
* ReadLine
* Clear
* ResetColor