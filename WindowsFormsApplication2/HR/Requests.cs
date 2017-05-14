using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
           PdfDocument document = new PdfDocument();
           document.Info.Title = "Exemplu";
           PdfPage page = document.AddPage();
           XGraphics gfx = XGraphics.FromPdfPage(page);
           XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);
           gfx.DrawString("Hello, World!", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
           const string filename = "HelloWorld.pdf";
           document.Save(filename);
           Process.Start(filename);
        }
    }
}
