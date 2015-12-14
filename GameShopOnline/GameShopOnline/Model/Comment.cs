using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class Comment : BaseModel
    {
        public string UserComment { get; set; }

        public override object Clone()
        {
            return new Comment
            {
                Id = this.Id,
                UserComment = this.UserComment

            };
        }
    }
}
