﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline
{
    public abstract class BaseModel :ICloneable

    {
        public int Id { get; set; }

        public abstract object Clone();
        
    }
}
