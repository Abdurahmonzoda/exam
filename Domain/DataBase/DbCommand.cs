using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataBase
{
    public class DbCommand
    {
      DbConnection connection;
       string command;
        public DbCommand(DbConnection connection, string command)
        {
            this.connection = connection;
            this.command = command;
        }
        public void Execut()
        {
            connection.Open();
            Console.WriteLine("Execute command:" +command);
            connection.Clos(); 
                
        }
    }
}
