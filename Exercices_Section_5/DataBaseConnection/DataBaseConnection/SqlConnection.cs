namespace DataBaseConnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Close()
        {
            System.Console.WriteLine("Closed connection to SqlServer");
        }

        public override void Connect()
        {
            System.Console.WriteLine("Connected to SqlServer");
        }
    }
}
