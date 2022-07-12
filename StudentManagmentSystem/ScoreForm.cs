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

namespace StudentManagmentSystem
{
    public partial class ScoreForm : Form
    {
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        CourseClass course = new CourseClass();
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            showStudentTable();
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseId";
            comboBox_selectCourse.DataSource = course.getCourseTable();
            comboBox_selectCourse.SelectedItem = null;



        }

        public void showStudentTable()
        {
            DataGridView_Student.DataSource = student.getStudentlist();
            //DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_Student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        public void showScoreTable(int id)
        {
            string strcmd = "SELECT courseid, coursename, score, scoredescription FROM (SELECT * FROM (SELECT score.studentId, score.CourseId, course.CourseName, score.Score, score.scoreDescription FROM score INNER JOIN course ON score.CourseId = course.CourseId) AS newtable WHERE StudentId="+ id+") AS newtable2";
            //DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT * FROM score WHERE StudentId = "+id ));
            DataGridView_score.DataSource = score.getList(strcmd);

            //DataGridView_score.DataSource = score.getList(new MySqlCommand("SELECT score.StudentId, student.StudentFirstName, student.StudentLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.StudentId = student.StudentId"));


        }



        private void button_ShowScoreBack_Click(object sender, EventArgs e)
        {
            if (button_ShowScoreBack.Text=="<<Back")
            {
                button_ShowScoreBack.Text = "Show Score";
                DataGridView_Student.BringToFront();
                label_studentscore.Text = "Student list";
            }
            else
            {
                button_ShowScoreBack.Text = "<<Back";
                DataGridView_score.BringToFront();
                label_studentscore.Text = "Score list for " + DataGridView_Student.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView_Student.CurrentRow.Cells[2].Value.ToString() + ", Student Id: " + DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
                showScoreTable(Convert.ToInt32(DataGridView_Student.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void DataGridView_Student_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_ShowScoreBack.PerformClick();
        }

        private void DataGridView_Student_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text = DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string studentId=textBox_studentId.Text;
            string sc = textBox_score.Text;
            string description=textBox_scoreDescription.Text;

            if (int.TryParse(studentId, out int intStudentId) && comboBox_selectCourse.SelectedItem!=null && int.TryParse(comboBox_selectCourse.SelectedValue.ToString(), out int intCourseId) && double.TryParse(sc, out double doubleScore) && student.studentIdExist(intStudentId) && !score.scoreExist(intStudentId, intCourseId))
            {
                if (score.insertScore(intStudentId, intCourseId, doubleScore, description))
                {
                    MessageBox.Show("Score successfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
                else
                    MessageBox.Show("Error, Score adding failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed, Student id and Score should be a valid number. \nDouble scores are now allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            showStudentTable();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            
            textBox_score.Clear();
            textBox_scoreDescription.Clear();
            textBox_studentId.Clear();
            comboBox_selectCourse.SelectedItem = null;

            if (button_ShowScoreBack.Text == "<<Back")
                button_ShowScoreBack.PerformClick();
        }
    }
}
