using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class DbCommand
    {
        public static void testDbCommand()
        {
            var command = new DbCommand(new SqlConnection(),"SELECT * FROM myTable;");
            command.Execute();
        }



        private DbConnection _dbConnection;

        public DbConnection DbConnection
        {
            get { return _dbConnection; }
        }

        private string _sql;

        public string SQL
        {
            get { return _sql; }
        }

        public DbCommand(DbConnection dbConnection, string sql)
        {
            if (dbConnection == null || string.IsNullOrWhiteSpace(sql))
                throw new Exception();
            _dbConnection = dbConnection;
        }

        public void Execute()
        {
            _dbConnection.Open();
            RunInstruction();
            _dbConnection.Close();
        }

        private void RunInstruction()
        {
            Console.WriteLine("Ran the Db Instruction");
        }


    }
}
