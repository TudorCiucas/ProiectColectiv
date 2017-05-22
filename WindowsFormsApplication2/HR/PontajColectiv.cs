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

namespace WindowsFormsApplication2.HR
{
    public partial class PontajColectiv : Form
    {
        public PontajColectiv()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=TUDOR;Initial Catalog=example;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandText = "SELECT us.nume, pt.checkin, pt.checkout, pt.date FROM utilizatori as us, pontaj as pt where pt.user_id = us.id  ";

            listBox1.Text = cmd1.ExecuteScalar().ToString();
            con.Close();
        }

    }
}
