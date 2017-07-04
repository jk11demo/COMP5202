---
layout: default
semester: All Semesters
permalink: /vscode-code-snippet
---

# Setup a code snippet

When we use a particular code block often, it is nice to create a shortcut for it.

VSCode allows us to set code snippets and to set one up we need four parts:

* `New Program` is the snippet name
* `prefix` defines how this snippet is selected from IntelliSense and tab completion. In this case np. (We will use np - but you can make up anything else)
* `body` is the content and either a single string or an array of strings of which each element will be inserted as a separate line.
* `description` is the description used in the IntelliSense drop-down

## Creating a user snippet
Step 1 - Getting to the code snippet panel 
 
* Open Visual Studio Code
* Click on File (Windows & Linux) or VScode (Mac) > Preferences > User Snippets.
* A list will pop up with programming languages - select C# from this list.

Step 2 - Adding your code snippet.
 
On this screen, you will see 2 curly braces and a whole lot of comments explaining how to go through this process.

Below you can see the template for a basic code snippet:
<script src="https://gist.github.com/bcsjk11/46a6d3c02743c73c209022febf1117fe.js"></script>

For our purposes let's use this snippet. It will create a nice clean look for when we run our app.
<script src="https://gist.github.com/bcsjk11/049731e3931bf5848fe20ad71bcb3138.js"></script>

Copy the above code into the csharp.json file under the green commented text.

Save the file by pressing `Ctrl+S` (Windows and Linux) or `⌘+s` (macOS) and close the file.

# Using the user snippet
Now when you are in your Program.cs file you can type in `np <ENTER>`, and you will see the snippet appear in your program.
