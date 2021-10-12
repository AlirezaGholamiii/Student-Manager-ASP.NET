using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KasraMidtermPrepration.BLL;
using KasraMidtermPrepration.DAL;
using System.Data;
using System.Windows.Forms;

namespace KasraMidtermPrepration.GUL
{
    public partial class WebFormStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud = StudentDB.FindStudents(Login.UserID);

            ProjectAssigned prj = new ProjectAssigned();

            List<ProjectAssigned>  listprj = new List<ProjectAssigned>();

            listprj = ProjectAssignedDB.FindAllProjectsForStudent(stud.ID);

            listprj.Add(prj);

            lblName.Text = "Welcome " + stud.fName;

            

            if (prj != null)
            {
                GridViewStudentAssignment.DataSource = listprj;
                GridViewStudentAssignment.DataBind();

            }
            else
            {
                MessageBox.Show("There is no project.");
            }

            

           






           
            

            


        }
    }
}