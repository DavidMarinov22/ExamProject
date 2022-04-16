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
            string connectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=ProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string sqlStatement = "INSERT INTO dbo.Users(USERNAME, PASSWORD) VALUES('" + registerUsername.Text.Trim() + "', '" + registerPassword.Text + "')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    MessageBox.Show("You have succesfully registered");
                }
                catch (Exception)
                {
                    MessageBox.Show("This username is unavailable");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
