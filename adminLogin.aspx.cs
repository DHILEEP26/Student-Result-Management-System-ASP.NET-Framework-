using Students_Record_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Record_Management_System
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBClass dBClass = new DBClass();
                int getAdmin = 0;
                var parems = new string[4];
                parems[0]=TextBox1.Text.Trim();
                parems[1]=TextBox2.Text.Trim();
                parems[2]="1";
                parems[3]="1";
                var errorMessage = "";
                if (dBClass.GetData(ref getAdmin, "SP_GET_ADMIN", parems, ref errorMessage))
                {
                    if (getAdmin>=1)
                    {
                        string script = "alert('You Successfully LogedIn.');";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                        Session["UserRoll"]="Admin";
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {

                        string script = "alert('UserName or Password Incorrect.');";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                    }
                }
                else
                {
                    string script = errorMessage;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                }
            
        }

    }
}