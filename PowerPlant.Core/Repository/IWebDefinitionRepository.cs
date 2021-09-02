using PowerPlant.Core.Entity;
using System;
using System.Collections.Generic;

namespace PowerPlant.Core.Repository
{
    public interface IWebDefinitionRepository
    {
        IEnumerable<WebDefinitionEntity> GetAll();
        IEnumerable<WebDefinitionEntity> GetAllByParameters(string webId, DateTime startTime, DateTime endTime);
        WebDefinitionEntity GetById(Guid id);
        Guid SaveChanges(WebDefinitionEntity entity);
        void Delete(Guid id);
    }
}
