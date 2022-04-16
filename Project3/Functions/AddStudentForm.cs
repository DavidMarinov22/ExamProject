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
    public partial class AddStudentForm : Form
    {
        private string CurrentDate = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");


        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yearAndDate.Format = DateTimePickerFormat.Custom;
            yearAndDate.CustomFormat = "yyyy / MM / dd";
            try
            {
                string pattForInstallationDB = Application.UserAppDataPath.ToString();
                string connectionString = @"Server=(localdb)\MSSQLLocalDB;AttachDbFilename= " + pattForInstallationDB + @"\Database.mdf;";
                string sqlStatement = "INSERT INTO dbo.STUDENTS(FIRST_NAME, SURENAME, LAST_NAME, EGN_PIN, GRADE, NUMBER_CLASS, STATUS, SCHOOL_YEAR, DATE_YEAR, CHANGE_TIME) VALUES('" + txtFIrstName.Text.Trim() + "', '" + txtSurename.Text.Trim() + "', '" + txtLastName.Text.Trim() + "', '" + txtEGN.Text.Trim() + "', '" + Convert.ToInt32(comboBoxGrade.Text) + "', '" + Convert.ToInt32(txtClassNum.Text) + "', '" + comboBoxStatus.Text.Trim() + "', '" + comboBoxYear.Text.Trim() + "', '" + yearAndDate.Text + "', '" + CurrentDate + "')";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlStatement, connection);

                        if (string.IsNullOrWhiteSpace(txtClassNum.Text) 
                            || string.IsNullOrWhiteSpace(txtFIrstName.Text) 
                            || string.IsNullOrWhiteSpace(txtLastName.Text)
                            || string.IsNullOrWhiteSpace(txtSurename.Text)
                            || string.IsNullOrWhiteSpace(txtEGN.Text)
                            || string.IsNullOrWhiteSpace(comboBoxGrade.Text)
                            || string.IsNullOrWhiteSpace(comboBoxStatus.Text)
                            || string.IsNullOrWhiteSpace(comboBoxYear.Text))
                        {
                            MessageBox.Show("Insert data!");
                        }
                        else
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            MessageBox.Show("You have succesfully added a new student!");
                            reader.Close();
                            MainForm dashboardForm = new MainForm();
                            dashboardForm.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The EGN cannot be repeated");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insert data!");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
