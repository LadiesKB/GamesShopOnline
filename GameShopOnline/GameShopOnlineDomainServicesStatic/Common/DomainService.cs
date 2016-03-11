using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShopOnline;
using GameShopOnline.Services;
using GameShopOnline.Audit;

namespace GameShopOnlineDomainServicesStatic.Comon
{
    public abstract class DomainService<T> :IDomainService<T> where T: BaseModel
    {
        private readonly IAuditManager auditManager;

        public DomainService(IAuditManager auditManager)
        {
            this.auditManager = auditManager;
        }

        public virtual T Add(T entity)
        {
            var newEntity = (T)entity.Clone();
            newEntity.Id = !GetEntities().Any() ? 1 : GetEntities().Max(item => item.Id) + 1;

            newEntity.SetNullReferences();

            GetEntities().Add(newEntity);
            return (T)newEntity.Clone();
        }

        public virtual T Get(int id)
        {
            var entity = GetEntities().SingleOrDefault(item => item.Id == id);
            if (entity == null)
            {
                return null;
            }
            var entityClone = (T) entity.Clone();
            Resolve(ref entityClone);
             
            return entityClone;
        }

        public virtual List<T> Get()
        {
            return GetEntities().Select(item =>
            {
                var clone = (T)item.Clone();
               Resolve(ref clone);
                return clone;
            }).ToList();
        }

        public virtual T Update(T entity)
        {
            var existEntity = GetEntities().SingleOrDefault(item => item.Id == entity.Id);
            if (existEntity == null)
            {
                throw new NullReferenceException();
            }
           entity.Map(existEntity);
            existEntity.SetNullReferences();

            var clone = (T)existEntity.Clone();
            Resolve(ref clone);
            return clone;
        }

        public virtual void Delete(int id)
        {
            var existEntity = GetEntities().SingleOrDefault(item => item.Id == id);
            if (existEntity == null)
            {
                throw new NullReferenceException();
            }

            GetEntities().Remove(existEntity);
        }

        protected abstract List<T> GetEntities();

        protected virtual void Resolve(ref T entity)
        {
        }
    }
}
