This is how you start adding work each time you work on code.

Fetch

Fetching refers to getting the latest changes from an online repository without merging them in.
Once these changes are fetched you can compare them to your local branches (the code residing on your local machine).

command would git fetch or it would be git fetch upstream (branch name)

Pull

Pull refers to when you are fetching in changes and merging them. 
For instance, if someone has edited the remote file you're both working on,
you'll want to pull in those changes to your local copy so that it's up to date.

command would be git pull or it would be git pull upstream (branch name)


when ready to commit always commit to your origin (branch name) that way the work goes to you and not the owner of the repo
that you have forked and cloned.


Commit

A commit, or "revision", is an individual change to a file (or set of files). 
It's like when you save a file, except with Git, every time you save it creates a unique ID (a.k.a. the "SHA" or "hash") 
that allows you to keep record of what changes were made when and by who. 
Commits usually contain a commit message which is a brief description of what changes were made.


when ready to push always push to your origin (branch name) that way the work goes to you and not the owner of the repo
that you have forked and cloned.


Push

Pushing refers to sending your committed changes to a remote repository, such as a repository hosted on GitHub. 
For instance, if you change something locally, you'd want to then push those changes so that others may access them.


