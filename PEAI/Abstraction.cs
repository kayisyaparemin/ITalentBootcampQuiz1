using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAI
{
    public class Abstraction
    {
        public abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Default add method");
            }
            public abstract void Delete();
        }
        public class SQLServer : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Delete by SQL Server");
            }
        }
        public class MongoDB : Database
        {
            public override void Delete()
            {
                Console.WriteLine("Delete By MongoDB");
            }
        }

        public void UsingDb()
        {
            Database database = new SQLServer();

            database.Add();
            database.Delete();

            //mongo dbye geçmek istersem
            database = new MongoDB();
            database.Add();
            database.Delete();
        }
    }
}
