using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace StudentManagmentSystem
{
    class StudentClass
    {
        DBconnect connect = new DBconnect();
        //create a function to add a new students to the database

        public bool insertStudent (string firstName, string lastName, DateTime birthDate, string gender, string phone, string adress, byte[] img )
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO student(StudentFirstName, StudentLastName, StudentBirthDate, StudentGender, StudentPhone, StudentAdress, StudentPhoto) VALUES (@fn, @ln, @bd, @gd, @ph, @adr, @img)", connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

            connect.openConnect();
            if (command.ExecuteNonQuery()==1)
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

        public bool insertStudentDocuments(int studentId, string fileName, string fileDescription, byte[] fileDoc)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO files(studentId, fileName, fileDescription, fileDoc) VALUES (@stdid, @fn, @fd, @fdoc)", connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fileName;
            command.Parameters.Add("@fd", MySqlDbType.VarChar).Value = fileDescription;
            command.Parameters.Add("@fdoc", MySqlDbType.MediumBlob).Value = fileDoc;

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
        //to get student table
        public DataTable getStudentlist()
        {
            MySqlCommand command=new MySqlCommand("SELECT * FROM studentdb.student;",connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentBasicList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM studentdb.student;", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            DataTable table1 = new DataTable();
            adapter.Fill(table);
            table1.Columns.Add(table.Columns[0]);
            table1.Columns.Add(table.Columns[1]);
            table1.Columns.Add(table.Columns[2]);
            table1.Columns.Add(table.Columns[3]);


            return table1;
        }

        public string exeCount (string query)
        {
            MySqlCommand command = new MySqlCommand(query,connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student");
        }
        public string maleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE StudentGender='Male'");
        }

        public string femaleStudent()
        {
            return exeCount("SELECT COUNT(*) FROM student WHERE StudentGender='Female'");
        }

        //create a function for student search
        public DataTable searchStudent(string searchData)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM student WHERE concat(StudentFirstName, StudentLastName, StudentAdress) LIKE '%" + searchData + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function to update student
        public bool updateStudent(int id, string firstName, string lastName, DateTime birthDate, string gender, string phone, string adress, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE student SET StudentFirstName=@fn, StudentLastName=@ln, StudentBirthDate=@bd, StudentGender = @gd, StudentPhone = @ph, StudentAdress=@adr, StudentPhoto=@img WHERE StudentId = @id", connect.getconnection);

            //@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = firstName;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lastName;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthDate;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = adress;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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

        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM student WHERE StudentId=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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

        public bool deleteFile(int fileId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM files WHERE fileId=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = fileId;

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

        public DataTable getList (MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool studentIdExist(int studentId)
        {
            MySqlCommand command = new MySqlCommand("SELECT EXISTS(SELECT * FROM student WHERE StudentId = @stdid);", connect.getconnection);

            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;



            connect.openConnect();
            //command.ExecuteNonQuery();
            MySqlDataReader reader = command.ExecuteReader();
            bool result = false;
            reader.Read();
            result = Convert.ToBoolean(reader.GetInt32(0));
            reader.Close();
            connect.closeConnect();
            return result;

        }

        //public byte[] fileDoc (MySqlCommand command)
        //{
        //    command.Connection = connect.getconnection;
        //    connect.openConnect();
            
        //    MySqlDataReader reader = command.ExecuteReader();
        //    reader.Read();
        //    byte[] result = reader.GetBytes();
        //    reader.Close();
        //    connect.closeConnect();
        //    return result;

        //}
    }
}
