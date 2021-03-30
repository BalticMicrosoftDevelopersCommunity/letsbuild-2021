# Lab06

Added `ConfigureServices` extension class, configuring dependency injection in ASP.NET Core application.

Updated `Srartup.cs` - added configuration for services:

    services.AddServices(Configuration);

Updated `_ViewImports.cshtml`:

    @using WebReg.Data.Models;

Added `Persons.cshtml` to the `Views\Home` directory.

Updated `HomeController.cs`: added dependencies to the constructor, and a new method `Persons()`.

Updated `_Layout.cshtml` - added *Persons* link.

Run the application and press the *Persons* link to see all persons in the database.

## References
[Dependency injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0)