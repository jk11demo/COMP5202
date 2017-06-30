---
layout: default
semester: Semester 17B
coursecode: COMP502
coursename: Fundamentals of Programming
permalink: /notes-csharp
---

# Week 01:
## First time C# - Install dotnet SDK (only once)

To start working with C# you will need to install the `dotnet SDK`, so that you can compile (run and see) your application.

The best way to see how to install it is to follow the instructions directly from microsoft.

Select the right page for the Operating System you are using:

| Download and Install dotnet core |
| --- | --- | --- |
| [Windows](https://www.microsoft.com/net/core#windowscmd) | [Linux](https://www.microsoft.com/net/core#linuxubuntu) | [macOS](https://www.microsoft.com/net/core#macos) |

## Creating your first app (every time)

Open up the terminal  

You can follow along on the dotnet website to create your first `Hello World` app, but here are some more tips:
After you create your [git repository](./first-git) you can do the following to create your C# app.

| Command | Explaination |
| --- | --- |
| `dotnet new console` | This will create the new app in the current folder, so makes sure you are where you want the app to be |
| `dotnet new console -o folder` | This will create the new app in a specified folder with the project being the same name |
| `dotnet new console -o folder -n project` | This will create the new app in a specified folder with the project having a specified name |

Once you have created the project you can type in `code .` or `code <folder name>` to start vscode

If you have not installed the C# extension yet, you need to do that now. [Go here](./setup-vscode) to see how to do it

## Changing the Program.cs file

The `Program.cs` file is the main file for your program, we will create other files later on.
In the Main method you will see a line called `Console.WriteLine("Hello Wolrd!")`

Change this into `Console.WriteLine("Welcome to COMP5202 - Programming Fundamentals")`

Back in the terminal run the following commands:

* `dotnet build` you should see 2 green lines, saying that you have 0 warnings and 0 errors.
* `dotnet run` this will show the line you just wrote on the screen.

There you go, your first simple app.