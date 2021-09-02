using FluentNHibernate.Mapping;
using PowerPlant.Core.Entity;

namespace PowerPlant.RelationalRepository.Mapping
{
    public class WebDefinitionMapping : ClassMap<WebDefinitionEntity>
    {
        public WebDefinitionMapping()
        {
            Table("WebDefinition");
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.WebId).Not.Nullable();
            Map(x => x.Timestamp).Not.Nullable();
            Map(x => x.Good).Not.Nullable();
            Map(x => x.Value).Not.Nullable();
        }
    }
}
