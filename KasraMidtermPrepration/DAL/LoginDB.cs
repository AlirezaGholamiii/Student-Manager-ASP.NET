using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KasraMidtermPrepration.BLL;
using System.Data.SqlClient;
namespace KasraMidtermPrepration.DAL
{
    public class LoginDB
    {



        public static Student loginForStudent(int studentID, string pass)
        {


            Student studList = new Student();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from Students where StudentNumber="+  studentID + "AND Password=" + "'"+pass+"'", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                Student stud;

                while (sqlreadRecord.Read())
                {
                    stud = new Student();
                    stud.ID = Convert.ToInt32(sqlreadRecord["StudentNumber"]);
                    stud.fName = sqlreadRecord["FirstName"].ToString();
                    stud.lName = sqlreadRecord["LastName"].ToString();
                    stud.password = sqlreadRecord["Password"].ToString();
                    return stud;


                }


            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }


            return studList;

        }



        public static Teacher loginForTeacher(int teacherID, string pass)
        {


            Teacher teachList = new Teacher();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from Teachers where TeacherNumber="+ teacherID + "AND Password=" + "'" + pass + "'", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                Teacher teach;

                while (sqlreadRecord.Read())
                {
                    teach = new Teacher();
                    teach.ID = Convert.ToInt32(sqlreadRecord["TeacherNumber"]);
                    teach.fName = sqlreadRecord["FirstName"].ToString();
                    teach.lName = sqlreadRecord["LastName"].ToString();
                    teach.password = sqlreadRecord["Password"].ToString();

                    return teach;


                }


            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }


            return teachList;

        }
    }
}