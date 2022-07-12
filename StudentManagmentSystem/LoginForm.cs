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
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable table = student.getList( new MySqlCommand("SELECT * FROM user WHERE username ='" + username + "' AND password = '" + password + "'"));

            if (table.Rows.Count>0)
            {
                MainForm main = new MainForm();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
