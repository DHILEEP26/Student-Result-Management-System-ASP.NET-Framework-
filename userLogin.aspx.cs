using Students_Record_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Students_Record_Management_System
{
    public partial class userLogin : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-OF5DRCJC\\SQLEXPRESS;Initial Catalog=Training_db;Integrated Security=True;Encrypt=False");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand($"SP_Login_User", connect);
                    cmd.CommandType= CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Student_Id", SqlDbType.NVarChar).Value=TextBox1.Text.Trim();
                    cmd.Parameters.AddWithValue("@password", SqlDbType.NVarChar).Value=TextBox2.Text.Trim();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count >=1)
                    {
                        Session["UserRoll"]=TextBox1.Text.Trim();
                        DBClass dBClass = new DBClass();
                        string name = "";
                        var parameter = new string[3];
                        parameter[0] =TextBox1.Text.Trim();
                        parameter[1]="1";
                        parameter[2]="1";
                        var errormessage = "";
                        if(dBClass.GetString(ref name,"SP_GET_NAME",parameter,ref errormessage))
                        {
                            Session["Username"]=name;
                            string script = "alert('You Successfully LogedIn.');";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                            Response.Redirect("Default.aspx");
                        }
                        else
                        {
                            string script = errormessage;
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                        }
                        


                    }
                    else
                    {
                        string script = "alert('UserName or Password Incorrect.');";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('"+ex.Message+"');</script>");
                }
                finally
                {
                    connect.Close();
                }
            }

        }
    }
}