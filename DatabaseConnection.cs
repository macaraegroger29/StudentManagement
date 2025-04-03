using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace StudentManagementSystem
{
    public class DatabaseConnection
    {
        private static string ConnectionString = "Server=localhost;Database=StudentInfoDB;Uid=root;Pwd=;";
        private static MySqlConnection Connection = new MySqlConnection(ConnectionString);

        public static DataTable GetStudentList()
        {
            DataTable Dt = new DataTable();
            try
            {
                Connection.Open();
                string Query = "SELECT StudentId, FullName FROM StudentRecordTB";
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return Dt;
        }

        public static DataTable GetStudentDetails(string StudentId)
        {
            DataTable Dt = new DataTable();
            try
            {
                Connection.Open();
                string Query = "SELECT * FROM StudentRecordTB WHERE StudentId = @StudentId";
                MySqlCommand Command = new MySqlCommand(Query, Connection);
                Command.Parameters.AddWithValue("@StudentId", StudentId);
                MySqlDataAdapter Adapter = new MySqlDataAdapter(Command);
                Adapter.Fill(Dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return Dt;
        }
    }
} 