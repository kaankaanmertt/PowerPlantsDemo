using Microsoft.AspNetCore.Mvc;
using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Service;
using System;
using System.Collections.Generic;

namespace PowerPlant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebDefinitionController : ControllerBase
    {
        private readonly IWebDefinitionService _webDefinitionService;

        public WebDefinitionController(IWebDefinitionService webDefinitionService)
        {
            _webDefinitionService = webDefinitionService;
        }

        [HttpGet("get-all")]
        public IEnumerable<WebDefinitionEntity> GetAll()
        {
          return _webDefinitionService.GetAll();
        }


        [HttpGet("get-all-by-parameters/{webId}")]
        public IEnumerable<WebDefinitionEntity> GetAllByParemeters(string webId, [FromQuery] DateTime startTime, [FromQuery] DateTime endTime)
        {
            return _webDefinitionService.GetAllByParameters(webId, startTime, endTime);
        }


        [HttpGet("get-by-id/{id}")]
        public WebDefinitionEntity GetById(Guid id)
        {
            return _webDefinitionService.GetById(id);
        }


        [HttpPost("save-or-update")]
        public void SaveChanges(WebDefinitionDto model)
        {
            _webDefinitionService.SaveChanges(model);
        }


        [HttpDelete("delete/{id}")]
        public void Delete(Guid id)
        {
            _webDefinitionService.Delete(id);
        }

    }
}
