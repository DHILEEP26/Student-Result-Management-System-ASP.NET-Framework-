using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Record_Management_System
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserRoll"] == null || string.IsNullOrEmpty(Session["UserRoll"].ToString()))
                {
                    LinkButton4.Visible = true; // Admin login
                    LinkButton2.Visible = true; // User login
                    LinkButton3.Visible = false; // Logout
                    LinkButton5.Visible = false; // User
                    LinkButton1.Visible = false; // Admin work
                    LinkButton6.Visible = false; //DashBoard
                }
                else if (Session["UserRoll"].ToString() == "Admin")
                {
                    LinkButton4.Visible = false; // Admin login
                    LinkButton2.Visible = false; // User login
                    LinkButton3.Visible = true; // Logout
                    LinkButton5.Visible = false; // User
                    LinkButton1.Visible = true; // Admin work
                    LinkButton6.Visible = true; //DashBoard
                }
                else
                {
                    LinkButton4.Visible = false; // Admin login
                    LinkButton2.Visible = false; // User login
                    LinkButton3.Visible = true; // Logout
                    LinkButton5.Visible = true; // User
                    StudentName.Text=Session["Username"].ToString();
                    LinkButton1.Visible = false; // Admin work
                    LinkButton6.Visible = false; //DashBoard
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("userLogin.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["UserRoll"]=String.Empty;
            Session["Password"]=String.Empty;
            Response.Redirect("Default.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("About.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminWork.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userSignup.aspx");
        }
    }
}