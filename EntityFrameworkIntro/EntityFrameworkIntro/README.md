# EntityFrameWorkTutorial

## History of .NET
- .NET Framework == Only for Windows, closed source
- .NET Core == Cross platform (windows, Mac, Linux, Mobile), open source 
	- .NET 5 and .NET 6 (what we are using) is the most recent version of what was known as .NET Core 

## Dynamic-link Library 
 - Library of code that contains functions that we are going to call

## Object Code
 Relocatable code (take it and load it on another computer)


## Nuget Packages
- Packages of code for us others to use based the needs of their project and they are available in Tools->Nuget Package Manager
- Packages that we will need for this project
	- Microsoft.EntityFrameworkCore
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools
	- Microsoft.EntityFrameworkCore.Proxies  

## Set up our models
- Set up the data in a models folder 

## Set up our DbContext (in this case MusicContext)
- Override OnConfiguring method with connection string
- Put in our seed data in an overridden OnModelCreating method

## Migrating our data
- after we have added our seed data, we can then send it over to the database
1. We need to add a migration
	- Access the Package Manager Console from Tools->NuGet Package Manager->Package Manager Console
	- 
2. update our database
