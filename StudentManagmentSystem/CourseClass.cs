using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class CourseClass
    {
        DBconnect connect = new DBconnect();

        public bool insertCourse(string courseName, int courseHour, string courseDescription)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO course (coursename, coursehour, coursedescription) VALUES (@cname, @chour, @cdesc)", connect.getconnection);
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value = courseName;
            command.Parameters.Add("@chour", MySqlDbType.Int32).Value = courseHour;
            command.Parameters.Add("@cdesc", MySqlDbType.Text).Value = courseDescription;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getCourseTable()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable searchCourse(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM course WHERE CONCAT(CourseName, CourseHour, CourseDescription) LIKE '%" + searchData + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool updateCourse (int courseId, string courseName, int courseHour, string courseDescription)
        {
            MySqlCommand command = new MySqlCommand("UPDATE course SET CourseName = @cname, CourseHour = @chour, CourseDescription = @cdesc WHERE CourseId=@cid", connect.getconnection);
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value=courseId;
            command.Parameters.Add("@cname", MySqlDbType.VarChar).Value=courseName;
            command.Parameters.Add("@chour", MySqlDbType.VarChar).Value = courseHour;
            command.Parameters.Add("@cdesc", MySqlDbType.VarChar).Value = courseDescription;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool deleteCourse (int courseId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM course WHERE courseId=@cid", connect.getconnection);
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value=courseId;
            connect.openConnect();
            
            
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

    }
}
