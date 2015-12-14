using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{ //жанр игры 
    public class Genre : BaseModel
    {
        public string Name { get; set; }

        public override object Clone()
        {
            return new Genre
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
