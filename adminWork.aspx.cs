using Students_Record_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Record_Management_System
{
    public partial class adminWork : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Session["UserRoll"]==null || Session["UserRoll"].ToString()!="Admin")
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    LoadData();
                }
            }
           

        }
        private void LoadData()
        {
            DBClass dbClass = new DBClass();
            DataSet dataSet = new DataSet();
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            if (dbClass.GetTableData(ref dataSet, "SP_GET_STUDENT_LIST", parems, ref errorMessage))
            {
                GridView1.DataSource=dataSet.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessage}'); window.location.href = window.location.href;", true);
            }
        }
        protected void GVStudentList_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selectedRow = GridView1.SelectedRow;
            if (selectedRow != null)
            {
                StudentId.Text = selectedRow.Cells[0].Text.Trim();
                StudentName.Text = selectedRow.Cells[1].Text.Trim();
                TamilMark.Text = selectedRow.Cells[2].Text.Trim();
                EnglishMark.Text = selectedRow.Cells[3].Text.Trim();
                MathsMark.Text = selectedRow.Cells[4].Text.Trim();
                ScienceMark.Text = selectedRow.Cells[5].Text.Trim();
                SocialMark.Text = selectedRow.Cells[6].Text.Trim();
            }
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            DBClass dBClass = new DBClass();
            int check_student_Id = 0;
            var parems = new string[3];
            parems[0] = StudentId.Text.Trim();
            parems[1]="1";
            parems[2]="1";
            var errorMessage = "";
            if (dBClass.GetData(ref check_student_Id, "SP_GET_ST_ID", parems, ref errorMessage))
            {
                if (check_student_Id>0)
                {
                    string script = "alert('Student ID is already present.');";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
                }
                else
                {
                    DBClass dBClass1 = new DBClass();
                    var parameters=new object[9];
                    parameters[0]=StudentId.Text.Trim();
                    parameters[1]=StudentName.Text.Trim();
                    parameters[2]=int.Parse(TamilMark.Text.Trim());
                    parameters[3]=int.Parse(EnglishMark.Text.Trim());
                    parameters[4]=int.Parse(MathsMark.Text.Trim());
                    parameters[5]=int.Parse(ScienceMark.Text.Trim());
                    parameters[6]=int.Parse(SocialMark.Text.Trim());
                    parameters[7]="1";
                    parameters[8]="1";
                    var returnOutValue = "";
                    var returnMessage = "";
                    if(dBClass1.SaveData("SP_SAV_ST", parameters, ref returnOutValue, ref returnMessage))
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{returnOutValue}'); window.location.href = window.location.href;", true);

                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{returnMessage}'); window.location.href = window.location.href;", true);
                    }
                }
            }
            else
            {
                string script = $"alert('{errorMessage}')";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
        }

        private void clearMethod()
        {
            StudentId.Text = string.Empty;
            StudentName.Text = string.Empty;
            TamilMark.Text = string.Empty;
            EnglishMark.Text = string.Empty;
            MathsMark.Text = string.Empty;
            ScienceMark.Text = string.Empty;
            SocialMark.Text = string.Empty;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            clearMethod();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DBClass dBClass = new DBClass();
            var parameters = new object[9];
            parameters[0]=StudentId.Text.Trim();
            parameters[1]=StudentName.Text.Trim();
            parameters[2]=int.Parse(TamilMark.Text.Trim());
            parameters[3]=int.Parse(EnglishMark.Text.Trim());
            parameters[4]=int.Parse(MathsMark.Text.Trim());
            parameters[5]=int.Parse(ScienceMark.Text.Trim());
            parameters[6]=int.Parse(SocialMark.Text.Trim());
            parameters[7]="1";
            parameters[8]="1";  
            var returnOutValue = "";
            var returnMessage = "";
            if (dBClass.SaveData("SP_UP_ST", parameters, ref returnOutValue, ref returnMessage))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Updated Successfully'); window.location.href = window.location.href;", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{returnMessage}'); window.location.href = window.location.href;", true);
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DBClass dBClass = new DBClass();
            var parameters = new object[3];
            parameters[0]=StudentId.Text.Trim();
            parameters[1]="1";
            parameters[2]="1";
            var returnOutValue = "";
            var returnMessage = "";
            if (dBClass.SaveData("SP_DEL_ST", parameters, ref returnOutValue, ref returnMessage))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('Deleted Successfully'); window.location.href = window.location.href;", true);

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{returnMessage}'); window.location.href = window.location.href;", true);
            }

        }
    }
}