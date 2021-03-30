# Lab07

Added **Automapper** to demonstrate how to transform data models to a View Model representation.

Added `PersonViewModel` class.

Added NuGet package `AutoMapper.Extensions.Microsoft.DependencyInjection`.

Added `PersonProfile.cs` class.

Updated `ConfigureServices` - added `AddAutoMapper()` extension method.

Update `Startup.cs` - added `AddAutoMapper()` to the `ConfigureServices`.

Updated `HomeController` - modified `Persons()` method to create a view model using the *Automapper*.

Run the application and press the *Persons* link to see how person's *BirthDate* is displayed.

Added **WebReg.Tests** project to demonstrate how to test Automapper configuration.

## Points of Interest
**FluentAssertions** is used to write assertions.

## References
[AutoMapper](https://automapper.org/)

[Fluent Assertions](https://fluentassertions.com/)