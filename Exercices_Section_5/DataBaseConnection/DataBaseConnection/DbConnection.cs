using System;
using System.IO;

namespace DataBaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidDataException("Invalid connection string");

            ConnectionString = connectionString;
        }

        public abstract void Connect();

        public abstract void Close();
    }
}
