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
    public partial class ChangePasswordForm : Form
    {
        private string Username = "";
        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            this.Username = username;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string pattForInstallationDB = Application.UserAppDataPath.ToString();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename= " + pattForInstallationDB + @"\Database.mdf;";
            string sqlStatement = @"UPDATE dbo.Users SET PASSWORD = '" + txtConfirmPassword.Text + "' WHERE USERNAME = '" + Username + "'";
            string sqlStatementFind = @"SELECT * FROM dbo.Users WHERE USERNAME='" + Username + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sqlStatementFind, connection);


                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    command = new SqlCommand(sqlStatement, connection);
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        reader = command.ExecuteReader();
                        MessageBox.Show("You have succesfully changed your password!");
                    }
                    else
                    {
                        MessageBox.Show("Confirm password need to be identical to the new password!");
                    }
                }
                else
                {
                    MessageBox.Show("There is no user with that username");
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
