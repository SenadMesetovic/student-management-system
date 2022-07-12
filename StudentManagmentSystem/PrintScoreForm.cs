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
    public partial class PrintScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintScoreForm()
        {
            InitializeComponent();
        }

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            showScoreTable();
        }

        public void showScoreTable()
        {
            string strcmd = "SELECT * FROM (SELECT score.studentId, student.StudentFirstName, student.StudentLastName,  score.CourseId, course.CourseName, score.Score, score.scoreDescription FROM ((score INNER JOIN course ON score.CourseId = course.CourseId) INNER JOIN student ON score.studentId = student.StudentId)) AS newtable ";
            DataGridView_score.DataSource = score.getList(strcmd);

        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Mašinski Fakultet Score List";
            printer.SubTitle = String.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            //printer.ProportionalColumns = true;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Univerzitet u Sarajevu";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_score);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchData = textBox_search.Text;
            string strCommand = "SELECT * FROM (SELECT* FROM(SELECT score.studentId, student.StudentFirstName, student.StudentLastName, score.CourseId, course.CourseName, score.Score, score.scoreDescription FROM ((score INNER JOIN course ON score.CourseId = course.CourseId) INNER JOIN student ON score.studentId = student.StudentId)) AS newtable) AS newtable1 WHERE CONCAT(StudentFirstName,StudentLastName, CourseName, Score, StudentId, CourseId) LIKE '%" + searchData + "%'";
            DataGridView_score.DataSource = score.getList(strCommand);
        }
    }
}
