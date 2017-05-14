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

        private void reportGenButton_Click(object sender, EventArgs e)
        {
           
            Requests r = new Requests();
            r.Show();
        }
    }
}
