using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KasraMidtermPrepration.BLL;
using System.Data.SqlClient;


namespace KasraMidtermPrepration.DAL
{
    public class TeacherDB
    {

        public static List<Teacher> listAllTeachers()
        {


            List<Teacher> teachList = new List<Teacher>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from Teachers", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                Teacher teach;

                while (sqlreadRecord.Read())
                {
                    teach = new Teacher();
                    teach.ID = Convert.ToInt32(sqlreadRecord["TeacherNumber"]);
                    teach.fName = sqlreadRecord["FirstName"].ToString();
                    teach.lName = sqlreadRecord["LastName"].ToString();
                    teach.password = sqlreadRecord["Password"].ToString();
                    teachList.Add(teach);


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