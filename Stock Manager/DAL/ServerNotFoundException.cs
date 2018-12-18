using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ServerNotFoundException : Exception
    {
        public ServerNotFoundException() : base("Sql server not found")
        {

        }
    }
}
