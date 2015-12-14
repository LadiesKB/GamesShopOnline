using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class AttachedFile : BaseModel
    {
        public string Link { get; set; }

        public override object Clone()
        {
            return new AttachedFile
            {
                Id = this.Id,
                Link = this.Link

            };
        }
    }
}
