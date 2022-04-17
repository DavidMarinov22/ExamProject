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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pattForInstallationDB = Application.UserAppDataPath.ToString();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename=" + pattForInstallationDB + @"\Database.mdf;";
            string sqlStatement = "INSERT INTO dbo.Users(USERNAME, PASSWORD) VALUES('" + registerUsername.Text.Trim() + "', '" + registerPassword.Text + "')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    if (string.IsNullOrWhiteSpace(registerUsername.Text))
                    {
                        MessageBox.Show("This username is unavailable. Please try again!");
                    }
                    else if (registerPassword.Text == txtConfirmPassword.Text)
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        MessageBox.Show("You have succesfully registered");
                        LoginForm form = new LoginForm();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Confirm password need to be identical to the password!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("This username is unavailable");
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
