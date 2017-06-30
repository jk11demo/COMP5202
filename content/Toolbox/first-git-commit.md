---
layout: default
semester: Semester 17B
coursecode: COMP502
coursename: Fundamentals of Programming
permalink: /first-git
---

# Learning about Git:
## Creating your first repo and commit

For this tutorial we are going to explore git. We will just do some surface stuff to get you used to the idea and have a look what the important parts are to look.

1) Open Git-bash (On Windows) / terminal (On macOS or Linux)  
2) Navigate to your desktop.
```
//On Windows type in
cd /c/Users/studentid/Desktop/
```
```
//On Mac and Linux type in:
cd ~/Desktop
```

Although the `~/Desktop` command will work on your own machine, On other machines that have been preconfigured, your home user folder might be on a different place.

3) To create a git repository we use the following command

`git init <foldername>`

Type in the following command to create a git repository

`git init MyFirstRepo`

4) Now go into this folder by typing `cd MyFirstRepo`

`cd` means change directory

5) To open this folder in vscode, type in `code .`

This will open vscode with this folder as your context.  

> Tip: If you want to create a new file in this folder at the same time you can type in  
`code name-of-your-file.extention` <br> Try typing in `code index.html` from the terminal
  
6) In the main area you can type something in, since you created an **html** file type in `!` followed by the `<TAB>` Key. Don't worry about what it means, it is just a basic website template.
  
You will notice that the file symbol has a blue circle with a number one in it, this means you have one file that has not been saved.
  
Save the file by typing in `Ctrl+S` on Windows and Linux or `⌘+S` on macOS
  
You will notice that the blue circle with a one moves down to the third icon, now this means that there are either untracked or changed files in your repository. So you will see that this is a 2-step process.
  
7) Click on this icon and you will see a text box at the top with the files you have saved below it.  
When you hover over those files you will see a plus and a back arrow appear. Click on the plus and it will be added to the Staged area (we will cover this later)
Then you can write you commit message above it and type in `Ctrl+<ENTER>` on Windows and Linux or `⌘+<return>`
  
8) Now if you open up the terminal again and type in `git log` you will see the commit you just made.
  
Later in the course we will look more into how this all works in more detail. For now just save all your work this way and when you write a commit message give a short description of what you have done, so that when you look back on it later it means something to you.