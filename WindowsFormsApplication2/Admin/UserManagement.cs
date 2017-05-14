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

namespace WindowsFormsApplication2
{
    public partial class UserManagement : Form
    {
        public static String Gender;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
        

        private void saveButton_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=LoginData;Integrated Security=True");

            con.Open();
            String sql = "insert into Employee ([ID], [FirstName], [LastName], [DateOfBirth], [DateOfRegistration], [Gender], [PhoneNumber], [Address], [Username], [Password]) values(@id,@first,@last,@dob,@dor,@gender,@phone,@add,@user,@pass)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@first", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@last", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@dob", dateOfBirthPicker.Value.Date);
                cmd.Parameters.AddWithValue("@dor", dateOfRegistrationPicker.Value.Date);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@phone", phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@add", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@user", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee insertion succesfull! ");
            }
            sql = "insert into Login ([username],[password],[admin],[hr],[employee]) values(@user,@pass,@ad,@hr,@em)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@user", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                if (typeTextBox.Text.ToLower() == "admin")
                {
                    cmd.Parameters.AddWithValue("@ad", "1");
                }
                if (typeTextBox.Text.ToLower() == "hr")
                {
                    cmd.Parameters.AddWithValue("@hr", "1");
                }
                if (typeTextBox.Text.ToLower() == "employee")
                {
                    cmd.Parameters.AddWithValue("@em", "1");
                }
            }
                con.Close();
            this.employeeTableAdapter.Fill(this.loginDataDataSet11.Employee);
        }
        

        private void maleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";
        }

        private void femaleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataDataSet11.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.loginDataDataSet11.Employee);
            // TODO: This line of code loads data into the 'loginDataDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter1.Fill(this.loginDataDataSet1.Employee);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=LoginData;Integrated Security=True");

            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            String sql = "UPDATE Employee SET FirstName=@first, LastName=@last, DateOfBirth=@dob, DateOfRegistration=@dor, Gender=@gender, PhoneNumber=@phone, Address=@add, Username=@user, Password=@pass WHERE ID = @id";
            using (cmd)
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@first", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@last", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@dob", dateOfBirthPicker.Value.Date);
                cmd.Parameters.AddWithValue("@dor", dateOfRegistrationPicker.Value.Date);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@phone", phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@add", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@user", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@pass", passwordTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee modification succesfull! ");
            }
            con.Close();
            this.employeeTableAdapter.Fill(this.loginDataDataSet11.Employee);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=LoginData;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            String sql = "Delete from Employee where ID=@id";
            using (cmd)
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", idTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deletion succesfull! ");
            }
            con.Close();
            this.employeeTableAdapter.Fill(this.loginDataDataSet11.Employee);
        }
    }
}
