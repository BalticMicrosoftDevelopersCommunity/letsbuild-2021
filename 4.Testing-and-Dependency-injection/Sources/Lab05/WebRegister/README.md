# Lab05

Added **WebReg.Services** and **WebReg.Services.Tests** projects.

The *WebReg.Services* contains a `PersonService` class, retrieving all the *Person* records from the database (`ListAllAsync`).

The `PersonServiceTests` unit test demonstrates how to test code using EF Core.

## Points of Interest
We never mock *DbContext* or *IQueryable*. Instead we use the EF in-memory database when unit testing.

## References
[Testing code that uses EF Core](https://docs.microsoft.com/en-us/ef/core/testing/)