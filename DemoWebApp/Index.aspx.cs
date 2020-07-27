using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebApp
{
    public partial class Index : System.Web.UI.Page
    {
        //private string name;
        List<string> listName = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void addButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            if (ViewState["Name"]!=null)
            {
                listName =(List<string>)ViewState["Name"];
            }
            listName.Add(name);
            ViewState["Name"] = listName;

        }
        protected void showButton_Click(object sender, EventArgs e)
        {
            listName = (List<string>)ViewState["Name"];
            foreach (var data in listName)
            {
                nameListBox.Items.Add(data);
            }
            
           // showLabel.Text = ViewState["Name"].ToString();
            //ViewState["Name"] = name;
            //showLabel.Text = ViewState["Name"].ToString;

        }


    }
}