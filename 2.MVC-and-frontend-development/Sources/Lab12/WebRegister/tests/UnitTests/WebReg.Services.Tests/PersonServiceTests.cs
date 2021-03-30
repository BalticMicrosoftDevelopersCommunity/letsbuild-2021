using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;
using WebReg.Data;
using WebReg.Data.Models;

namespace WebReg.Services.Tests
{
    public class PersonServiceTests
    {
        private WebRegContext dbContext;
        private PersonService target;

        [SetUp]
        public void Setup()
        {
            var dbOptions = new DbContextOptionsBuilder<WebRegContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            dbContext = new WebRegContext(dbOptions);
            target = new PersonService(dbContext);
        }

        [Test]
        public async Task GetAllPersons_Success()
        {
            // Arrange
            var person = new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "FirstName",
                LastName = "LastName",
                BirthDate = DateTime.Now.AddYears(-30),
                Email = "test@acme.com"
            };

            await dbContext.Set<Person>().AddAsync(person);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await target.ListAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
        }
    }
}