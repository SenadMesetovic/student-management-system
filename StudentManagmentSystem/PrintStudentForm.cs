using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace StudentManagmentSystem
{
    public partial class PrintStudentForm : Form
    {
        StudentClass student = new StudentClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM student"));
        }

        

        //Create a function to show the student list in datagridview
        public void showData(MySqlCommand command)
        {
            DataGridView_student.ReadOnly = true;
            DataGridViewImageColumn imageColumnn = new DataGridViewImageColumn();
            DataGridView_student.DataSource = student.getList(command);

            imageColumnn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumnn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM student";
            }
            else if (radioButton_male.Checked)
            {
                selectQuery = "SELECT * FROM student WHERE StudentGender='Male'";
            }
            else
            {
                selectQuery = "SELECT * FROM student WHERE StudentGender='Female'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Mašinski Fakultet Students List";
            printer.SubTitle=String.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            //printer.ProportionalColumns = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape= true;
            printer.PrintDataGridView(DataGridView_student);
        }
    }
}
