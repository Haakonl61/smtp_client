using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace smtp_client
{
    class SQLStuff
    {
        public SQLDataClassesDataContext ctx;
        
        public SQLStuff()
        {
            ctx = new SQLDataClassesDataContext();

        }
    }
}
