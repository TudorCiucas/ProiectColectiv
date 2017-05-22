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

namespace WindowsFormsApplication2.Employee
{
    public partial class Pontaj : Form
    {
        
        private String name;
        public Pontaj()
        {
            InitializeComponent();
        }

        public Pontaj(String name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=example;Integrated Security=True");

            DateTime dt = DateTime.Now;
            con.Open();
            SqlCommand cmd2= con.CreateCommand();
            cmd2.CommandText = "SELECT id FROM utilizatori WHERE email='" + name + "'";
            var result = cmd2.ExecuteScalar();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT max(id) FROM pontaj";
            int count = (int)cmd1.ExecuteScalar();
            count = count + 1;

            String sql = "insert into pontaj ([id],[checkin],[checkout],[date],[user_id]) values(@id,@chin,@chout,@date,@userid)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@userid", result);
                cmd.Parameters.AddWithValue("@id", count);
                cmd.Parameters.AddWithValue("@chin", checkInPicker.Text);
                cmd.Parameters.AddWithValue("@chout", checkOutPicker.Text);
                cmd.Parameters.AddWithValue("@date", dt);
             
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee insertion succesfull! ");
            }
            con.Close();
            
        }
    }
}
