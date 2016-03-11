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
    public class ProducerServiceAsync : DomainServiceAsync<Producer>, IDProducerServiceAsync
    {
        private readonly List<Producer> entities = new List<Producer>();

        public ProducerServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Producer> GetEntities()
        {
            return entities;
        }
    }
}
