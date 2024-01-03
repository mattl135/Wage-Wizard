# Wage-Wizard
 An application developed in DotNet 6.0 for the subject Applications Development in .Net (31927)

 ## Inatructions for cloning the repository:
 1. Open Visual Studio to the "Get Started" screen.
 2. Click "Clone Repository"
 3. Click "GitHub" (Sign in if required).
 4. Select the Wage-Wizard repository. Local path can be changed if required.
 5. Click Clone to clone the repository.

 ## Instructions for running / editing:
 1. Open the file "Wage Wizard.sln". Or select from Visual Studio recent projects list.
 2. Under the "Solution Explorer" and double click the "Wage Wizard.sln" to initalise the WinForms editors.
 3. In the menu bar, under the menu option "Git", select "Fetch" then select "Sync" and wait for the operation to complete.
 4. Once the git sync completed, Rebuild the project by selecting under the menu option "Build" selecting "Rebuild Solution".
 5. Wage Wizard should now be able to be executed with the Cloud Database. Note that if local database is required follow the steps below.

 ## Instructions on running the program with a local database
 1. Change the variable "useProductionDB" in the path "Wage-Wizard\Data\WageWizzardContext.cs" to "False".
 2. Open the package manager console by Menu Bar > View > Other Windows > Package Manager Console.
 3. Enter the command "update-database" into the Package Manager Console.
 4. When the command has finished running, the program should be able to be run.
 5. The local database can be monitored and edited using Menu Bar > View > SQL Server Explorer and navigate through the local server to view the database.

## Instructions on how to modify the database schema
 1. Open the package manager console by Menu Bar > View > Other Windows > Package Manager Console.
 2. Enter the command "Add-Migration <YourNewMigrationName>" into the Package Manager Console.
 3. If successful, a migration file will be created. Review the file CAREFULLY to ensure that changes to be applied are accurate.
 4. If the migration file is blank, or is incorrect, it can be disregarded using the command "Remove-Migration".
 5. If the migration file is acceptible, it can be applied to the database using the command "update-database".

 ## Instructions for comitting;
 1. In the menu bar, under the menu option "Git", select "Commit or Stash".
 2. Input a relevant message describing changes made.
 3. Click Commit.
 4. In the menu bar, under the menu option "Git", select "Sync" and wait for the operation to complete.

 ## Application Logins
 ### Administrator Account
 ID: 100000
 Password: password1

 ### Employees Logins
 ID: 100006
 Password: password7