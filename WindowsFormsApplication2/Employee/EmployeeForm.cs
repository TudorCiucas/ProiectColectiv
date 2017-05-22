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
        private String name;
        public EmployeeForm()
        {
            InitializeComponent();
        }

        public EmployeeForm(String name)
        {
            this.name = name;
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
            Cereri c = new Cereri(name);
            c.Show();
        }

        private void pontajButton_Click(object sender, EventArgs e)
        {
            Pontaj p = new Pontaj(name);
            p.Show();
        }
    }
}
