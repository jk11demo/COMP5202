---
layout: default
semester: Semester 17B
coursecode: COMP502
coursename: Fundamentals of Programming
permalink: /notes-javascript
---

# Week 01:
## First time Javascript - Setup your page

Javascript can be used in many different ways, for now let's start by seeing in the browser.  

1. Open up the terminal and navigate to your desktop
2. Type in `git init first-javascript` (Note always good to start this way, so that you have a git repo in your folder)  
3. Type in `code first-javascript` to open code with the selected folder
4. Create a new file called `index.html` and select so you can add text to it in the main section.
5. Type in the `!` character followed by the `<TAB>` key. This will set you up with a basic HTML page.
6. In the left panel, create another file called `script.js`
7. Back in the `index.html` add the following line to connect the javascript file to the index.html file
```html
<script src="script.js"></script>
```
8. Now open the script.js file can type in `document.write("Welcome to COMP5202 - Programming Fundamentals")`
9. Go to your first-javascript folder and double-click on the `index.html` file

You should now see the line displayed in the browser.

Note that to use javascript, you do not need to install anything. However you can use JS Libraries which we will look at later.
