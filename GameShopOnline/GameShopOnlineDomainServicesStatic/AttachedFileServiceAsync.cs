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
    public class AttachedFileServiceAsync : DomainServiceAsync<AttachedFile>, IDAttachedFileServiceAsync
    {
       
            private readonly List<AttachedFile> entities = new List<AttachedFile>();

        public AttachedFileServiceAsync(IAuditManager auditManager) : base (auditManager)
        {

        }

        protected override List<AttachedFile> GetEntities()
            {
                return entities;
            }
        
    }
}
