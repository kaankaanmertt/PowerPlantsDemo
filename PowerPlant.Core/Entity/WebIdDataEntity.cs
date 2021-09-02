using System;

namespace PowerPlant.Core.Entity
{
    public class WebIdDataEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string WebId { get; set; }
        public virtual decimal Value { get; set; }
    }
}
