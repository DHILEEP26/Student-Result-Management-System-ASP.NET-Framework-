using Students_Record_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Record_Management_System
{
    public partial class userSignup : System.Web.UI.Page
    {
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-OF5DRCJC\\SQLEXPRESS;Initial Catalog=Training_db;Integrated Security=True;Encrypt=False");
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text.Trim()!=TextBox3.Text.Trim())
            {
                string script = "alert('Passwords do not match.');";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
            else
            { 
                DBClass dBClass = new DBClass();
                int check_user = 0;
                var parames = new string[3];
                parames[0]=TextBox1.Text.Trim();
                parames[1]="1";
                parames[2]="1";
                var errorMessage = "";
                if(dBClass.GetData(ref check_user, "SP_GET_REG", parames,ref errorMessage)) 
                {
                   if (check_user>=1)
                    {
                        string script = "alert('This Student_ID is already Present.');";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                    }
                    else
                    {
                        DBClass dBClass1 = new DBClass();
                        int check_student_Id = 0;
                        var parems = new string[3];
                        parems[0] = TextBox1.Text.Trim();
                        parems[1]="1";
                        parems[2]="1";
                        var errorMessageforcheck = "";
                        if (dBClass1.GetData(ref check_student_Id, "SP_GET_ST_ID", parems, ref errorMessageforcheck))
                        {
                            if (check_student_Id>0)
                            {

                                DBClass dBClass2 = new DBClass();
                                var returnOutValue = "";
                                var errorMessageSave = "";
                                var Parameters = new object[5];
                                Parameters[0]=TextBox1.Text.Trim();
                                Parameters[1]=TextBox2.Text.Trim();
                                Parameters[2]=FileUpload1.FileBytes;
                                Parameters[3]="1";
                                Parameters[4]="1";
                                if (dBClass1.SaveData("SP_Student_Reg", Parameters, ref returnOutValue, ref errorMessageSave))
                                {
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Successfuly Registered'); window.location.href = window.location.href;", true);

                                }
                                else
                                {
                                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessageSave}'); window.location.href = window.location.href;", true);
                                }

                            }
                            else
                            {
                                string script = "alert('Student Id is Invalid');";
                                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                            }
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessageforcheck}'); window.location.href = window.location.href;", true);
                        }


                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessage}'); window.location.href = window.location.href;", true);
                }
            }
        }
    }
}