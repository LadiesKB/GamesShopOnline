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
    public class PlatformServiceAsync : DomainServiceAsync<Platform>, IDPlatformServiceAsync
    {
        private readonly List<Platform> entities = new List<Platform>();

        public PlatformServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Platform> GetEntities()
        {
            return entities;
        }
    }
}
