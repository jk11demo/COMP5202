---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week01-csharp
---

# Week 01:

---

## Tutorial 4a: Install dotnet SDK (only once)

---

To start working with C#, you will need to install the `dotnet core SDK`, so that you can compile (run and see) your application.

The best way to see how to install it is to follow the instructions directly from Microsoft.

Select the right page for the Operating System you are using:

| Download and Install dotnet core |
| --- | --- | --- |
| [Windows](https://www.microsoft.com/net/core#windowscmd) | [Linux](https://www.microsoft.com/net/core#linuxubuntu) | [macOS](https://www.microsoft.com/net/core#macos) |

---

## Tutorial 4b: Creating your first app (every time)

---

## Creating a new app

Open up the terminal  

You can follow along on the dotnet website to create your first `Hello World` app, but here are some more tips:
After you create your [git repository](./first-git), you can do the following to create your C# app.

| Command | Explanation |
| --- | --- |
| `dotnet new console` | This will create the new app in the current folder, so makes sure you are where you want the app to be |
| `dotnet new console -o folder` | This will create the new app in a specified folder with the project being the same name |
| `dotnet new console -o folder -n project` | This will create the new app in a specified folder with the project having a specified name |

Once you have created the project you can type in `code .` or `code <folder name>` to start vscode

If you have not installed the C# extension yet, you need to do that now. [Go here](./setup-vscode) to see how to do it

## Changing the Program.cs file

The `Program.cs` file is the main file for your application and we will create other files later on.
In the Main method you will see a line called `Console.WriteLine("Hello Wolrd!")`

Change this into `Console.WriteLine("Welcome to COMP5202 - Programming Fundamentals")`

Back in the terminal run the following commands:

* `dotnet build` you should see two green lines, saying that you have 0 warnings and 0 errors.
* `dotnet run` this will show the line you just wrote on the screen.

There you go, your first simple app.

---

## Tutorial 4c: Deploying your application

---

Deploying your application means you are ready to set it up so other people can use it.  
So far you the app(s) you have run have been done inside a development environment. All the tools you need have been installed. What if you want to show your application on a machine that doesn't have these tools installed?  
Full on windows / macOS and Linux apps will need to be packaged and can run from a single file.  

dotNet Core is slightly different, yes there is a single application file, but it is in a folder that has the dependencies with it. This might and hopefully will change in the future, but for now, it is about keeping it all inside a folder.  

Now the platform will still create an executable file and you can still run that by double-clicking on it - so let's have a look at how to do that.  
Once you have published your app you will need to do a git commit to update the changes in your repository  

<a href="//to-bcs.nz/DotNetCore/dotnet-core-deploy" target="_blank">Deploy your app</a>

---

## Tutorial 4d - Looking at Documentation

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