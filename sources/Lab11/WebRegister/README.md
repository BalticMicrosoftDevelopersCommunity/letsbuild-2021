# Lab11

Demonstrates how to post data from an ASP.NET MVC form and validate data model.

Added `AddPersonViewModel.cs` class.

Updated `HomeController` - added `AddPerson()` and `AddPersonForm()` methods to display a form for a new person.

Added `AddPerson.cshtml` view to the `Views\Home` folder.

Updated `_Layout.cshtml` - added a link to the *"Add Person"* action.

Run the application and click on the *Add Person* link. Enter invalid data to check model validation.

## References
[Model validation in ASP.NET Core MVC and Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-5.0)