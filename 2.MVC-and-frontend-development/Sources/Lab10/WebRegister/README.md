# Lab10

Demonstrates how to add paging to an ASP.NET MVC Core application.

Add `PageModel.cs` class to the `WebReg.Services.Models` namespace.

Updated `PersonService` class.

Updated `HomeController` - modified `Persons()` and `ListPersonsForm()` methods to display persons by pages.

Added `Pager.cshtml` partial view to the `Views\Shared` folder.

Updated `Persons.cshtml` to display the pager.

Updated `table.js` and `persons.js` - added pager logic.

Added styles for the pager to the `site.css` file.

Run the application and press the *Persons* link. Click on table headers to sort columns. See a pager in the bottom of the table.

## References
[Partial views in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/partial?view=aspnetcore-5.0)