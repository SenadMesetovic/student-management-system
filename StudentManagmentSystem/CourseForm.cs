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
    public partial class CourseForm : Form
    {
        CourseClass course = new CourseClass();
        public CourseForm()
        {
            InitializeComponent();
            showTable();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string name = textBox_CourseName.Text;
            string hour = textBox_CourseHour.Text;
            string description = textBox_CourseDescription.Text;
            if (!string.IsNullOrWhiteSpace(name) && int.TryParse(hour, out int intHour) )
            {
                if (course.insertCourse(name, intHour, description))
                {
                    MessageBox.Show("Course successfully added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
                else
                    MessageBox.Show("Error, course adding failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Empty fields are not allowed, hour field should be a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            showTable();
            

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_CourseDescription.Clear();
            textBox_CourseHour.Clear();
            textBox_CourseName.Clear();
        }
        private void showTable()
        {
            DataGridView_course.DataSource = course.getCourseTable();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
