using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class Pdf_PreviewForm : Form
    {
        public Pdf_PreviewForm()
        {
            InitializeComponent();
        }

        private void Pdf_PreviewForm_Load(object sender, EventArgs e)
        {

        }

        public void refreshForm(string fileName)
        {
            
            axAcroPDF1.LoadFile(fileName);
        }
    }
}
