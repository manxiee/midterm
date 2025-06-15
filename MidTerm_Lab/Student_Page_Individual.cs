using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm_Lab
{
    public partial class Student_Page_Individual : Form
    {
      
        private string studentId;
        private string connectionString = "server=localhost;user id=root;password=;database=studentinfodb;";

        public Student_Page_Individual(string studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            this.Load += new EventHandler(Edit_Page_Load);
        }

        private void Edit_Page_Load(object sender, EventArgs e)
        {
            loadStudentData();
            makeTextBoxesReadOnly();
        }

        private void loadStudentData()
        {
            string query = "SELECT * FROM StudentRecordTB WHERE studentId = @studentId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", studentId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_Id.Text = reader["studentId"].ToString();
                            txt_FirstName.Text = reader["firstName"].ToString();
                            txt_MiddleName.Text = reader["middleName"].ToString();
                            txt_LastName.Text = reader["lastName"].ToString();
                            txt_HouseNo.Text = reader["houseNo"].ToString();
                            txt_Barangay.Text = reader["brgyName"].ToString();
                            txt_Municipality.Text = reader["municipality"].ToString();
                            txt_Province.Text = reader["province"].ToString();
                            txt_Region.Text = reader["region"].ToString();
                            txt_Country.Text = reader["country"].ToString();
                            txt_Birthdate.Text = reader["birthdate"].ToString();
                            txt_Age.Text = reader["age"].ToString();
                            txt_ContactNo.Text = reader["studContactNo"].ToString();
                            txt_Email.Text = reader["emailAddress"].ToString();
                            txt_Guardian_FirstName.Text = reader["guardianFirstName"].ToString();
                            txt_Guardian_LastName.Text = reader["guardianLastName"].ToString();
                            txt_Hobbies.Text = reader["hobbies"].ToString();
                            txt_Nickname.Text = reader["nickname"].ToString();
                            txt_Course.Text = reader["courseId"].ToString();
                            txt_Year.Text = reader["yearId"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void makeTextBoxesReadOnly()
        {
            txt_Id.ReadOnly = true;
            txt_FirstName.ReadOnly = true;
            txt_MiddleName.ReadOnly = true;
            txt_LastName.ReadOnly = true;
            txt_HouseNo.ReadOnly = true;
            txt_Barangay.ReadOnly = true;
            txt_Municipality.ReadOnly = true;
            txt_Province.ReadOnly = true;
            txt_Region.ReadOnly = true;
            txt_Country.ReadOnly = true;
            txt_Birthdate.ReadOnly = true;
            txt_Age.ReadOnly = true;
            txt_ContactNo.ReadOnly = true;
            txt_Email.ReadOnly = true;
            txt_Guardian_FirstName.ReadOnly = true;
            txt_Guardian_LastName.ReadOnly = true;
            txt_Hobbies.ReadOnly = true;
            txt_Nickname.ReadOnly = true;
            txt_Course.ReadOnly = true;
            txt_Year.ReadOnly = true;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the viewer and return
        }
    }
}
