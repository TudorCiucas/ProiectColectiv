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
    public partial class Cereri : Form
    {
        public Cereri()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
           
            
            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=LoginData;Integrated Security=True");
            
            con.Open();
            String sql = "insert into Cereri ([tip], [text])  values(@first,@last)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@first", cereriComboBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Row inserted !! ");
            }
            con.Close();
        }
        
    }
}
