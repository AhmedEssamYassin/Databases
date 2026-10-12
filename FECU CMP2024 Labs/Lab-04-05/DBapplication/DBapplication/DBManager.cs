using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace DBapplication
{
    public class DBManager : IDisposable
    {
        static string DB_Connection_String = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        SqlConnection myConnection;

        public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while connecting to the database!");
            }
        }

        public void Dispose()
        {
            if (myConnection != null)
            {
                if (myConnection.State == ConnectionState.Open)
                    myConnection.Close();
                myConnection.Dispose();
            }
        }

        private void EnsureConnectionOpen()
        {
            if (myConnection.State == ConnectionState.Closed || myConnection.State == ConnectionState.Broken)
            {
                myConnection.Open();
            }
        }

        private SqlCommand CreateCommand(string query, Dictionary<string, object> parameters, bool isStoredProcedure = false)
        {
            EnsureConnectionOpen();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            if (isStoredProcedure)
            {
                myCommand.CommandType = CommandType.StoredProcedure;
            }
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    myCommand.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }
            return myCommand;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null, bool isStoredProcedure = false)
        {
            try
            {
                using (SqlCommand myCommand = CreateCommand(query, parameters, isStoredProcedure))
                {
                    return myCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string query, Dictionary<string, object> parameters = null, bool isStoredProcedure = false)
        {
            try
            {
                using (SqlCommand myCommand = CreateCommand(query, parameters, isStoredProcedure))
                {
                    using (SqlDataReader reader = myCommand.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string query, Dictionary<string, object> parameters = null, bool isStoredProcedure = false)
        {
            try
            {
                using (SqlCommand myCommand = CreateCommand(query, parameters, isStoredProcedure))
                {
                    return myCommand.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
