using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentManagementSystem
{
    public partial class StudentPage_Individual : Form
    {
        private string connectionString = "server=localhost;database=StudentInfoDB;uid=root;pwd=;";
        private string studentId;

        public StudentPage_Individual(string id)
        {
            InitializeComponent();
            studentId = id;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT s.*, c.courseName, y.yearLvl
                                   FROM StudentRecordTB s
                                   LEFT JOIN CourseTB c ON s.courseId = c.courseId
                                   LEFT JOIN YearTB y ON s.yearId = y.yearId
                                   WHERE s.studentId = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtStudentID.Text = reader["studentId"].ToString();
                        txtFirstName.Text = reader["firstName"].ToString();
                        txtLastName.Text = reader["lastName"].ToString();
                        txtMiddleName.Text = reader["middleName"].ToString();
                        txtHouseNo.Text = reader["houseNo"].ToString();
                        txtBrgy.Text = reader["brgyName"].ToString();
                        txtMunicipality.Text = reader["municipality"].ToString();
                        txtProvince.Text = reader["province"].ToString();
                        txtRegion.Text = reader["region"].ToString();
                        txtCountry.Text = reader["country"].ToString();
                        txtBirthdate.Text = Convert.ToDateTime(reader["birthdate"]).ToShortDateString();
                        txtAge.Text = reader["age"].ToString();
                        txtContact.Text = reader["studContactNo"].ToString();
                        txtEmail.Text = reader["emailAddress"].ToString();
                        txtGuardianFirstName.Text = reader["guardianFirstName"].ToString();
                        txtGuardianLastName.Text = reader["guardianLastName"].ToString();
                        txtHobbies.Text = reader["hobbies"].ToString();
                        txtNickname.Text = reader["nickname"].ToString();
                        txtCourse.Text = reader["courseName"].ToString();
                        txtYear.Text = reader["yearLvl"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student details: " + ex.Message);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} 