using AutoMapper;
using FluentAssertions;
using NUnit.Framework;
using System;
using WebReg.Automapper;
using WebReg.Data.Models;
using WebReg.Models;

namespace WebReg.Tests
{
    public class AutomapperTests
    {
        private Mapper mapper;

        [SetUp]
        public void Setup()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<PersonProfile>();
            });
            mapper = new Mapper(config);
        }

        [Test]
        public void PersonProfile_Map_Person_To_PersonViewModel()
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

            // Act
            var result = mapper.Map<PersonViewModel>(person);

            // Assert
            result.Should().NotBeNull();
            result.Id.Should().Be(person.Id);
            result.FirstName.Should().Be(person.FirstName);
            result.LastName.Should().Be(person.LastName);
            result.BirthDate.Should().Be(person.BirthDate.Value.ToString("d"));
            result.Email.Should().Be(person.Email);
        }
    }
}