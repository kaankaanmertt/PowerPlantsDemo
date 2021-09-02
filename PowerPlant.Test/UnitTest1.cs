using Moq;
using NUnit.Framework;
using PowerPlant.Api.Controllers;
using PowerPlant.Application.Service;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using System;
using System.Collections.Generic;

namespace PowerPlant.Test
{
    public class PowerPlantServiceTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetAllByParameters_ShouldGetCorrectValues_WhenGetAllByParametersCalled()
        {
            var inputWebId = "1234";
            var inputStartTime = DateTime.Now;
            var inputEndtime = DateTime.Now.AddHours(1);

            var repository = new Mock<IWebDefinitionRepository>();
            repository.Setup(x => x.GetAllByParameters(inputWebId, inputStartTime, inputEndtime))
                .Returns(new List<WebDefinitionEntity> { 
                    new WebDefinitionEntity()
                });

            var service = new WebDefinitionService(repository.Object);

        
            var result = service.GetAllByParameters(inputWebId, inputStartTime, inputEndtime);

            Assert.IsNotEmpty(result);
        }

        [Test]
        public void SaveChanges_ShouldCallSaveChanges_WhenSaveChangesCalled()
        {
            var repository = new Mock<IWebDefinitionRepository>();
            repository.Setup(x => x.SaveChanges(It.IsAny<WebDefinitionEntity>()))
                .Verifiable();

            var service = new WebDefinitionService(repository.Object);

            service.SaveChanges(new Application.Dto.WebDefinitionDto
            {
                Value = 1
            });

            repository.Verify(x => x.SaveChanges(It.IsAny<WebDefinitionEntity>()), Times.Once);
        }

        [Test]
        public void Delete_ShouldCallDelete_WhenDeleteCalled()
        {
            var repository = new Mock<IWebDefinitionRepository>();
            repository.Setup(x => x.Delete(It.IsAny<Guid>()))
                .Verifiable();

            var service = new WebDefinitionService(repository.Object);

            service.Delete(Guid.NewGuid());

            repository.Verify(x => x.Delete(It.IsAny<Guid>()), Times.Once);
        }


    }
}