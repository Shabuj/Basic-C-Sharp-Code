using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationUi
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.FirstName = firstName.Text;
            student.LastName = lastName.Text;
            student.UserName = userName.Text;
            student.RegNo = regNo.Text;
            student.Email = email.Text;
            student.Age = Convert.ToInt32(age.Text);
            ViewState["Student"] = student;
            clearTextBox();
            message.Text = String.Empty;
            message.Text = "Student Info Saved";
            message.ForeColor = Color.Green;

        }

        private void clearTextBox()
        {
            firstName.Text =String.Empty;
            lastName.Text = String.Empty;
            userName.Text = String.Empty;
            regNo.Text    = String.Empty;
            email.Text    = String.Empty;
            age.Text      = String.Empty;
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            Student ViewStudent = new Student();
            ViewStudent = (Student)ViewState["Student"];
            if(ViewStudent!=null)
            {
                firstNameLavel.Text = ViewStudent.FirstName;
                lastNameLavel.Text = ViewStudent.LastName;
                userNameLavel.Text = ViewStudent.UserName;
                regNoLavel.Text = ViewStudent.RegNo;
                emailLavel.Text = ViewStudent.Email;
                ageLavel.Text = ViewStudent.Age.ToString();
            }
            else
            {
                message.Text = String.Empty;
                message.Text = "Student Info Not Found";
                message.ForeColor = Color.Red;
            }
        
        }

        protected void nextButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(url:"StudentListUi.aspx");
        }
    }
}