using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Database : IDatabase
    {
        public Database(ILogger Logger)
        {
            this.Logger = Logger;
        }

        public void Execute(string query)
        {
            Logger.Log(query);
        }

        public ILogger Logger { get; set; }
    }
}
