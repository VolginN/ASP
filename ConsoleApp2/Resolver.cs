using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Resolver
    {
        public void Resolve(string query, ILogger logger)
        {
            new Database(logger).Execute(query);
        }
    }
}
