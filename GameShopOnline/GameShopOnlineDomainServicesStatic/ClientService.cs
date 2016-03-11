using GameShopOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShopOnline;
using GameShopOnlineDomainServicesStatic.Comon;
using GameShopOnline.Audit;

namespace GameShopOnlineDomainServicesStatic
{
    class ClientService : DomainService<Client>, IDClientService
    {
        private readonly List<Client> entities = new List<Client>();

        public ClientService(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Client> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
