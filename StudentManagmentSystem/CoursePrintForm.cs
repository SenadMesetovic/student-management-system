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
    public partial class CoursePrintForm : Form
    {
        CourseClass course = new CourseClass();
        DGVPrinter printer = new DGVPrinter();
        public CoursePrintForm()
        {
            InitializeComponent();
        }

        private void CoursePrintForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            DataGridView_course.DataSource = course.getCourseTable();
            textBox_search.Clear();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_course.DataSource = course.searchCourse(textBox_search.Text);
        }

        private void button_print_Click(object sender, EventArgs e)
        {
                printer.Title = "Mašinski Fakultet Course List";
                printer.SubTitle = String.Format("Date: {0}", DateTime.Now.ToString());
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                //printer.ProportionalColumns = true;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Masinac";
                printer.FooterSpacing = 15;
                printer.printDocument.DefaultPageSettings.Landscape = true;
                printer.PrintDataGridView(DataGridView_course);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
