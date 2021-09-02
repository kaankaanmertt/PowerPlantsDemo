using FluentNHibernate.Mapping;
using PowerPlant.Core.Entity;

namespace PowerPlant.RelationalRepository.Mapping
{
    public class WebIdDataMapping : ClassMap<WebIdDataEntity>
    {
        public WebIdDataMapping()
        {
            Table("WebIdData");
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.WebId).Not.Nullable();
            Map(x => x.Value).Not.Nullable();
        }
    }
}
