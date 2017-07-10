---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week01-javascript
---

# Week 01:

---

## Tutorial 4a: Creating your first app (every time)

---

## Creating a new project

Javascript can be used in many different ways, for now, let us start by seeing in the browser.  
After you create your [git repository](./first-git), you can do the following to create your C# app.

Open up the terminal and navigate to your desktop

```bash
cd ~/Desktop
```

Type in `git init first-javascript` (Note always good to start this way, so that you have a git repo in your folder) 

Once you have created the project you can type in `code .` or `code <foldername>` to start vscode
  
Type in `code first-javascript` to open vscode with the selected folder

## Creating the index.html file

There are a number of ways you can create files to start your project.
I would suggest one of these 3 options, depending on your preference.

* From the terminal `code <folder> <folder>/file`
* From the file menu, select new file
* From the left panel, right click and select new file
* Use the keyboard shortcut, Type in `Ctrl+N` or `⌘+N`

Create a new file called `index.html` and select so you can add text to it in the main section.

You also want to create a file called `script.js`, we will get to that later, first select the index.html file.

## Adding the script.js file

Type in the `!` character followed by the `<TAB>` key. This shortcut will set you up with a basic HTML page.

Back in the `index.html` add the following line to connect the javascript file to the index.html file

```html
<script src="script.js"></script>
```

Place it just above the `</body>` tag

## Changing content in the script.js file

Now open the script.js file can type in `document.write("Welcome to COMP5202 - Programming Fundamentals")`

Go to your first-javascript folder and double-click on the `index.html` file

You should now see the line displayed in the browser.

Note that to use javascript, you do not need to install anything. However, you can use JS Libraries which we will look at later.

---

## Tutorial 4b: Deploying your website

---

This is just a need to know for now

> We will talk about using a webserver later in the course.
