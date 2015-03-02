using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Security
{
    public enum Permission : byte
    {
        Nopermission=0,
        Admin=1,
        reception=2,
        kitchen=3,
        delivery=4
    }
}
