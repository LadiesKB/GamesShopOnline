using GameShopOnline;
using GameShopOnline.Audit;
using GameShopOnline.Services;
using GameShopOnlineDomainServicesStatic.Comon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnlineDomainServicesStatic
{
    public class GenreService : DomainService<Genre>, IDGenreService
    {
        private readonly List<Genre> entities = new List<Genre>();

        public GenreService(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Genre> GetEntities()
        {
            return entities;
        }
    }
}
