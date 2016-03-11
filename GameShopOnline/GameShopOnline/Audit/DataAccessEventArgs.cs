using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShopOnline.Audit
{
    public class DataAccessEventArgs : EventArgs
    {
        public Type DataType { get; set; }

        public AccessType AccessType { get; set; }
    }
}
