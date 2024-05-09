using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataLayer
    {
        private string connectionString = "Data Source=DESKTOP-URR6DQA\\SQLEXPRESS;Initial Catalog=CALCULATED;Integrated Security=True;";

        public void SaveCalculation(string expression)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Calculations (Expression) VALUES (@Expression);";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Expression", expression);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
