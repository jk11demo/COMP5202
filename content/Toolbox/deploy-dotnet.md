---
layout: default
semester: All Semesters
permalink: /dotnet-core-deploy
---

# Deploy dotnet core application:

> <span class="info-tip iconlrg label-info"><i class="devicon-csharp-plain"></i>dotnet core</span>

To deploy your app so that other people not on your machine can use it, the csproj file needs to be updated.
For the simplest deployment, simply replace the current content of your csproj file with the code snippet below.

<script src="https://gist.github.com/bcsjk11/707c817fa3e013a530832e251fefa8b8.js"></script>

Once you have done that you need to run the following commands in the terminal:

* `dotnet restore` to load the dependencies for your app.  
* `dotnet build` to make sure you still have 0 warnings and 0 errors and create a build version of your app.  

Now for every platform you wish to have a version of your app you need to do this:

`dotnet publish -c Release -r <platform>`  

| Windows | macOS | Linux |
| --- | --- | --- |
|`dotnet publish -c Release -r win10-x64`|`dotnet publish -c Release -r osx.10.12-x64`|`dotnet publish -c Release -r ubuntu.16.04-x64`|

Now we have a complete running application that can be found in the `/<project>/bin/Release/<netcore version>/platform/<app>.dll`

Finally you may also note that you have a lot of files ready to be added to your git repository, if you have one setup.
To limit what you keep a track off you will need to setup a `.gitignore` file.

When deploying .netcore apps, you don't want the final binary file uploaded to the repository, so add the following folders to the .gitignore file:

* .vscode/
* bin/
* obj/

Then you will see the number decrease to just the changes you made.