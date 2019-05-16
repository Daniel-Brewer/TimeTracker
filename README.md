TimeTracker
This Application allows the user to keep track of how they are spending their time. The user may input category names, select a date, and input minutes spent per category. Once the data is submitted, the user may view their entries and time spent on a monthly basis.

Getting Started
The following instructions will get you a copy of the project to run on your local machine for development and testing.

Prerequisites
You'll need the following:

 Visual Studio
 Microsoft SQL Server Management Studio

Installing & Running

Fork a copy of this Repository

Download or Clone the Repo to your local machine

In appsettings.json, verify that the "ConnectionStrings" values are as follows:

"ConnectionStrings": {
   "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=TimeTracker;Trusted_Connection=True;MultipleActiveResultSets=true"
 }
 
Navigate to Tools menu at top of Visual Studio, then NuGet Package Manager, at the command prompt type: "add-migration Database", hit enter, then type "update-database" hit enter. Verify that you have a fresh database in SSMS

Look at the top bar of Visual Studio and find the green arrow "play button", and make sure TimeTracker is selected and click the arrow. This should load the project.