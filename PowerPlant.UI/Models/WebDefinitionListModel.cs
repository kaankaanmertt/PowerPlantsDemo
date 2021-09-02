using PowerPlant.Core.Entity;
using System.Collections.Generic;

namespace PowerPlant.UI.Models
{
    public class WebDefinitionListModel
    {
        public IEnumerable<WebDefinitionEntity> Entities { get; set; } = new List<WebDefinitionEntity>();
    }
}
