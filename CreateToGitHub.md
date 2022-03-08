m**Map To GitHub via Terminal on new computer:
1. git config --global -e
2. git config --global user.name "Enter name"
3. git config --global user.email "Enter email"
4. git config --global core.editor code -w //this sets your code editor as VS Code

**Create A New Dotnet Console File And Push To Github:
- While in/chosen working directory
1. dotnet new console
2. dotnet new gitignore //creates .getignore file in project
3. git init //initalizes repository 
4. git add . //stages all files, use at beginning 
5. git commit -m "Insert name"
6. git remote add origin (enter repository url) //this is to map it to you repository to push.  Must use 'origin' variable for first push. git //This commits the files, make using hidden Git email.
7. git push -u origin main

**Push To a new Github repo:
- While in/chosen working directory
1. dotnet new gitignore //creates .getignore file in project
2. git init //initalizes repository
3. git add . //stages all files, use at beginning 
4. git commit -m "first commit"
5. git remote add origin (enter repository url) //this is to map it to you repository to push.  Must use 'origin' variable for first push. git //This commits the files, make using hidden Git email.
6. git push -u origin main

GIT Commands To Know:
git status: shows status
git branch: what branch you are on
git checkout -b 'branch name': creates a branch
git checkout 'branch name': switches to a branch
git remote -vv: shows your current fetch and push destinations 
git restore --staged 'FileName': removes file from staged
git reset: resets current tree
git branch -d 'branch name': deletes a branch

**Push to Github from C# GUI
1. Bottom right, make sure your source control is on the correct project (tap the three dots on the top right to create a new repository if needed)
2. If it is a pre-pushed program, an initial repo will already be completed.

 -----BREAK--

1) Create the project in Visual Studio
2) Browse to the folder with the project

Add a .gitgnore file for C#.Net
command line:

dotnet new gitignore
3) Create Local Git Repository
 command line:

git init
 NOTE: if your branch is master, instead of main, run the following:
 git branch -m master main

4) Stage & Commit your changes
 command line:
 git add .
 git commit -m "Initial Commit"

5) Check status
 command line:
 git status

6) Review your history:
 command line:
 git log --oneline
---------------------------
7) Create Repository at GitHub

8) Connect your local code to the GitHub repository
 command line:

git remote add origin "https://github.com/username/reponame.git"

9) Push your changes to GitHub
 command line:
 git push -u origin main

----------------------------------------
From here on, just use Visual Studio (or another git client)