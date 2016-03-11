using GameShopOnline;
using GameShopOnline.Audit;
using GameShopOnline.Domain.Services;
using GameShopOnlineDomainServicesStatic.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnlineDomainServicesStatic
{
    public class GenreServiceAsync : DomainServiceAsync<Genre>, IDGenreServiceAsync
    {
        private readonly List<Genre> entities = new List<Genre>();

        public GenreServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Genre> GetEntities()
        {
            return entities;
        }
    }
}
