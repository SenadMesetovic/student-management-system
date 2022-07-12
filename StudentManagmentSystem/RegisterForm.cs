using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagmentSystem
{
    public partial class RegisterForm : Form
    {
        StudentClass student = new StudentClass();

        private int _currentStudentId;
        public int CurrentStudentId
        {
            get { return _currentStudentId; }
        }

        public RegisterForm()
        {
            InitializeComponent();
        }

        //create a function to verify
        bool verify()
        {
            if ((textBox_FirstName.Text=="")|| (textBox_LastName.Text=="") || (textBox_Phone.Text=="") || (textBox_Adress.Text=="") || (pictureBox_student.Image==null))
            {
                return false;
            }
            else
                return true;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            showTable();
            button_pdfDoc.Enabled = false;
        }
        // To show student list in DataGridView
        public void showTable()
        {
            DataGridView_student.DataSource = student.getStudentlist();
            //DataGridView_student.RowTemplate.Height = 80;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_student.Image = Image.FromFile(opf.FileName);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            
                //add new student
                string fname = textBox_FirstName.Text;
                string lname = textBox_LastName.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBox_Phone.Text;
                string address = textBox_Adress.Text;
                string gender = radioButton_male.Checked ? "Male" : "Female";



                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                    MessageBox.Show("The student age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (verify())
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                        byte[] img = ms.ToArray();
                        if (student.insertStudent(fname, lname, bdate, gender, phone, address, img))
                        {
                            showTable();
                            MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_Phone.Clear();
            textBox_Adress.Clear();
            radioButton_male.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBox_student.Image = null;
            button_pdfDoc.Enabled = false;
            DataGridView_student.ClearSelection();
        }

        private void button_pdfDoc_Click(object sender, EventArgs e)
        {
            Form form = new StudentDocumentsForm(_currentStudentId, enumForms.registerForm);
            MainForm form1;
            form1 = (MainForm)Application.OpenForms["MainForm"];
            form1.openChildForm(form);

        }

        private void DataGridView_student_Click(object sender, EventArgs e)
        {
            //textBox_FirstName.Text = DataGridView_student.CurrentRow.Cells[1].Value.ToString();
            //textBox_LastName.Text = DataGridView_student.CurrentRow.Cells[2].Value.ToString();
            //dateTimePicker1.Value = (DateTime)DataGridView_student.CurrentRow.Cells[3].Value;
            //if (DataGridView_student.CurrentRow.Cells[4].Value.ToString() == "Male")
            //    radioButton_male.Checked = true;
            //else
            //    radioButton_female.Checked = true;

            //textBox_Phone.Text = DataGridView_student.CurrentRow.Cells[5].Value.ToString();
            //textBox_Adress.Text = DataGridView_student.CurrentRow.Cells[6].Value.ToString();
            //byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[7].Value;
            //MemoryStream ms = new MemoryStream(img);
            //pictureBox_student.Image = Image.FromStream(ms);
            _currentStudentId = Convert.ToInt32(DataGridView_student.CurrentRow.Cells[0].Value.ToString ());
            button_pdfDoc.Enabled = true;
        }
    }
}
