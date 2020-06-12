using System;

namespace DataBaseConnection
{

    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new SqlConnection("string connection"), "this is an instruction");
            command.Execute();
        }
    }
}
