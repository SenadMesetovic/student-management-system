using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem
{
    internal class ScoreClass
    {
        DBconnect connect = new DBconnect();


        public DataTable getList(string strCommand)
        {
            MySqlCommand command = new MySqlCommand(strCommand);
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }



        public bool insertScore(int studentId, int courseId,  double score, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO score(StudentId, CourseId, Score, ScoreDescription) VALUES (@stdid, @courseid, @score, @desc)", connect.getconnection);

            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = description;

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

        public bool updateScore(int studentId, int courseId, double score, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE score SET score.Score=@score, score.ScoreDescription = @desc WHERE studentid=@stdid AND courseid=@courseid", connect.getconnection);

           
            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseId;
            command.Parameters.Add("@score", MySqlDbType.Double).Value = score;
            command.Parameters.Add("@desc", MySqlDbType.Text).Value = description;

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

        public bool deleteScoreByStudentId(int studentId )
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM score WHERE score.StudentId=@stdid", connect.getconnection);


            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;

            connect.openConnect();
            if (command.ExecuteNonQuery() > 0)
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
        public bool deleteScoreByCourseId(int courseId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM score WHERE score.CourseId=@courseid", connect.getconnection);


            command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseId;


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

        public bool deleteScore(int studentId, int courseId)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM score WHERE score.StudentId=@stdid AND score.CourseId=@courseid", connect.getconnection);


            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@courseid", MySqlDbType.Int32).Value = courseId;


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

        // Check if score exist, returns true if does and false otherwise
        public bool scoreExist(int studentId)
        {
            MySqlCommand command = new MySqlCommand("SELECT EXISTS(SELECT * FROM score WHERE StudentId = @stdid)", connect.getconnection);

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
                
            // Check if score exist, returns true if does and false otherwise
            public bool scoreExist(int studentId, int courseId)
        {
            MySqlCommand command = new MySqlCommand("SELECT EXISTS(SELECT * FROM score WHERE StudentId = @stdid AND CourseId=@cid)", connect.getconnection);

            command.Parameters.Add("@stdid", MySqlDbType.Int32).Value = studentId;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = courseId;

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
        
    }
}
