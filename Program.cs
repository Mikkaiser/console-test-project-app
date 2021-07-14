using System;
using System.Data.SqlClient;

namespace SUPERTESTESAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            #region "DEFINITIONS"
            //Variables definitions
            string[] delegationsGeneral = new string[185];
            int count = 0;

            //Instance Definitions
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-9DTHGET\SQLEXPRESS;Initial Catalog=db_uniforms_duel;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();

            //Command
            string delegationsAll = "SELECT * FROM tbl_delegations";
            
            //sqlCommand
            sqlCommand = new SqlCommand(delegationsAll, sqlConnection);

            //SqlConnection
            sqlConnection.Open();
            SqlDataReader delegationsRead = sqlCommand.ExecuteReader();

            #endregion


            #region "STORAGE - DELEGATIONS"
            //try/catch
            try
            {
                while (delegationsRead.Read())
                {
                    
                    delegationsGeneral[count] = delegationsRead[1].ToString();
                    count++;
                }
                sqlConnection.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error: { error }");
            }
            #endregion


        }
    }
}
