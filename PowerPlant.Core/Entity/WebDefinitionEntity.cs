using System;

namespace PowerPlant.Core.Entity
{
    public class WebDefinitionEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string WebId { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual bool? Good { get; set; }
        public virtual string Value { get; set; }
    }

}
