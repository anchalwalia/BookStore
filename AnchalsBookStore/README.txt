Name : Anchal Walia
Date : 2022/11/8
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

 2022/11/14
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

2022/11/15
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
4:04am : Added a new Mvc controller named CategoryController.cs in Admin 
        folder in Area.
4:22am : Modified the data in CategoryController.cs.
4:39am : Added a new folder 'index' view to view in area and modify it's code with the code given in blackboard and test it. Happy to see it working:).
4:46am :  Moved the Category link to content Management drop down.
8:17am : Back after a second nap.
8:18pm : Downloaded script.js from blackboard and added it to js file.

2022/11/21
11:29pm: Added section call to category.cs.
11:42pm : Added IAction result.
11:53pm : Added the view and copied html from Category UpsertView.html given in blackboard.
12:09am : Created partial view for edit and back.
12:25am : Modified the Upsert.cshtml.
12:28am : Added the asp-action to the Index.cshtml.

2022/11/23
10:55pm : Created an Upsert action method in CategoryController.cs.
11:19pm : Added the API call for HTTPDelete in CategoryController.cs.

{Part 3}
12:30am : Started the part 3.Firstly, created CoveType.cs in model's folder.
1:14am : Gave id and name to covertype.cs 
1:20am : Added a interface and named IcoverTypeRepository and changed its class.
1:26am : A new covertype class added.
1:32am : Modified IUnitOfWork and UnitOfWork and add covertype in it.
1:36am : Created a new migration for CoverType and updated to database.
1:40am : Added New Controler and changed and added action which are required.
1:45am : Added covertype index view for database.
1:50am : Delete and update method  is done using the API call.
1:56am : Added covertype link to navgation bar.
2:01am : In models project, added a class (Product), Added code from slide and set class to public.
2:10am : Added product reference to database in ApplicationDbcontext.cs file.
2:19am : by using add-migration command a new migration file '20221124075347_AddProductToDb.cs'  added.
2:26am : In repository folder, Added a new class for Product and a interface for product. 
2:34am : In IUnitOfWork and UnitOfWork file added Product.
2:34am : I checked the application and it worked.
2:39am : Added a new controller for product.
2:46am : Created a new viewmodel for product in model project.
2:52am : Added and modified ProductVM class and Install-Package Microsoft.AspNetCore.Mvc.ViewFeatures.
2:56am : Modified product contrller for IActionResult upsert calls.
3:01am : Including covertype and category in API call.
3:06am : In productcontroll file, Added a new index view. Add code from view/ category and modfied product list header and its properties.
3:07am : Added a reference of product.js file in index file.
3:10am : Copied and paste data from category.js file into product.js file and changed its url for product.
3:19am : Added link product link in navgation bar.
3:20am : Tested the app and its running without error, according the slides.

2022/11/30
10::46pm : Added upsert post method.
10:47pm : Moving forward,for upsert product created view file.

{Part 4}
10:48pm : In category name,changed the name written in uppercase to lowercase.
10:49pm : In upsert.cshtml changed the category list  to covertype list.
10:51pm : Take Listprice instead of price.
10:56pm : Added more prices like price50,price100 for product.
10:58pm : New migration file 20221201035734_AddPrice50ToProduct added for prices of product.
10:59pm : Delete api metrhod is updated.
11:01pm : Added new input areas for new prices. 
11:04pm : In order to show product list in home, it is added to index view.
11:05pm : All books are shown from product list.
11:09pm : Added image to the update field.
11:10pm : New folder for images is added.
11:12pm : Taking a small break for having my dinner.
11:41pm : Back. Build the project and run it.
