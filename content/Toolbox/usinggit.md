---
layout: default
permalink: /setup-git
---

# What is Git?

A quick overview about git and how to set it up
Git is a version control system which allows you to manage your projects, protect them and share them.
* In this course we will use git to see our work and submit our assessments.
* The use of git will be seen as a foundation in all your work. It will have a strong presence in the courses, but it will not always be the main focus.

# How do we use git?
Git uses a basic set of commands that will allow it to track the changes that are being made. There are several ways to set it up your workspace depending on how you or your team work.

# Setup a git repository
This will set up your git repository on your machine if you are starting a brand new project and you have not set up a remote project yet.
git init

# Configuring git so it knows who you are
Before you make your first commit you will need to let git know who you are. Although it is possible to make commits before this, git will remind you to set this up every time you make a commit.

`git config --local user.name "your name"`  
`git config --local user.email "youremail@email.com"`  

# Adding your code to a repository
For git to be able to track the changes in your project you will need to add your code. There are several commands that allow you to add different portions of your code.

**Add everything in the current folder**  
`git add .`

**Add a specific file**  
`git add <filename.txt>`

**Add a specific folder**  
`git add <foldername>`

# Commit your code to the repository
At this stage your code has been staged so the repository knows you are ready to commit the code. Since you can commit all of a number of files you will need to add them to the staging area first.
In your commit message you will need to pass in an action based commit message. Think of it this way. This commit is going to do something, it has not already been done.

**Example are:**
* Add login screen
* Change background colour to match client brief
* BUGFIX: fix spelling mistake on the homepage

`git commit -m "Your message here"`

Up to this point everything has happened locally on your own machine, for this code to be on a remote server you will need to push your code to it.