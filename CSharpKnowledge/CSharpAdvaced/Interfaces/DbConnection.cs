using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public abstract class DbConnection
    {
        private string _connectionString;
        TimeSpan timeSpan = TimeSpan.FromSeconds(0);

        public string ConnectionString
        {
            get { return _connectionString; }
            set
            {
                if (value == null || string.IsNullOrWhiteSpace(value))
                    throw new Exception();
                _connectionString = value;
            }
        }


        public abstract void Open();
        public abstract void Close();


    }

    public class SqlConnection: DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opened a SqlConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Closed a SqlConnection");
        }
    }

    public class OracleConnection: DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Opened an OracleConnection");
        }

        public override void Close()
        {
            Console.WriteLine("Closed an OracleConnection");
        }
    }



}
