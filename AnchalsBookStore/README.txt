Name : Anchal Walia
Date : 8 November 2022
Assignment 2 

{Part 1}
12:57am : Created the new project and started it by adding git files.
1:15am  : Avoided the sign flag by removing two lines from the startup.cs file.
1:35am  : Test the debugging but it does not works because by mistake, I removed the .AddEntity line from Startup.cs.
          After solving it, I again test debugging and now it works.
1:50am : Selected the theme Superhero from Bootswatch.com.Replaced the given bootstrap.cs file by the bootstrap.cs file 
         downloaded from Bootswatch.com.
1:57am : Changed the file name from bootstrap.min.cs to bootstrap.cs. Also Replace the navbar-light to navbar-dark, 
         bg-white to bg-primary and remove the text-dark in line 23 from the _Layout.cshtml.
2:02am : Removed the text-dark from the _LoginPartial.cshtml.
2:08am : Added the additional properties to the footer class in _Layout.cshtml.
2:13am : Forget to replace the given site.css file so replaced that file with the file given in blackboard.
2:20am : Added the additional stylesheets and scripts given in CSS_JS.txt file in blackboard in _Layout.cshtml file.
2:23am : Added the dropdown navbar code from the theme selected from the Bootswatch.com in _Layout.cshtml.
2:35am : Added the dropdown in _Layout.cshtml but after running on browser it just display the text content Management
         but dropdown is not working so i found that the version given in bootstrap.css is 5.2 and we have to use 4.3 
         or 4.6 so again downloaded the file in 4.6 version and repeat the step and now it works.
2:40am : Taking a break for 30 minutes and after that i will start again.
3:10am : Back after the break.
3:18am : Added all three projects to application.
3:20am : Pasted the data folder into data access folder and deleted the existing one.
3:41am : Installed the microsoft packages.
3:43am : Deleted the migartion folder. 
3:46am : Installed the NuGet package identity framework.
3:49am : Adding the data access in namespace in ApplicationDbcontext.cs.
3:51am : Deleted all the three default class1.css files from the project.
3:55am : Build the project but get three errors in Statup.cs file and trying to solve it in next step.
3:58am : Moved Models into AnchalsBooks.Models and deleted the original one.
4:04am : Added the project reference, renamed the models folder and done the Change the ErrorViewModels.cs namespace to .Models.ViewModels.
4:09am : Again getting the errors in startup.cs file after building the project.
4:17am : After changing the refernce of Data field to DataAccess,it finally works and showing 0 errors.
4:20am : Build the project but again it showing the error in ErrorViewModel.
4:24am : After solving the previous error. Now getting the new two errors:(.So much tired and sleepy but have to complete the assignment:(.


14 November 2022
3:23pm : Changed the reference name of model in error.cshtml file.
3:34pm : Added Static class SD.cs in utility project and modeified it's property.
3:37pm : Added project reference to the main project.
3:38pm : Added project reference to models and utility in DataAccess project.
3:52pm : Customer area is added to Area .
3:58pm : Change the routes in Startup.cs.
3:59pm : Moved the HomeController.cs to Controller file in Area and deleted models and data from it.
4:01pm : Defined the controller in HomeController.cs.
4:02pm : Moved Home in Views to Area in view and then modified the namespace in HomeController.cs.
4:13pm : IIs express error is occured and the error is in dll file so restarted from task manager IIs service and resolved the error. Finally it solved and
         the project run.
4:20pm :  Both _View files are also pasted in Area.
4:24pm : Modified the path of _ViewStart.cshtml.
4:27pm : New admin ia added in area.
4:28pm : Data and Model folder is deleted from Areas.
4:48pm : Again pasted the readme from github because all new changes are removed due to merge conflict.


{Part 2}
4:50pm : Build the application to confirm that there are no error in part 1.
4:52pm : Modified the database name and save it in appsettings.json file. 
5:00pm : OOps !Get the error by running the migration command.the error it's showing is "Change your migrations assembly by using DbContextOptionsBuilder.
         E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("AnchalsBookStore")). By default, the migrations assembly is the assembly 
         containing the DbContext.". 
5:05pm : By changing the default project to AnchalsBooks.DataAccess,the erroe get solved.
5:09pm : New migration file name -"20221114220717_AddDefaultIdentityMigration.cs"
5:20pm : Due to removing semicolon from appsetting.json the name of file in sql is not appearing right so again deleted the migration folder and run the 
         migration command again & updated it.
5:46pm : New class Category.cs is added to Models and also modify and add data in it.
5:48pm : Migration via PM console is added.
5:50pm : Updated using and added a new line in ApplicationDbContext.cs.
5:58pm : updated Database  and confirm that the new categories table is shown in sql.
6:28pm : Created new folder Repository and also add a interface IRepository.cs
6:34pm : Added Crud operations in IRepository.cs.
6:55pm : Created a new repository class in repository folder and modified the data with the data given in same file in blackboard.

15 Novembwe 2022
12:29am : At 7 pm i left from college and had gone to freshco for getting the necessary grocery for myself and now after prepearing 
          my dinner and having it, i am back to work.
12:30am : Added CategoryRepository.cs class and ICategoryRepository.cs interface in Repository
12:41am : CategoryRepository.cs is modified.
1:01am : Update method in Categorypository.cs is modified.
1:30am : Created new interface ISP_Call.cs which extends IDisposible.
1:33am : Installed Dapper.
2:08am : Added new class SP_Call.cs in Repository folder and also implemented class methods and properties.
Taking break.....:)
Just gone for a small break but back after almost 1 and half hr nap :(
3:37am : Created a new interface IUnitOfWork.cs and update the code.
3:39am : Created a new class UnitOfWork.cs and modified it's data.
4:02am : Registered both files of UnitOfWork in Startup.cs.