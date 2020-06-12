using System.Data;
using System.IO;

namespace DataBaseConnection
{
    public class DbCommand
    {

        private readonly DbConnection _dbConnection;
        private readonly string _instruction;

        public DbCommand(DbConnection _dbConnection, string instruction)
        {
            if (_dbConnection == null || string.IsNullOrWhiteSpace(instruction))
                throw new InvalidDataException("There is an problem with the parameters");
            

            this._dbConnection = _dbConnection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.Connect();
            System.Console.WriteLine(_instruction);
            _dbConnection.Close();
        }


    }
}
