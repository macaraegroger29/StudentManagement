using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class Student_Page : Form
    {
        private string connectionString = "server=localhost;database=StudentInfoDB;uid=root;pwd=;";

        public Student_Page()
        {
            InitializeComponent();
            InitializeDataGridView();
            TestConnection();
            LoadStudentRecords();
        }

        private void TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Database connection successful!");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection Error: " + ex.Message + "\n\nPlease ensure:\n1. XAMPP is running\n2. MySQL service is started\n3. Database 'StudentInfoDB' exists");
                }
            }
        }

        private void InitializeDataGridView()
        {
            StudentListDataGridView.Columns.Add("StudentID", "Student ID");
            StudentListDataGridView.Columns.Add("FullName", "Full Name");
            
            // Add VIEW button column
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.HeaderText = "Action";
            viewButtonColumn.Text = "VIEW";
            viewButtonColumn.Name = "ViewButton";
            viewButtonColumn.UseColumnTextForButtonValue = true;
            StudentListDataGridView.Columns.Add(viewButtonColumn);

            StudentListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentListDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentListDataGridView.CellClick += StudentListDataGridView_CellClick;
        }

        private void LoadStudentRecords()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT studentId, 
                                   CONCAT(firstName, ' ', IFNULL(middleName, ''), ' ', lastName) as FullName 
                                   FROM StudentRecordTB";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    StudentListDataGridView.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        StudentListDataGridView.Rows.Add(row["studentId"], row["FullName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student records: " + ex.Message);
            }
        }

        private void StudentListDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == StudentListDataGridView.Columns["ViewButton"].Index)
            {
                string studentId = StudentListDataGridView.Rows[e.RowIndex].Cells["StudentID"].Value.ToString();
                StudentPage_Individual studentForm = new StudentPage_Individual(studentId);
                studentForm.Show();
            }
        }
    }
} 