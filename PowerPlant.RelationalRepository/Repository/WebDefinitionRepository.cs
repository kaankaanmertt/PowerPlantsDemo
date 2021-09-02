using NHibernate;
using PowerPlant.Core.Entity;
using PowerPlant.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PowerPlant.RelationalRepository.Repository
{
    public class WebDefinitionRepository : IWebDefinitionRepository
    {
        private readonly ISession _session;

        public WebDefinitionRepository(ISession session)
        {
            _session = session;
        }

        public IEnumerable<WebDefinitionEntity> GetAll()
        {
            return _session.Query<WebDefinitionEntity>().ToList();
        }

        public IEnumerable<WebDefinitionEntity> GetAllByParameters(string webId, DateTime startTime, DateTime endTime)
        {
            return _session.Query<WebDefinitionEntity>().Where(i => i.WebId == webId && i.Timestamp >= startTime && i.Timestamp <= endTime ).ToList();
        }

        public WebDefinitionEntity GetById(Guid id)
        {
            return _session.Query<WebDefinitionEntity>().Where(x => x.Id == id).FirstOrDefault();
        }

        public Guid SaveChanges(WebDefinitionEntity entity)
        {
            var transaction = _session.BeginTransaction();
            try
            {
                _session.SaveOrUpdate(entity);
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
            }
            return entity.Id;
        }


        public void Delete(Guid id)
        {
            var entity = GetById(id);
            _session.Delete(entity);
            _session.Flush();
        }
    }
}
