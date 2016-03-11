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
    public class PriceServiceAsync : DomainServiceAsync<Price>, IDPriceServiceAsync
    {
        private readonly List<Price> entities = new List<Price>();

        public PriceServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Price> GetEntities()
        {
            return entities;
        }
    }
}
