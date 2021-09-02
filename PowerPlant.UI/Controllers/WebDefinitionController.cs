using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using PowerPlant.UI.Infrastructure;
using PowerPlant.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PowerPlant.UI.Controllers
{
    public class WebDefinitionController : Controller
    {
        private readonly ILogger<WebDefinitionController> _logger;
        private readonly ApiUrls _apiUrls;
        

        public WebDefinitionController(ILogger<WebDefinitionController> logger, IOptions<ApiUrls> apiUrls)
        {
            _logger = logger;
            _apiUrls = apiUrls.Value;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var url = $"{_apiUrls.WebDefinitionGetAll}";

            var result = await url.GetJsonAsync<List<WebDefinitionEntity>>();

            var model = new WebDefinitionListModel()
            {
                Entities = result
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CreateWebDefinitionDataModel dataModel)
        {
            var url = $"{_apiUrls.WebDefinitionSaveOrUpdate}";
            var dto = new WebDefinitionDto();

            dto.WebId = dataModel.WebId;
            dto.Timestamp = DateTime.Now;

            Random rand = new Random();
            dto.Good = rand.Next(0, 2) > 0;

            if(dto.Good == true)
            {
                dto.Value = rand.NextDouble().ToString();
            }
            else
            {
                dto.Value = JsonConvert.SerializeObject(new { errorMessage = "Somethings went wrong!!!" });
            }

            var result = await url.PostJsonAsync(dto).ReceiveJson<WebDefinitionDto>();

            return RedirectToAction("Index");

        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var url = $"{_apiUrls.WebDefinitionDelete}/{id}";
            var result = await url.DeleteAsync();

            return  Json("Deleted Successfully");
        }


        [HttpPost("edit/{id}")]
        public async Task<ActionResult> Edit(Guid id)
        {
            Random rand = new Random();

            var url = $"{_apiUrls.WebDefinitionSaveOrUpdate}";

            var entityUrl = $"{_apiUrls.WebDefinitionGetById}/{id}";
            var entityResult = await entityUrl.GetJsonAsync<WebDefinitionEntity>();

            entityResult.Good = rand.Next(0, 2) > 0;
            if (entityResult.Good == true)
            {
                entityResult.Value = rand.NextDouble().ToString();
            }
            else
            {
                entityResult.Value = JsonConvert.SerializeObject(new { errorMessage = "Somethings went wrong!!!" });
            }

            var dto = new WebDefinitionDto()
            {
                Id = entityResult.Id,
                WebId = entityResult.WebId,
                Timestamp = DateTime.Now,
                Good = entityResult.Good.Value,
                Value = entityResult.Value
            };
            var result = await url.PostJsonAsync(dto).ReceiveJson<WebDefinitionDto>();

            return RedirectToAction("Index");
        }












        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
