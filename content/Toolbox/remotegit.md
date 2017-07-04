---
layout: default
semester: All Semesters
permalink: /remote-git
---

# Pushing and Pulling your repositories
To move your code to another computer you need to setup a remote connection.

**Note: before you can push anything to a remote server, you need to have done at least one single commit on your local machine.**

If you currently check with the command `git remote -v`, you will notice that git will return nothing, because there is no remote connection setup.  
To set up the remote connection, you need to know the computer's/server's name and the location of the repository.  
We use a service called github which gives us the complete URL that we need for this.

The URL is in the format of
`https://github.com/<remoteaccount name>/<repositoryname>.git`

To create the remote connection we need the following command:

`git remote add origin <url>`
Once we execute this command we can use the following commands to interact with the remote 
repository.

# Git PUSH
Use this command will upload the code to the remote server.
`git push origin master`

# Git PULL
Use this command to download the code to your machine.
`git pull origin master`

# WORKFLOW
The best workflow for you to use is to **pull** the latest version of your repository before you start any work - even if this is only your own machine. If you are wanting to work on a different branch, use the command `git fetch && git checkout <branch name>`
You then make the changes and when you are finished you push your code (or create a pull request if it is someone else's code) to the remote repository.
This way everything stays in sync. This workflow becomes very important when working with 2 or more people.
The video below will show a demonstration of how to push and pull your code.

<a href="https://www.youtube.com/watch?v=B2Qfqb2YHJo" target="_blank">
    <span class="images">
        <img src="https://img.youtube.com/vi/B2Qfqb2YHJo/0.jpg" >
        <img class="playbtn playbtn2" src="./assets/images/playbtn.png" >
    </span>
</a>



# Git Clone
In the previous document, it mentions `git init` which initiates the repository in the folder you are working.
It is also possible to create a remote repository on github and clone that to your machine. The benefit of this is that the remote connections are already setup; if you decide to do that, you will need the `git clone` command to copy that folder on your machine.

`git clone <urL>`

Now there are a couple of need to knows:

* Git clone will create a copy of your the repository; they are not the same folder, it is not a shortcut.
* Git clone will create a folder in the folder you are currently working in, so if you want the folder to be in a particular place, you need to navigate to that first.
* It is possible to give the folder of the repository a different name than it has on the remote server, of that you will need to use the following command: git clone <url> <foldername>
* It is also possible to clone a folder in the folder you are in as the base folder, i.e. it will not create a subfolder. For this, you will need the following command: git clone <url> . NOTE: for this to work, you need to clone your repository in an empty folder.