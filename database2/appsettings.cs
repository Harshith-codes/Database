using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//step1
using System.Data.SqlClient;
using System.Configuration;

namespace database2
{
    class appsettings    
    {
        SqlConnection connection;
        public appsettings()
        {
            //step2-create connection
            string strconnectionString = "Data Source=09196839-HARSHI;Initial Catalog=C#database2;Integrated Security=True";
            connection = new SqlConnection(strconnectionString);
            //step3-open connection
            connection.Open();
        }
        //step4-sql query
        public string checkusertype(string userName, string userpassword)
        {
            string query = "SELECT UserType FROM table_users WHERE UserName = '" +userName + "' AND password ='" + userpassword+ "'";
            //step5-create sql command object
            SqlCommand command = new SqlCommand(query, connection);
            //step6 -execute query
            string result = command.ExecuteScalar().ToString();
            //step7-close
            connection.Close();
            command = null;
            return result;
           
        }

        public void saveUser(string fName, string lName, string uName, string password, string uType)
        {
            string query = "INSERT INTO table_users VALUES('" + uName + "','" + fName + "','" + lName + "','" + password + "','" + uType + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int noOfRows=command.ExecuteNonQuery();
            connection.Close();
            /*command = null;*/
        }

        public void updateUser(string password, string uType, string uName)
        {
            string query = "UPDATE table_users SET (password='" +password + "',uType='" + uType + "' WHERE UserName = '" + uName + "' )";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            command = null;
        }
    }
}
