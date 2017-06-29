---
layout: default
permalink: /remote-git
---

# Pushing and Pulling your repositories
To move your code to another computer you need to setup a remote connection.

**Note: before you can push anything to a remote server, you need to have done at least one single commit on your local machine.**

If you currently check with the command git remote -v you will notice that git will return nothing, because there are no remote connections setup.  
To set up the remote connection you need to know the computers / servers name and the location of the repository.  
We use a service called bitbucket which gives us the complete url that we need for this.

The url is in the format of
`https://<username>@bitbucket.org/<username>/<repositoryname>.git`

To create the remote connection we need the following command:

`git remote add origin <url>`
Once this command has been executed we can use the following commands to interact with the remote 
repository

# Git PUSH
This will upload the code to the remote server  
`git push origin master`

# Git PULL
This will download the code to your machine  
`git pull origin master`

# WORKFLOW
The best workflow for you to use is to pull the latest version of your repository before you start any work - even if this is only your own machine.
You then make the changes and when you are finished you push your code to the remote repository.
This way everything stays in sync. This becomes very important when working with 2 or more people.
The video below will show a demonstration of how to push and pull your code.

<a href="https://www.youtube.com/watch?v=B2Qfqb2YHJo" target="_blank">
    <span class="images">
        <img src="https://img.youtube.com/vi/B2Qfqb2YHJo/0.jpg" >
        <img class="playbtn playbtn2" src="./assets/images/playbtn.png" >
    </span>
</a>



# Git Clone
In the previous document you where told about git init which initiates the the repository in the folder you are working in.
It is also possible to create a remote repository on bitbucket and clone that to your machine. The benefit of this is that the remote connections are already setup.
If you do that you will need the git clone command to copy that folder on your machine.

`git clone <urL>`

Now there are a couple of need to knows:

* Git clone will create a copy of your the repository, they are not the same folder, it is not a shortcut.
* Git clone will create a folder in the folder you are currently working in, so if you want the folder to be in a specific place, you need to navigate to that first.
* It is possible to give the folder of the repository a different name than it has on the remote server, of that you will need to use the following command: git clone <url> <foldername>
* It is also possible to clone a folder in the folder you are in directly, i.e. it will not create a subfolder. For this you will need the following command: git clone <url> . NOTE: for this to work, you need to clone your repository in an empty folder.