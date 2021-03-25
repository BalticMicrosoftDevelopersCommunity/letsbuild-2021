using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebReg.Automapper;
using WebReg.Controllers;
using WebReg.Data.Models;
using WebReg.Models;
using WebReg.Services;
using WebReg.Services.Models;

namespace WebReg.Tests
{
    public class HomeControllerTests
    {
        private HomeController controller;
        private Mapper mapper;
        private Mock<ILogger<HomeController>> loggerMock;
        private Mock<IPersonService> personServiceMock;

        [SetUp]
        public void Setup()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<PersonProfile>();
            });

            mapper = new Mapper(config);
            loggerMock = new Mock<ILogger<HomeController>>();
            personServiceMock = new Mock<IPersonService>();
            controller = new HomeController(loggerMock.Object, mapper, personServiceMock.Object);
        }

        [Test]
        public async Task Persons_Get_ReturnsViewWithModel()
        {
            // Arrange
            var personList = new List<Person> { new Person() };
            personServiceMock.Setup(x => x.GetPageAsync(It.IsAny<PageModel>())).Returns(Task.FromResult(personList.AsReadOnly() as IReadOnlyList<Person>));

            // Act
            var result = await controller.Persons();

            // Assert
            result.Should().NotBeNull();
            result.Should().BeAssignableTo<ViewResult>();
            var viewResult = result as ViewResult;
            viewResult.Model.Should().BeAssignableTo<PersonsListViewModel>();
            var model = viewResult.Model as PersonsListViewModel;
            model.Should().NotBeNull();
            model.Persons.Count.Should().Be(1);

            personServiceMock.Verify(x => x.GetPageAsync(It.IsAny<PageModel>()), Times.Once);
        }
    }
}
