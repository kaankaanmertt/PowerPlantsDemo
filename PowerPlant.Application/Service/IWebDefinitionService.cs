using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerPlant.Core.Service
{
    public interface IWebDefinitionService
    {
        IEnumerable<WebDefinitionEntity> GetAll();
        IEnumerable<WebDefinitionEntity> GetAllByParameters(string webId, DateTime startTime, DateTime endTime);
        WebDefinitionEntity GetById(Guid id);
        void SaveChanges(WebDefinitionDto model);
        void Delete(Guid id);
    }
}
