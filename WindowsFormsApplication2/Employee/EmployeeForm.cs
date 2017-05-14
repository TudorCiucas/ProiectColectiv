using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Employee;

namespace WindowsFormsApplication2
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login ss = new Login();
            ss.Show();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            Cereri c = new Cereri();
            c.Show();
        }
    }
}
