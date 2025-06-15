using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MidTerm_Lab
{
    public partial class Student_Page : Form
    {
        string connectionString = "server=localhost;user id=root;password=;database=studentinfodb;";

        public Student_Page()
        {
            InitializeComponent();
        }

        private void Student_Page_Load(object sender, EventArgs e)
        {
            loadStudents();
            StudentGrid.CellContentClick += StudentGrid_CellContentClick;
        }

        private void loadStudents()
        {
            string query = @"
                SELECT studentId, 
                       CONCAT(firstName, ' ', middleName, ' ', lastName) AS fullName 
                FROM StudentRecordTB";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    StudentGrid.DataSource = table;

                    // Add VIEW button
                    if (!StudentGrid.Columns.Contains("ViewBtn"))
                    {
                        DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                        viewBtn.HeaderText = "VIEW";
                        viewBtn.Text = "VIEW";
                        viewBtn.Name = "ViewBtn";
                        viewBtn.UseColumnTextForButtonValue = true;
                        StudentGrid.Columns.Add(viewBtn);
                    }

                    // Styling
                    StudentGrid.Columns["studentId"].HeaderText = "Student ID";
                    StudentGrid.Columns["studentId"].Width = 120;

                    StudentGrid.Columns["fullName"].HeaderText = "Full Name";
                    StudentGrid.Columns["fullName"].Width = 300;

                    StudentGrid.Columns["ViewBtn"].Width = 80;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message);
                }
            }
        }

        private void StudentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentGrid.Columns[e.ColumnIndex].Name == "ViewBtn")
            {
                string studentId = StudentGrid.Rows[e.RowIndex].Cells["studentId"].Value.ToString();
                MessageBox.Show($"You clicked VIEW for Student ID: {studentId}");

                

                Student_Page_Individual individualForm = new Student_Page_Individual(studentId);
                individualForm.Show();
                // 👉 You can open another form here to show student details
                // new Edit_Page(studentId).Show();
            }
        }
    }
}
