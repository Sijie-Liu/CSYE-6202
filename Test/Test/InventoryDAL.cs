using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class InventoryDAL
    {
        private SqlConnection connection = null;

        public void OpenConnection(string connectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void InsertAccount(Account a)
        {
            string sql = string.Format("Insert into Account(username,password) values ('{0}','{1}')",a.username,a.password);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public List<Account> GetAllAccount()
        {
            var accountList = new List<Account>();

            string sql = "Select * from Account where username = 'jay' and password = '1234'";
            using (SqlCommand command = new SqlCommand(sql,connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    accountList.Add(new Account((string)dr["username"],(string)dr["password"]));
                }

                dr.Close();
            }

            return accountList;
        }
    }
}
