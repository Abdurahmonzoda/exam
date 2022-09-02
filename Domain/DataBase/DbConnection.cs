using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataBase
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }
        public abstract void Open();
        public abstract void Clos();
        public DbConnection(string connectionString, TimeSpan timeout)
        {
            ConnectionString = connectionString;
            Timeout = timeout;
        }
    }
}
