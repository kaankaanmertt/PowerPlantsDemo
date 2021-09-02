using PowerPlant.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerPlant.WebIdDataAPI.HangFireService
{
    public class JobService
    {
        private readonly IWebDefinitionService _webDefinitionService;

        public JobService(IWebDefinitionService webDefinitionService)
        {
            _webDefinitionService = webDefinitionService;
        }

        public void FetchDataFromWebDefinition()
        {
            string defaultWebId = "neY8nWyrKrBQt7qcdQXXzsncKKe8HynuNejR2m7pSUyNEemUbB";
            DateTime startTime = DateTime.Now.AddHours(-1);
            DateTime endTime = DateTime.Now;

            _webDefinitionService.GetAllByParameters(defaultWebId, startTime, endTime);
        }

    }
}
