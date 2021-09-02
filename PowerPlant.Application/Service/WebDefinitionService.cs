using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using PowerPlant.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerPlant.Application.Service
{
    public class WebDefinitionService : IWebDefinitionService
    {
        private readonly IWebDefinitionRepository _webDefinitionRepository;

        public WebDefinitionService(IWebDefinitionRepository webDefinitionRepository)
        {
            _webDefinitionRepository = webDefinitionRepository;
        }

        public IEnumerable<WebDefinitionEntity> GetAll()
        {
            return _webDefinitionRepository.GetAll();
        }

        public IEnumerable<WebDefinitionEntity> GetAllByParameters(string webId, DateTime startTime, DateTime endTime)
        {
            return _webDefinitionRepository.GetAllByParameters(webId, startTime, endTime);
        }


        public WebDefinitionEntity GetById(Guid id)
        {
            return _webDefinitionRepository.GetById(id);
        }

        public void SaveChanges(WebDefinitionDto model)
        {

            var entity = new WebDefinitionEntity()
            {
                WebId = model.WebId,
                Timestamp = model.Timestamp,
                Good = model.Good,
                Value = model.Value.ToString()
            };

            if(model.Id.HasValue)
            {
                entity.Id = model.Id.Value;
            }

            _webDefinitionRepository.SaveChanges(entity);
        }

        public void Delete(Guid id)
        {
            _webDefinitionRepository.Delete(id);
        }

    }
}
