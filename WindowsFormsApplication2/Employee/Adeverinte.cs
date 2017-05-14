using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Employee
{
    public partial class Adeverinte : Form
    {
        public Adeverinte()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Text == "Adeverinta medicala")
            {

            }
        }
    }
}
