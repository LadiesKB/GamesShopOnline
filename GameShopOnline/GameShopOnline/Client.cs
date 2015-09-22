using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    class Client: BaseModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Mail { get; set; }
    }
}
