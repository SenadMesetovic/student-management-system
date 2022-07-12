using MySql.Data.MySqlClient;
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
    public enum enumForms
    {
        registerForm,
        manageStudentForm
    }
    public partial class StudentDocumentsForm : Form
    {
        private string browseFileName;
        private int _studentId;
        string _firstName;
        string _lastName;
        private string pdfFileName;
        enumForms _enumf;
        StudentClass student = new StudentClass();
        Pdf_PreviewForm previewForm;
        public StudentDocumentsForm(int studentId, enumForms forms)
        {
            InitializeComponent();
            _studentId = studentId;
            _enumf = forms;
        }
        private void StudentDocumentsForm_Load(object sender, EventArgs e)
        {
            //label_studentscore.Text = "Score list for " + DataGridView_Student.CurrentRow.Cells[1].Value.ToString() + " " + DataGridView_Student.CurrentRow.Cells[2].Value.ToString() + ", Student Id: " + DataGridView_Student.CurrentRow.Cells[0].Value.ToString();
            DataTable dataTable1 = student.getList(new MySqlCommand("SELECT StudentFirstName, StudentLastName FROM student WHERE StudentId = "+ _studentId));
            //DataColumn column = new DataColumn("StudentFirstName");
                _firstName = dataTable1.Rows[0][0].ToString();
                _lastName = dataTable1.Rows[0][1].ToString();
                label_title.Text = "Manage documents for " + _firstName + " " + _lastName + ", Id: " + _studentId;
            ShowTable();

            DataTable dataTable = student.getList(new MySqlCommand("SELECT DISTINCT fileName FROM files"));
            foreach (DataRow row in dataTable.Rows)
            {
                comboBox_documentName.Items.Add(row[0].ToString());
            }


        }
        

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo or PDF file (*.jpg;*.png;*.gif; *.pdf)|*.jpg;*.png;*.gif; *.pdf;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                browseFileName = opf.FileName;
                label_fileUploaded.Text = "File: " + browseFileName.Substring(0,20)+ "...";
            }
        }

        private void label_fileUploaded_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("File path: " + browseFileName, label_fileUploaded);
        }

        
        private void ShowTable()
        {
            DataGridView_files.DataSource = student.getList(new MySqlCommand("SELECT fileId, fileName, fileDescription FROM files WHERE studentId = "+_studentId));
        }
           


        

        private void button_add_click(object sender, EventArgs e)
        {
            //add new student
            string docName = comboBox_documentName.Text;
            string docDesc = textBox_documentDescription.Text;
            byte [] rawdata= File.ReadAllBytes(browseFileName);

            if (string.IsNullOrWhiteSpace(docName) && string.IsNullOrWhiteSpace(browseFileName))
                MessageBox.Show("Invalid input, missing file name or path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (student.insertStudentDocuments(_studentId, docName, docDesc, rawdata))
                    {
                        ShowTable();
                        MessageBox.Show("File has been successfully uploaded to database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Problem with database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ShowTable();
        }

        private void DataGridView_files_Click(object sender, EventArgs e)
        {

            //byte[] img = (byte[])DataGridView_student.CurrentRow.Cells[7].Value;
            //MemoryStream ms = new MemoryStream(img);
            //pictureBox_student.Image = Image.FromStream(ms);

            //byte[] rawdata = File.ReadAllBytes(browseFileName);
            //string filename = Path.GetTempFileName() + ".pdf";
            //MessageBox.Show(filename);
            //File.WriteAllBytes(filename, rawdata);
            //axAcroPDF1.LoadFile(filename);
            //File.Delete(filename);

            int selectedFileId = Convert.ToInt32( DataGridView_files.CurrentRow.Cells[0].Value.ToString());
            string strcmd = "SELECT fileDoc FROM files WHERE fileId =" + selectedFileId;
            DataTable table = student.getList(new MySqlCommand(strcmd));
            byte[] rawPdf = (byte[])table.Rows[0][0];
            string filename = Path.GetTempFileName() + ".pdf";
            pdfFileName = filename;
            File.WriteAllBytes(filename, rawPdf);
            //axAcroPDF1.LoadFile(filename);
            if (checkBox_showPreview.Checked==true && previewForm.Enabled==true)
            {
                previewForm.refreshForm(filename);
            }
            //File.Delete(filename);

        }

        private void checkBox_showPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showPreview.Checked == true)
            {
                previewForm=new Pdf_PreviewForm();
                previewForm.Show();
                if (DataGridView_files.SelectedRows.Count != 0)
                    previewForm.refreshForm(pdfFileName);
            }
            else
                previewForm.Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int fileId = Convert.ToInt32(DataGridView_files.CurrentRow.Cells[0].Value);
            string question = "Do you want to delete selected file?";
            DialogResult dialogResult = MessageBox.Show(question, "Delete document", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            if (dialogResult == DialogResult.Yes && student.deleteFile(fileId))
            {
                MessageBox.Show("Score successfully deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //button_clear.PerformClick();
            }
            else
                MessageBox.Show("Error, Score deleting failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ShowTable();
        }

        private void button_Back_Click_1(object sender, EventArgs e)
        {
            MainForm form1;
            form1 = (MainForm)Application.OpenForms["MainForm"];
            switch (_enumf)
            {
                case enumForms.registerForm:
                    form1.openChildForm(new RegisterForm());
                    break;

                case enumForms.manageStudentForm:
                    form1.openChildForm(new ManageStudentForm());
                    break;
            }
            
        }
    }
}
