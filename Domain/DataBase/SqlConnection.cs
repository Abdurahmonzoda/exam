namespace Domain.DataBase
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string conectionToString, TimeSpan timeout) : base(conectionToString, timeout)
        {
        }
        public override void Clos()
        {
            Console.WriteLine("Class  Sql in Closed");
        }

        public override void Open()
        {
            Console.WriteLine("Class  Sql in Opened");
        }

    }
}
