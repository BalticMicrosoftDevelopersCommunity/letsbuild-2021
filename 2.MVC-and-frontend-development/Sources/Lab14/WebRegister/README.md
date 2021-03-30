# Lab14

Demonstrates how to use ASP.NET Core Blazor components.

Updated `PersonService.cs` - added `SearchPersonsByNameAsync()` method.

Added `Search.razor` Blazor component to the `Views\Shared\Components` folder.

Added `_Imports.razor` to the web root.

Added `Search.cshtml` view to the `Views\Home` folder. The view displays the *Search* component:

    <component type="typeof(WebReg.Views.Shared.Components.Search)" render-mode="ServerPrerendered" />

Updated `HomeController` - added `Search()` action displaying the *Search* view.

Updated `_Layout.cshtml` - added a link to the *Search* action.
Added base reference:

    <base href="~/" />

Added a blazor server:

    <script src="_framework/blazor.server.js"></script>

Updated `_ViewImports.cshtml` - added:

    @using Microsoft.AspNetCore.Mvc.ModelBinding

Run the application and click on the *Search* link. Enter some first name or a part of the name, and press the *Search* button to display found records.

## References
[Introduction to ASP.NET Core Blazor](https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore-5.0)

[ASP.NET Core Blazor data binding](https://docs.microsoft.com/en-us/aspnet/core/blazor/components/data-binding?view=aspnetcore-5.0)