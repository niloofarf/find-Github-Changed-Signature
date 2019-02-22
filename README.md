# Detecting Changes in Function Signatures of a given Github Repository

This project is an assignment for the University of Alberta. The purpose of the program is to mine Github repositories
and find all changed function signatures during the repository's project completion. 
The output of the project is a CSV file in the format of "Commit SHA, Java File, Old function signature, New function signature"


## Sample results

Three samples of the project's output exist in this repository's root entitled "Sample output 1 - gson.csv", 
"Sample output 2 - Java EE 7 Samples.csv", and "Sample output 3 - javamelody.csv".

"Sample output 1 - gson.csv" is the result of mining  the repository here: https://github.com/google/gson

"Sample output 2 - Java EE 7 Samples.csv" is the result of mining the repository here: https://github.com/javaee-samples/javaee7-samples

"Sample output 3 - javamelody.csv" is the result of mining the repository here: https://github.com/javamelody/javamelody


Moreover, an image in this repository's root shows the project's UI after a successful repository mining as shown below. 
You can also see in this image that outputs of mined projects are shown in both the UI and a CSV file.

<img src="The final UI.png" width="300" title="The final UI" />

You can also see an execution process of my project during mining "gson" repository in two successive videos at 
Youtube website here:

https://youtu.be/8-QduyiACPo

https://youtu.be/4f4seB37DjI



## How to use this project

### Prerequisites

- Windows OS

- .net Framework 4.6.1+

- Microsoft Visual Studio 2017+

- git

- Sourcetree (optional)


### Installing and Compiling

1. Download this project's repository from https://github.com/niloofarf/find-Github-Changed-Signature.git

2. Execute FindChangedSignatureInGit.sln file located in "FindChangedSignatureInGit" directory by double-clicking on it.
(After that the visual studio will be executed)

3. In Visual Studio click on <b> Build > Rebuild </b> Solution menu to rebuild the project

4. Run the project by clicking on "start button" at the standard toolbar on top of the Visual Studio
(If the standard toolbar is not shown, right click on the left side of the toolbar and from the context menu click
on standard toolbar)

5. IF you have any problem in installing the project please contact the author here: http://www.niloofarfathi.ir


### Execution Tutorial

1. In order to mine a repository download that repository to your local computer by sourcetree or git command line.
(For more information about how to download the repository please visit: https://help.github.com/en/articles/cloning-a-repository)

2. Click on "Git Checker" button on the project's main UI, and from the opened dialogue, select the downloaded repository's 
directory on your local computer.

3. The program will be executed, and it will start mining the project. The status of the project and the number of processed
commits and files will be shown on the UI progressively.

  - "Processing ..." means the program is executing.
  - "The process is finished!" means the mining process finished successfully.
  - "The process is finished with Exception!" means mining process finished unsuccessfully.

4. During the process, each changed signatures found by the program will lively show on the UI 

5. At the end of the process, a button will be visible on the UI named "Open result.CSV". By clicking on that button, result.CSV
will be opened on your computer. The location of result.CSV file will be created at the directory below on your computer:

```
[This Project Directory on your Computer]\GithubChecker\bin\Debug\result.CSV
```

## Authors

Niloofar Fathi

## Acknowledgments

Prof. Sara Nadi
