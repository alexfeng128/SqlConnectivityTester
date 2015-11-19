using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace SqlConnectivityTester.Common
{
    public static class Helper
    {
        public static bool TransferBoolValue(string input)
        {
            bool result;

            switch (input)
            {
                case "false":
                case "False":
                case "FALSE":
                case "0":
                case "no":
                case "No":
                case "NO":
                    result = false;
                    break;

                case "true":
                case "True":
                case "TRUE":
                case "1":
                case "yes":
                case "Yes":
                case "YES":
                    result = true;
                    break;

                default:
                    throw new System.InvalidCastException();
            }

            return result;
        }
        public static ServerProperty GetSqlServerProperty(string conString)
        {
            ServerProperty serverProperty = new ServerProperty();

            string commandText = "SELECT SERVERPROPERTY('MachineName') as MachineName,SERVERPROPERTY('ServerName'),SERVERPROPERTY('InstanceName'),SERVERPROPERTY('IsClustered'),SERVERPROPERTY('ComputerNamePhysicalNetBIOS'),SERVERPROPERTY('Edition'),SERVERPROPERTY('ProductLevel'),SERVERPROPERTY('ProductVersion'),SERVERPROPERTY('ProcessID'),SERVERPROPERTY('Collation'),SERVERPROPERTY('IsIntegratedSecurityOnly'),SERVERPROPERTY('IsHadrEnabled'),SERVERPROPERTY('HadrManagerStatus');";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.CommandText = commandText;
                cmd.CommandType = CommandType.Text;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    serverProperty.MachineName = reader.GetString(0);
                    serverProperty.ServerName = Convert.ToString(reader[1]);
                    serverProperty.InstanceName = String.IsNullOrEmpty(Convert.ToString(reader[2])) ? "MSSQLSERVER (Default Instance)" : Convert.ToString(reader[2]);
                    serverProperty.IsClustered = Convert.ToInt32(reader[3]);
                    serverProperty.ComputerNamePhysicalNetBIOS = Convert.ToString(reader[4]);
                    serverProperty.Edition = Convert.ToString(reader[5]);
                    serverProperty.ProductLevel = Convert.ToString(reader[6]);
                    serverProperty.ProductVersion = Convert.ToString(reader[7]);
                    serverProperty.ProcessID = Convert.ToInt32(reader[8]);
                    serverProperty.Collation = Convert.ToString(reader[9]);
                    serverProperty.IsIntegratedSecurityOnly = Convert.ToInt32(reader[10]);
                    serverProperty.IsHadrEnabled = Convert.ToInt32(reader[11]);
                    serverProperty.HadrManagerStatus = Convert.ToString(reader[12]);
                }
            }

            return serverProperty;
        }

        public static AuthenticationMode GetAuthenticaitonMode(int index)
        {
            return (AuthenticationMode)(index);
        }
    }
}
