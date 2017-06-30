---
layout: default
permalink: /setup-vscode
---

#  Visual Studio Code  (VSCode for short)

Visual Studio Code is a lightweight editor that offers a lot of features. 

# Work from a folder

When you open vscode for the first time, you will see a purple bar at the bottom. This means that you are not in the context of a folder.
Although you can work on files like this, you must not do so, since the relative links to your project won't work.

To open a folder do one of 3 things:

* Click on the blue button that says "Open Folder"
* Click on the file menu (windows) and select Open Folder
* Type in  `Ctrl+O` and select the folder you want to work in.

# Work from a folder

The search option on the side searches for the content in the files of the folder that you are working in. It does not search for the files itself.
Therefore a folder structure is important so that you know where your files are most likely to be.

You can also use this section to do a global find and replace.

# Git 

The use of git is integrated really well into VSCode in the GUI part as well as by using the integrated terminal.
  
By default on Windows, VSCode refers to Powershell, since that is the default command line tool (Since the Creative Update).
  
For this course we will be using Git-bash which is installed when you install git for windows.
  
To change your default command line tool to git bash add this line to your user settings:

```
"terminal.integrated.shell.windows": "C:\\Program Files\\Git\\bin\\bash.exe"`
```


As a power user option, if you use windows 10 and you use the Ubuntu subsystem, you can use the ubuntu terminal as well

```
"terminal.integrated.shell.windows": "C:\\Windows\\sysnative\\bash.exe"
```

> Tip: To find your user settings on Windows go to File > Preferences > User Setting

# Debugging

This is used to debug your application, we will cover this later.

# Extensions 

You can add extensions to customise your installation.  
The one you will need is C# from Microsoft.
The way to set this up is:  

**Step 1:**  
Go to the extension tab on the side (the bottom icon)

![VScode-extensions](./assets/images/vscode-extensions.png)

**Step 2:**  
Search for the extension you need and click on install

* Once the extension is installed you will need to reload the VSCode
* Once it has reloaded, it is all done

![VScode-install-extensions](./assets/images/vscode-install-extensions.gif)
