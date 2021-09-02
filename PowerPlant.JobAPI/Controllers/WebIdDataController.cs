using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PowerPlant.Application.Dto;
using PowerPlant.Application.Service;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using PowerPlant.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.JobAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebIdDataController : ControllerBase
    {
        private readonly IWebIdDataService _webIdDataService;
        private readonly IWebDefinitionService _webDefinitionService;

        public WebIdDataController(IWebIdDataService webIdDataService, IWebDefinitionService webDefinitionService)
        {
            _webIdDataService = webIdDataService;
            _webDefinitionService = webDefinitionService;
        }

        [HttpGet("get-all-by-parameters/{webId}")]
        public IEnumerable<WebDefinitionEntity> GetAllByParemeters(string webId, [FromQuery] DateTime startTime, [FromQuery] DateTime endTime)
        {
            return _webDefinitionService.GetAllByParameters(webId, startTime, endTime);
        }

        [HttpPost("save")]
        public void SaveChanges(WebIdDataDto dto)
        {
            _webIdDataService.SaveChanges(dto);
        }


    }
}
