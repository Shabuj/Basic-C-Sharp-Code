using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInformationUi
{
    public partial class StudentListUi : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Student> studentList = new List<Student>();
            Student student = new Student();
            student.FirstName = firstName.Text;
            student.LastName = lastName.Text;
            student.UserName = userName.Text;
            student.RegNo = regNo.Text;
            student.Email = email.Text;
            student.Age = Convert.ToInt32(age.Text);
            
           
            if (ViewState["AllStudent"]!=null)
            {
                studentList = (List<Student>)ViewState["AllStudent"];
            }
            studentList.Add(student);
            ViewState["AllStudent"] = studentList;
            clearTextBox();
            message.Text = String.Empty;
            message.Text = "Student Info Saved";
            message.ForeColor = Color.Green;


        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            nameList.Items.Clear();
            List<Student> viewStudent = new List<Student>();
            viewStudent = (List<Student>)ViewState["AllStudent"];
            if(viewStudent!=null)
            {
                foreach (Student data in viewStudent)
                {
                   
                    nameList.Items.Add(item: "First Name :"+ data.FirstName);
                    nameList.Items.Add(item: "Last Name :"+  data.LastName);
                    nameList.Items.Add(item: "User Name:"+   data.UserName);
                    nameList.Items.Add(item: "Reg No:" + data.RegNo);
                    nameList.Items.Add(item: "Email:" + data.Email);
                    nameList.Items.Add(item: "Age:" + data.Age);
                    nameList.Items.Add(item: "Full Name:" + data.GetFullName());
                    nameList.Items.Add(item: " ");

                }
            }
            else
            {
                message.Text = String.Empty;
                message.Text = "Student Info Empty";
                message.ForeColor = Color.Red;
            }
        }
        private void clearTextBox()
        {
            firstName.Text = String.Empty;
            lastName.Text = String.Empty;
            userName.Text = String.Empty;
            regNo.Text = String.Empty;
            email.Text = String.Empty;
            age.Text = String.Empty;
        }
    }
}