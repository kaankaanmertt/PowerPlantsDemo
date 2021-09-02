using PowerPlant.Core.Entity;
using System;

namespace PowerPlant.Core.Repository
{
    public interface IWebIdDataRepository
    {
        Guid SaveChanges(WebIdDataEntity entity);
    }
}
