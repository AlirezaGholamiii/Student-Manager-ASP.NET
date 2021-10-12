using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using KasraMidtermPrepration.BLL;

namespace KasraMidtermPrepration.DAL
{
    public class ProjectAssignedDB
    {

        public static void AsssignProject(ProjectAssigned proAs)
        {
            SqlConnection cnnDB = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();


            cmdInsert.CommandText = "INSERT INTO ProjectAssignments (StudentNumber,ProjectCode,AssignedDate,SubmittedDate)" +
                                        "VALUES(@StudentNumber,@ProjectCode,@AssignedDate,@SubmittedDate)";
            cmdInsert.Parameters.AddWithValue("@StudentNumber", proAs.studentId);
            cmdInsert.Parameters.AddWithValue("@ProjectCode", proAs.code);
            cmdInsert.Parameters.AddWithValue("@AssignedDate", proAs.assignedDate);
            cmdInsert.Parameters.AddWithValue("@SubmittedDate", proAs.sumitDate);

            cmdInsert.Connection = cnnDB;
            cmdInsert.ExecuteNonQuery();
            cnnDB.Close();
            cnnDB.Dispose();



        }





        public static List<ProjectAssigned> listAllProjectAssigned()
        {


            List<ProjectAssigned> projAssignedList = new List<ProjectAssigned>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from ProjectAssignments", con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                ProjectAssigned projAssigned;

                while (sqlreadRecord.Read())
                {
                    projAssigned = new ProjectAssigned();

                    projAssigned.studentId = Convert.ToInt32(sqlreadRecord["StudentNumber"]);
                    projAssigned.code = sqlreadRecord["ProjectCode"].ToString();
                    projAssigned.assignedDate = sqlreadRecord["AssignedDate"].ToString();
                    projAssigned.sumitDate = sqlreadRecord["SubmittedDate"].ToString();

                    projAssignedList.Add(projAssigned);


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


            return projAssignedList;

        }



        public static List<ProjectAssigned> FindAllProjectsForStudent(int id)
        {


            List<ProjectAssigned> projAssignedList = new List<ProjectAssigned>();
            SqlConnection con = UtilityDB.ConnectDB();

            try
            {
                SqlCommand cmdListRecord = new SqlCommand("select * from ProjectAssignments where StudentNumber=" + id , con);
                SqlDataReader sqlreadRecord = cmdListRecord.ExecuteReader();

                ProjectAssigned projAssigned;

                while (sqlreadRecord.Read())
                {
                    projAssigned = new ProjectAssigned();

                    projAssigned.studentId = Convert.ToInt32(sqlreadRecord["StudentNumber"]);
                    projAssigned.code = sqlreadRecord["ProjectCode"].ToString();
                    projAssigned.assignedDate = sqlreadRecord["AssignedDate"].ToString();
                    projAssigned.sumitDate = sqlreadRecord["SubmittedDate"].ToString();

                    projAssignedList.Add(projAssigned);


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


            return projAssignedList;

        }
    }


   
}