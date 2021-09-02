using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using System;

namespace PowerPlant.Application.Service
{
    public class WebIdDataService : IWebIdDataService
    {
        private readonly IWebIdDataRepository _webIdDataRepository;

        public WebIdDataService(IWebIdDataRepository webIdDataRepository)
        {
            _webIdDataRepository = webIdDataRepository;
        }

        public void SaveChanges(WebIdDataDto model)
        {

            var entity = new WebIdDataEntity()
            {
                WebId = model.WebId,
                Value = model.Value
            };

            if (model.Id.HasValue)
            {
                entity.Id = model.Id.Value;
            }

            _webIdDataRepository.SaveChanges(entity);
        }

    }
}
