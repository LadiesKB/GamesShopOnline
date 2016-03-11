using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameShopOnline;
using GameShopOnline.Services;
using GameShopOnlineDomainServicesStatic.Comon;
using GameShopOnline.Audit;

namespace GameShopOnlineDomainServicesStatic
{
    public class AttachedFileService : DomainService<AttachedFile>, IDAttachedFileService
    {
        private readonly List<AttachedFile> entities = new List<AttachedFile>();

        public AttachedFileService(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<AttachedFile> GetEntities()
        {
            return entities;
        }
    }
}
