2022-10-29
1137 creating an application MVC (MvcMovies), following the tutorial provided in class.
-Using Web Application (Model-View-Controller)
-ASP.NET Core 3.1 LTS
-Included Individual User Account authentication e configured HTTPS.
-Enabled Razor Runtime compilation (optional)
-Location C:\Users\source\repos
1139 run and test the basic application - Ctrl+F5 
1142 Works good!

2022-10-30 

0816 Created a GIT repository

2022-10-31

0839 This will be an web app for a candy store especialized in Brazilian 
     candies called Tropicandies.
0840 - Added a controller based in the MVC tutorial --> StoreController.cs
0900 - Controller tested and working - Push to git

0902 - Add a View

0910 Changing Views/Shared/_Layout.cshtml to customize our web app and change the 
     informations in the title, navbar and footer.
0934 View tested and working - Pushed to git

0935 Add a Model to our web app

0948 Added a model class Candies.cs in the Models folder.

0951 Its the 4th time I am trying to do this app and every time it stop working when a reach this part.

When I try to ADD the NuGet packages it gives me this codes and I can't go ahead.

Error: Install-Package : NU1202: O pacote Microsoft.EntityFrameworkCore.SqlServer 6.0.10 não é compatível com netcoreapp3.1 
(.NETCoreApp,Version=v3.1). O pacote Microsoft.EntityFrameworkCore.SqlServer 6.0.10 dá suporte a: net6.0 
(.NETCoreApp,Version=v6.0)
No linha:1 caractere:1
+ Install-Package Microsoft.EntityFrameworkCore.SqlServer
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackage 
   Command
 
Install-Package : A restauração do pacote falhou. Revertendo as alterações no pacote para 'Assignment1'.
No linha:1 caractere:1
+ Install-Package Microsoft.EntityFrameworkCore.SqlServer
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : NotSpecified: (:) [Install-Package], Exception
    + FullyQualifiedErrorId : NuGetCmdletUnhandledException,NuGet.PackageManagement.PowerShellCmdlets.InstallPackage 
   Command


   1010 - Moving to next step without install the NuGet Packages

   1011 Creating a database class to our store

   1120 I tryed many solution found in the internet to install the NeGet packages, but I can't solve this.



 