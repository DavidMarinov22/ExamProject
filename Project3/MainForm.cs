using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class MainForm : Form
    {
        private string CurrentUserEGN = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBoxSearch.Items.Clear();
            string pattForInstallationDB = Application.UserAppDataPath.ToString();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename= " + pattForInstallationDB + @"\Database.mdf;";
            string sqlStatement = "SELECT * FROM dbo.Students WHERE FIRST_NAME= '" + comboBoxSearch.Text.Trim() + "'";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlStatement, connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        List<string> value = new List<string>() { reader.GetValue(0).ToString().Trim(), reader.GetValue(1).ToString().Trim() , reader.GetValue(2).ToString().Trim(), reader.GetValue(3).ToString().Trim()};
                        comboBoxSearch.Items.Add(string.Join(" ", value));
                    }
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();
            addStudentForm.Show();
            this.Hide();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentUser = comboBoxSearch.Text.Split(" ");
            string pattForInstallationDB = Application.UserAppDataPath.ToString();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename= " + pattForInstallationDB + @"\Database.mdf;";
            string sqlStatement = "DELETE FROM dbo.Students WHERE Id='" + currentUser[0] + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (string.IsNullOrWhiteSpace(comboBoxSearch.Text))
                {
                    MessageBox.Show("There is no student to delete!");
                }
                else
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlStatement, connection);

                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("You deleted this student");
                        comboBoxSearch.Items.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There is no student to delete!");
                    }
                }
            }
        }
    }
}
