using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODMS.Util
{
    interface DBCom<T,key>
    {
        bool addToDB(T newT);
        bool updateDB(T existing);
        T readFromDB(key keyid);
    }
}
