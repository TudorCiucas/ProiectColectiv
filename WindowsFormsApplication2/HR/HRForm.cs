using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using WindowsFormsApplication2.Employee;
using WindowsFormsApplication2.HR;

namespace WindowsFormsApplication2
{
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Close();
            Login ss = new Login();
            ss.Show();
        }

        private void pontajPropriuButton_Click(object sender, EventArgs e)
        {
            Pontaj pontajPropriu = new Pontaj();
            pontajPropriu.Show();
        }

        private void pontajColectivButton_Click(object sender, EventArgs e)
        {
            PontajColectiv pontajColectiv = new PontajColectiv();
            pontajColectiv.Show();
        }

        private void alerteButton_Click(object sender, EventArgs e)
        {
            TrimiteAlerte ta = new TrimiteAlerte();
            ta.Show();
        }
    }
}
