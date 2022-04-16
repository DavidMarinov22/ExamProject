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
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlStatementForUsernameAndPassword = @"SELECT * FROM dbo.Users WHERE USERNAME='" + loginUsername.Text.Trim() + "' AND PASSWORD='" + loginPassword.Text + "'";
            string sqlStatementForUsername = @"SELECT * FROM dbo.Users WHERE USERNAME='" + loginUsername.Text.Trim() + "'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand commandUsernameAndPassword = new SqlCommand(sqlStatementForUsernameAndPassword, connection);
                SqlCommand commandUsername = new SqlCommand(sqlStatementForUsername, connection);


                SqlDataReader reader1 = commandUsernameAndPassword.ExecuteReader();
                if (reader1.HasRows)
                {
                    DashboardForm dashboardForm = new DashboardForm();
                    dashboardForm.Show();
                    this.Hide();
                    return;
                }
                connection.Close();
                connection.Open();
                reader1 = commandUsername.ExecuteReader();
                if (reader1.HasRows)
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
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.Show();
            this.Hide();
        }
    }
}
