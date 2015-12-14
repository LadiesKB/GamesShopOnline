using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public class Game : BaseModel
    {
        public string Name { get; set; }
        public Producer Producer { get; set; }
        public Platform Platform { get; set; }
        public Genre Genre { get; set;}
        public Price Price { get; set; }
        public AttachedFile Pictute { get; set; }
        public AttachedFile URLVideo { get;  set;}
        public List<Comment> Comments { get; set; }

        public override object Clone()
        {
            return new Game
            {
                Id = this.Id,
                Name = this.Name

            };
        }
    }
}
