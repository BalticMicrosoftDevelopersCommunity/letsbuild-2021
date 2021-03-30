# Lab04

**WebReg.Data** project was added to the solution. This is a Class Library (.NET Core) project, which is used for data access logic. It contains a data model, generated from an existing database, and an Entity Framework Core *DbContext* class (`WebRegContext`).

First, make sure that EF Core tool is installed:

> dotnet tool install --global dotnet-ef

Then, add the EF Core and Tools packages to the project:

> dotnet add package Microsoft.EntityFrameworkCore.SqlServer \
> dotnet add package Microsoft.EntityFrameworkCore.Design

Generate code for a DbContext and entity types for the database:

> dotnet-ef dbcontext scaffold "Server=.\SQLEXPRESS;Database=WebRegDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models -c "WebRegContext"

Add EF Core configuration to the `Startup.cs`:

    services.AddDbContext<WebRegContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                sqlServerOptions => sqlServerOptions.CommandTimeout(60)));

Add a connection sting to the `appsettings.json` file:

    "ConnectionStrings": {
    "DefaultConnection": "Server=.\\SQLEXPRESS;Database=WebRegDb;Trusted_Connection=True;" }


## References
[Entity Framework Core tools reference - .NET Core CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

[Starting with an existing database](https://www.learnentityframeworkcore.com/walkthroughs/existing-database)