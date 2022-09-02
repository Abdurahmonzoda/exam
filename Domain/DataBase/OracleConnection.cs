namespace Domain.DataBase
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string conectionToString, TimeSpan timeout) : base(conectionToString, timeout)
        {

        }     
        public override void Clos()
        {
            Console.WriteLine("Class Oracle in Closed "  );
        }

        public override void Open()
        {
            Console.WriteLine("Class Oracle is Opened");
        }
    }
}
