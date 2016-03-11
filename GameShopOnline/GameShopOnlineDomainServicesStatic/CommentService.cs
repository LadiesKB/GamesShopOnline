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
    class CommentService : DomainService<Comment>, IDCommentService
    {
        private readonly List<Comment> entities = new List<Comment>();

        public CommentService(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Comment> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
