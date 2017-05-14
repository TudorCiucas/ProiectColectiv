using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login ss = new Login();
            ss.Show();
        }

        private void userManagementButton_Click(object sender, EventArgs e)
        {
            UserManagement ss = new UserManagement();
            ss.Show();
        }
    }
}
