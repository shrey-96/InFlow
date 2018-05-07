using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class DataAccess
    {
        private SqlConnection con;          // connection object
        private SqlCommand cmd;             // command object

        // constructor
        public DataAccess(string constring)
        { 
            // establish connection
            InitilizeConnection(constring);
        }

        /***********************************************************************************|
        |    Name:           InitilizeConnection()                                          |
        |    Parameters:     string con_string - connection string                          |
        |    Returns:        true - if success, false otherwise                             |
        |    Purpose:        The purpose of this method is to establish the connection      |
        |                    with the database, and if successfully establish, return       |
        |                    true to calling method.                                        |
        *************************************************************************************/
        private bool InitilizeConnection(string con_string)
        {
            // pass the connection string to connection object
            try
            {
                con = new SqlConnection(con_string);
                cmd = new SqlCommand();
            }
            catch (Exception ex)
            {
                Logging.NewLog("Error in database connection string.\n\n" + ex, "Connection String Error");
                return false;
            }

            // open the connection
            try
            {
                con.Open();
                cmd.Connection = con;
            }
            catch (Exception ex)
            {
                Logging.NewLog("Error in opening source connection.\n\n" + ex, "Connection Open");
                con.Close();
                return false;       // return false upon failure
            }

            // display message if successful
            //MessageBox.Show("Connection successfully established... :)", "Connection Success");
            return true;
        }


        /*********************************************************************************|
        |    Name:           GetData()                                                    |
        |    Parameters:     string query - sql query to be executed                      |
        |    Returns:        SqlDataReader - the result in form of data reader            |
        |    Purpose:        The purpose of this method is to execute the query           |
        |                    passed as parameter and return the SqlDataReader object.     |
        **********************************************************************************/
        public SqlDataReader GetData(string query)
        {
            SqlDataReader reader;
            cmd.CommandText = query;

            // execute reader
            try
            {
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Logging.NewLog("Error while executing reader.\n\n" + ex, "Reader Error");
                return null;
            }

            return reader;
        }


        // update or insert data into the database
        public void SetData(string query)
        {
            cmd.CommandText = query;

            // execute reader
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logging.NewLog("Error while executing query.\n\n" + ex, "Update/Insert Error");
            }
        }



        // gets the data of specified column
        public string GetColumnData(string query, string column)
        {
            string result = "";

            try
            {
                using (SqlDataReader reader = GetData(query))
                {
                    while (reader.Read())
                    {
                        result = reader[column].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.NewLog("GetColumnData", "Error while executing query: " + query + "\n" + ex.Message);
            }

            return result;
        }


        // get the data in a list
        public List<string> GetAllData(string query, string column)
        {
            List<string> vs = new List<string>();

            try
            {
                using (SqlDataReader reader = GetData(query))
                {
                    while (reader.Read())
                    {
                        vs.Add(reader[column].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Logging.NewLog("GetAllData", "Head of House does not exist in database " + ex.Message);
            }


            return vs;
        }


        // sample stored procedure method
        public bool AddNewUser(string username, string pass, string firstname, string lastname, string phone, string email)
        {


            string Stored_Procedure = "RegisterUser";

            try
            {
                using (SqlCommand TempCmd = new SqlCommand(Stored_Procedure, con))
                {
                    TempCmd.CommandType = CommandType.StoredProcedure;

                    // add parameters for the stored procedure
                    TempCmd.Parameters.Add("@username_param", SqlDbType.VarChar).Value = username;
                    TempCmd.Parameters.Add("@pass_param", SqlDbType.VarChar).Value = pass;
                    TempCmd.Parameters.Add("@firstname_param", SqlDbType.VarChar).Value = firstname;
                    TempCmd.Parameters.Add("@lastname_param", SqlDbType.VarChar).Value = lastname;
                    TempCmd.Parameters.Add("@phone_param", SqlDbType.VarChar).Value = phone;
                    TempCmd.Parameters.Add("@email_param", SqlDbType.VarChar).Value = email;

                    TempCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                Logging.NewLog("AddNewUser", "Failed to insert user into database. Fatal Error. \n\n" + ex);
                return false;
            }

            return true;
        }



        /************************************************************************************|
        |    Name:           CloseConnection()                                               |
        |    Parameters:     void                                                            |
        |    Returns:        true if successfully closed, false otherwise.                   |
        |    Purpose:        The purpose of this method is to close the connection           |
        |                    with the database.                                              |
        *************************************************************************************/
        public bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
