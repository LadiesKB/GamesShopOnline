using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class Price : BaseModel
    {
        public double Value { get; set; }

        public override object Clone()
        {
            return new Price
            {
                Id = this.Id,
               Value = this.Value
            };
        }
    }
}
