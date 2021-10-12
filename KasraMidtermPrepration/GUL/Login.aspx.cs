using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KasraMidtermPrepration.DAL;
using System.Windows.Forms;
using KasraMidtermPrepration.BLL;

namespace KasraMidtermPrepration.GUL
{
    public partial class Login : System.Web.UI.Page
    {

        public static int UserID;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(radioList.SelectedIndex == 0 && txtID.Text != string.Empty && txtPass.Text != string.Empty)
            {
                 Student stu = new Student();
                
                stu = LoginDB.loginForStudent(Convert.ToInt32(txtID.Text), txtPass.Text);

                
                if(stu.fName == null)
                {

                    MessageBox.Show("This Student does not exist!");
                    txtID.Focus();
                    
                }
                else
                {
                    lblFamily.Text = "Welcome " + stu.fName;
                    UserID = stu.ID;
                    Response.Redirect("~/GUL/WebFormStudent.aspx");
                }
                
            }
            else if(radioList.SelectedIndex == 1 && txtID.Text != string.Empty && txtPass.Text != string.Empty)
            {
                Teacher teach = new Teacher();

                teach = LoginDB.loginForTeacher(Convert.ToInt32(txtID.Text), txtPass.Text);


                if (teach.fName == null)
                {
                    MessageBox.Show("This Teacher does not exist!");
                    txtID.Focus();
                    
                }
                else
                {
                    lblFamily.Text = "Welcome Professor " + teach.lName;
                    UserID = teach.ID;
                    Response.Redirect("~/GUL/WebFormTeacher.aspx");
                }

                
            }
            else
            {
                MessageBox.Show("Please compleate all the information");
                txtID.Focus();
            }
        }

     
    }
}