using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var accountDAL = new InventoryDAL();

            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.InitialCatalog = "CSharpFinal";
            connectionStringBuilder.DataSource = @"JAY-PC\SQLEXPRESS";
            connectionStringBuilder.ConnectTimeout = 30;
            connectionStringBuilder.IntegratedSecurity = true;

            accountDAL.OpenConnection(connectionStringBuilder.ConnectionString);
            var accountList = accountDAL.GetAllAccount();

            foreach (var item in accountList)
            {
                Console.WriteLine("Username:{0}, Password:{1}", item.username,item.password);
            }

            accountDAL.CloseConnection();

            Console.Read();
        }
    }
}
