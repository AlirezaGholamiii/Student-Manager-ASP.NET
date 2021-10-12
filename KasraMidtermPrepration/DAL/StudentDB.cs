using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KasraMidtermPrepration.BLL;
using System.Data.SqlClient;

namespace KasraMidtermPrepration.DAL
{
    public class StudentDB
    {

        public static List<Student> listAllStudents()
        {


            List<Student> studList = new List<Student>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from Students", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                Student stud;

                while (sqlreadRecord.Read())
                {
                    stud = new Student();
                    stud.ID = Convert.ToInt32(sqlreadRecord["StudentNumber"]);
                    stud.fName = sqlreadRecord["FirstName"].ToString();
                    stud.lName = sqlreadRecord["LastName"].ToString();
                    stud.password = sqlreadRecord["Password"].ToString();
                    studList.Add(stud);


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



        public static Student FindStudents(int id)
        {


            Student studList = new Student();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from Students where StudentNumber=" + id, con);
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
    }
}