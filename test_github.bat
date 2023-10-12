REM  Initialize Git (Version Control):  
git init
Rem Add the current directory
git add .
git commit -m "initial commit"

REM Create a .gitignore File for Unity: create/edit 
REM edit/notepad/ .gitignore (see note section).

REM Point Git To Your Existing Repo URL
set URL="https://github.com/mxawad2000/test.git"
git remote add origin %URL%

REM Verify That Your Repo Is Connected
git remote -v

REM - check the current branches
git branch --all

REM check out the folder you want..
REM git checkout -b spaceship

REM Push Changes To GitHub Repo - master/spaceship... must be there...
REM git push -u origin master
REM git commit -m "initial commit"

REM to see the content of the configuration of github files,
dir .git

REM I created a test repository for testing..

