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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string pattForInstallationDB = Application.UserAppDataPath.ToString();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename=" + pattForInstallationDB + @"\Database.mdf;";
            string sqlStatementForUsernameAndPassword = @"SELECT * FROM dbo.Users WHERE USERNAME='" + loginUsername.Text.Trim() + "' AND PASSWORD='" + loginPassword.Text + "'";
            string sqlStatementForUsername = @"SELECT * FROM dbo.Users WHERE USERNAME='" + loginUsername.Text.Trim() + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlStatementForUsernameAndPassword, connection);
                


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MainForm dashboardForm = new MainForm();
                    dashboardForm.Show();
                    this.Hide();
                    return;
                }
                connection.Close();
                connection.Open();
                command = new SqlCommand(sqlStatementForUsername, connection);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Incorrect password!");
                }
                else
                {
                    MessageBox.Show("There is no users with this username/password");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(loginUsername.Text);
            changePasswordForm.Show();
            this.Hide();
        }
    }
}
