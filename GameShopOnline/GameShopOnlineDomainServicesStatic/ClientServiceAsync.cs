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
    public class ClientServiceAsync : DomainServiceAsync<Client>, IDClientServiceAsync
    {
        private readonly List<Client> entities = new List<Client>();

        public ClientServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Client> GetEntities()
        {
            return entities;
        }
    }
}
