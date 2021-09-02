using Flurl.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using PowerPlant.Application.Dto;
using PowerPlant.Core.Entity;
using PowerPlant.UI.Infrastructure;
using PowerPlant.UI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerPlant.UI.Controllers
{
    public class WebIdDataController : Controller
    {
        private readonly ApiUrls _apiUrls;

        public WebIdDataController(IOptions<ApiUrls> apiUrls)
        {
            _apiUrls = apiUrls.Value;
        }


        public IActionResult Index()
        {
            var model = new WebIdDataListModel();

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> GetData(GetWebDefinitionDataModel dataModel)
        {
            var url = $"{_apiUrls.WebDefinitionGetAllByParameters}/{dataModel.WebId}?startTime={dataModel.StartTime:yyyy-MM-dd HH:mm:ss.fffffff}&endTime={dataModel.EndTime:yyyy-MM-dd HH:mm:ss.fffffff}";

            var result = await url.GetJsonAsync<List<WebDefinitionEntity>>();

            var model = new WebIdDataListModel()
            {
                Entities = result
            };

            return View("Index", model);
        }

        [HttpPost("save")]
        public async Task<IActionResult> Save(Guid id)
        {
            var getEntity = $"{_apiUrls.WebDefinitionGetById}/{id}";
            var entityResult = await getEntity.GetJsonAsync<WebDefinitionEntity>();

            var url = $"{_apiUrls.WebIdDataSave}";
            var dto = new WebIdDataDto();

            dto.WebId = entityResult.WebId;
            dto.Value = Convert.ToDecimal(entityResult.Value.Trim());

            var result = await url.PostJsonAsync(dto).ReceiveJson<WebIdDataDto>();
            return RedirectToAction("Index");

        }



    }
}
