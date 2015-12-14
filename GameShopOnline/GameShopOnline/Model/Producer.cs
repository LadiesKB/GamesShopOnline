using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{ // компания производеитель
    public class Producer : BaseModel
    {
        public string Name { get; set; }

        public override object Clone()
        {
            return new Producer
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
