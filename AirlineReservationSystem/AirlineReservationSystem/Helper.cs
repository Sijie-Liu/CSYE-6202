using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservationSystem
{
    public class Helper
    {
        private SqlConnection connection = null;
        private SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

        public Helper()
        {
            ConnectionConfigure();
        }
        public void ConnectionConfigure()
        {
            connectionStringBuilder.InitialCatalog = "CSharpFinal";
            connectionStringBuilder.DataSource = @"JAY-PC\SQLEXPRESS";
            connectionStringBuilder.ConnectTimeout = 30;
            connectionStringBuilder.IntegratedSecurity = true;
        }
        public void OpenConnection()
        {
            string connectionString = connectionStringBuilder.ConnectionString;
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        public void CLoseConnection()
        {
            connection.Close();
        }

        public List<Account> GetAllAccounts()
        {
            OpenConnection();
            var accountList = new List<Account>();

            string sql = "select * from Account";
            using (SqlCommand command =new SqlCommand(sql,connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    accountList.Add(new Account((string)dr["username"],(string)dr["password"],(string)dr["type"]));
                }
                dr.Close();
            }

            CLoseConnection();
            return accountList;
        }

        public Account checkLogin(string u, string p)
        {
            Account result = null;
            OpenConnection();
            string sql = "select * from Account where username = '"+u+"' and password = '"+p+"'";
            
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                
                while (dr.Read())
                {
                    result = new Account((string)dr["username"],(string)dr["password"], (string)dr["type"]);
                    break;
                }

                   
            }
            CLoseConnection();
            return result;
        }

        public List<Trip> GetTripList(Account a)
        {
            List<Trip> result = new List<Trip>();
            OpenConnection();
            string sql = "select * from UserTrip where username = '" + a.username + "'";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    result.Add(new Trip((string)dr["Seat ID"],(string)dr["flight_number"],(string)dr["customer_name"]));
                    
                }


            }
            CLoseConnection();
            return result;
        }

        public List<Flight> GetFlightList()
        {
            List<Flight> result = new List<Flight>();
            OpenConnection();
            string sql = "select * from Flight ";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    result.Add(new Flight((string)dr["Flight Name"], (string)dr["Departure"], (string)dr["Arrival"], (string)dr["Departure Time"], (string)dr["Arrival Time"], (string)dr["Carrier"]));

                }


            }
            CLoseConnection();
            return result;
        }

        public List<Customer> GetCustomerFromFlight(string flightName)
        {
            List<Customer> result = new List<Customer>();
            OpenConnection();
            string sql = "select * from UserTrip where flight_number = '"+flightName+"'";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    result.Add(new Customer(flightName, (string)dr["customer_name"], (string)dr["Seat ID"], (string)dr["Price"]));

                }


            }
            CLoseConnection();
            return result;
        }

        public List<Seat> GetSeatListFromFlight(string flightName)
        {
            List<Seat> result = new List<Seat>();
            OpenConnection();
            string sql = "select * from Seat where Flight_Name = '" + flightName + "'";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    result.Add(new Seat((string)dr["Seat ID"], (string)dr["Type"], (string)dr["Price"]));

                }


            }
            CLoseConnection();
            return result;
        }

        public void InsertIntoUserTrip(string username,string flightNum,string customer,string seatID,string price)
        {
            OpenConnection();
            string sql = string.Format("Insert Into UserTrip" +
                " Values" +
                "('{0}', '{1}', '{2}', '{3}','{4}')", username,flightNum,customer,seatID,price);
            
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();
        }

        public string GetPriceFromSeat(string flight, string type)
        {
            string result = string.Empty;
            OpenConnection();
            string sql = "select * from Seat where Flight_Name = '" + flight + "' and Type = '"+type+"'";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    result = (string)dr["Price"];

                }


            }
            CLoseConnection();
            return result;
        }

        public void DeleteFromUserTrip(string flight, string customer)
        {
            OpenConnection();
            string sql = string.Format("Delete from UserTrip where flight_number = '{0}' and customer_name = '{1}'", flight,customer);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();

        }

        public void AddFlight(string flight, string dep, string arr, string depTime, string arrTime, string c)
        {
            OpenConnection();
            string sql = string.Format("Insert into Flight values ('{0}','{1}','{2}','{3}','{4}','{5}')",flight,dep,arr,depTime,arrTime,c);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();

        }

        public void UpdateFlight(string flight, string dep, string arr, string depTime, string arrTime, string c)
        {
            OpenConnection();
            string sql = string.Format("Update Flight set Departure = '{0}', Arrival = '{1}', [Departure Time] = '{2}', [Arrival Time] = '{3}', Carrier = '{4}' where [Flight Name] = '{5}'",  dep, arr, depTime, arrTime, c, flight);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();

        }
        public void DeleteFlight(string flight)
        {
            OpenConnection();
            string sql = string.Format("delete from Flight where [Flight Name] = '{0}'",  flight);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();

        }
        public void AddAccount(string username, string password, string type)
        {
            OpenConnection();
            string sql = string.Format("Insert into Account values ('{0}','{1}','{2}')", username,password,type);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
            CLoseConnection();

        }
    }

    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string type { set; get; }
        public List<Trip> tripList = new List<Trip>();
        public Account() { }
        public Account(string u, string p,string t)
        {
            username = u;
            password = p;
            type = t;
        }
    }
}
