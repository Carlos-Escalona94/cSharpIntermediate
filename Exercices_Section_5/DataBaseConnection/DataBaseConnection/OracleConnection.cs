using System.IO;

namespace DataBaseConnection
{   
    public class OracleConnection : DbConnection
    {

        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Close()
        {
            System.Console.WriteLine("Closed connection to Oracle");
        }

        public override void Connect()
        {
            System.Console.WriteLine("Connected to Oracle");
        }
    }
}
