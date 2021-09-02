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
        private readonly IWebIdDataService _powerPlantResPonseService;
        private readonly IWebDefinitionService _webDefinitionService;

        public WebIdDataController(IWebIdDataService powerPlantResponseService, IWebDefinitionService webDefinitionService)
        {
            _powerPlantResPonseService = powerPlantResponseService;
            _webDefinitionService = webDefinitionService;

            string defaultWebId = "neY8nWyrKrBQt7qcdQXXzsncKKe8HynuNejR2m7pSUyNEemUbB";
            DateTime startTime = DateTime.Now.AddHours(-1);
            DateTime endTime = DateTime.Now;

            RecurringJob.AddOrUpdate(() => GetAllByhParemeters(defaultWebId,startTime, endTime), Cron.Hourly);
        }

        [HttpGet("get-all-by-parameters/{webId}")]
        public IEnumerable<WebDefinitionEntity> GetAllByhParemeters(string webId, [FromQuery] DateTime startTime, [FromQuery] DateTime endTime)
        {
            return _webDefinitionService.GetAllByParameters(webId, startTime, endTime);
        }

        [HttpPost("save")]
        public void SaveChanges(WebIdDataDto dto)
        {
            _powerPlantResPonseService.SaveChanges(dto);
        }


    }
}
