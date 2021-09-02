using NHibernate;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using System;

namespace PowerPlant.RelationalRepository.Repository
{
    public class WebIdDataRepository : IWebIdDataRepository
    {
        private readonly ISession _session;
        public WebIdDataRepository(ISession session)
        {
            _session = session;
        }

        public Guid SaveChanges(WebIdDataEntity entity)
        {
            var transaction = _session.BeginTransaction();
            try
            {
                _session.Save(entity);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            return entity.Id;
        }
    }
}
