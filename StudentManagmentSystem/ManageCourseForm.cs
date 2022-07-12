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
    public partial class ManageCourseForm : Form
    {
        CourseClass course = new CourseClass();
        ScoreClass score = new ScoreClass();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            DataGridView_course.DataSource = course.getCourseTable();
            textBox_search.Clear();
        }

        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            textBox_courseId.Text = DataGridView_course.CurrentRow.Cells[0].Value.ToString();
            textBox_CourseName.Text = DataGridView_course.CurrentRow.Cells[1].Value.ToString();
            textBox_CourseHour.Text = DataGridView_course.CurrentRow.Cells[2].Value.ToString();
            textBox_CourseDescription.Text = DataGridView_course.CurrentRow.Cells[3].Value.ToString();

        }



        private void textBox_search_KeyUp(object sender, KeyEventArgs e)
        {
            DataGridView_course.DataSource = course.searchCourse(textBox_search.Text);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_CourseName.Clear();
            textBox_CourseHour.Clear();
            textBox_CourseDescription.Clear();
            textBox_courseId.Clear();
            showTable();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string id = textBox_courseId.Text;
            string name = textBox_CourseName.Text;
            string hour = textBox_CourseHour.Text;
            string description = textBox_CourseDescription.Text;
            if (!string.IsNullOrWhiteSpace(name) && int.TryParse(hour, out int intHour) && int.TryParse(id, out int intId))
            {
                if (course.updateCourse(intId, name, intHour, description))
                    MessageBox.Show("Course successfully updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error, course updating failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty fields are not allowed, hour and id fields should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showTable();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(textBox_courseId.Text);
            string question = "Are you sure that you really want to delete course with \n Id: " + DataGridView_course.CurrentRow.Cells[0].Value.ToString() + "\n Course Name: " + DataGridView_course.CurrentRow.Cells[1].Value.ToString();
            DialogResult dialogResult = MessageBox.Show(question, "Delete Course", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (course.deleteCourse(Convert.ToInt32(DataGridView_course.CurrentRow.Cells[0].Value.ToString())) == true)
                {
                    MessageBox.Show("Course has been succesfully deleted.", "Info", MessageBoxButtons.OK);
                    score.deleteScoreByCourseId(courseId);
                }
                else
                    MessageBox.Show("Error, course with given id desn't exist in database.", "Error", MessageBoxButtons.OK);
            }
            else if (dialogResult == DialogResult.No)
            {
                //exit
            }
            button_clear.PerformClick();
        }

    }  
}
