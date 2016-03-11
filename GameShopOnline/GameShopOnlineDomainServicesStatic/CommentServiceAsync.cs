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
    public class CommentServiceAsync : DomainServiceAsync<Comment>, IDCommentServiceAsync
    {
        private readonly List<Comment> entities = new List<Comment>();

        public CommentServiceAsync(IAuditManager auditManager) : base(auditManager)
        {

        }

        protected override List<Comment> GetEntities()
        {
            return entities;
        }
    }
}
