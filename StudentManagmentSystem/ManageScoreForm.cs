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
    public partial class ManageScoreForm : Form
    {
        ScoreClass score = new ScoreClass();
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();

        public ManageScoreForm()
        {
            InitializeComponent();
        }

        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            showScoreTable();
            comboBox_selectCourse.DisplayMember = "CourseName";
            comboBox_selectCourse.ValueMember = "CourseId";
            comboBox_selectCourse.DataSource = course.getCourseTable();
            comboBox_selectCourse.SelectedItem = null;

        }
        string strCmdShowTable = "SELECT * FROM (SELECT score.studentId, student.StudentFirstName, student.StudentLastName,  score.CourseId, course.CourseName, score.Score, score.scoreDescription FROM ((score LEFT JOIN course ON score.CourseId = course.CourseId) LEFT JOIN student ON score.studentId = student.StudentId)) AS newtable ";

        public void showScoreTable()
        {
            DataGridView_score.DataSource = score.getList(strCmdShowTable);

        }

        private void DataGridView_score_Click(object sender, EventArgs e)
        {
            textBox_studentId.Text=DataGridView_score.CurrentRow.Cells[0].Value.ToString();
            int selectedIndex = comboBox_selectCourse.FindString(DataGridView_score.CurrentRow.Cells[4].Value.ToString());
            comboBox_selectCourse.SelectedIndex=selectedIndex;
            textBox_score.Text=DataGridView_score.CurrentRow.Cells[5].Value.ToString();
            textBox_scoreDescription.Text = DataGridView_score.CurrentRow.Cells[6].Value.ToString();


        }

        private void button_update_Click(object sender, EventArgs e)
        {
            
            string studentId = textBox_studentId.Text;
            string sc = textBox_score.Text;
            string description = textBox_scoreDescription.Text;

            if (double.TryParse(sc, out double doubleScore) && int.TryParse(studentId, out int intStudentId) && comboBox_selectCourse.SelectedItem!=null && int.TryParse(comboBox_selectCourse.SelectedValue.ToString(), out int intCourseId))
            {
                if (score.updateScore(intStudentId, intCourseId, doubleScore, description))
                {
                    MessageBox.Show("Score has been successfully updated","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
                else
                    MessageBox.Show("Error, Score updating failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Valid input required, empty fields are not allowed, score field should be a number.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            showScoreTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {

            string studentId = textBox_studentId.Text;
            if (int.TryParse(studentId, out int intStudentId) && comboBox_selectCourse.SelectedItem != null && int.TryParse(comboBox_selectCourse.SelectedValue.ToString(), out int intCourseId) && score.deleteScore(intStudentId, intCourseId))
            {
                MessageBox.Show("Score successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button_clear.PerformClick();
            }
            else
                MessageBox.Show("Error, Score deleting failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showScoreTable();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string searchData = textBox_search.Text;
            string strCommand = "SELECT * FROM (" + strCmdShowTable + ") AS newtable1 WHERE CONCAT(StudentFirstName,StudentLastName, CourseName, Score, StudentId, CourseId) LIKE '%" + searchData + "%'";
            DataGridView_score.DataSource = score.getList(strCommand);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_score.Clear();
            textBox_scoreDescription.Clear();
            textBox_search.Clear();
            textBox_studentId.Clear();
            comboBox_selectCourse.SelectedItem = null;
            //comboBox_selectCourse.SelectedText = "Select Course";
            
        }

        
    }    
}
