using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class Client: BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Mail { get; set; }
        public List<Game> Games { get; set; }

        public override object Clone()
        {
            return new Client
            {
                Id = this.Id,
                Name = this.Name,
                SurName = this.SurName,
                Mail =this.Mail

            };
        }
    }
}
