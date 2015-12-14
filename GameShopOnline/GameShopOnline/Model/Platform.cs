﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{ //платформа (PS, Xbox)
    public class Platform : BaseModel
    {
        public string Name{ get; set; }

        public override object Clone()
        {
            return new Platform
            {
                Id = this.Id,
                Name = this.Name
            };
        }
    }
}
