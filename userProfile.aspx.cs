
using Students_Record_Management_System.Common;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Students_Record_Management_System
{
    public partial class userProfile : Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
                DisplayUserProfileImage();
                GetStatus();
                
            }
        }

        private void LoadData()
        {
            DBClass dbClass = new DBClass();
            DataSet dataSet = new DataSet();
            var parems = new string[3];
            parems[0]=Session["UserRoll"].ToString();
            parems[1]="1";
            parems[2]="1";
            var errorMessage = "";
            if (dbClass.GetTableData(ref dataSet, "SP_GET_ST", parems, ref errorMessage))
            {
                StudentName.Text=dataSet.Tables[0].Rows[0]["Student_name"].ToString();
                TotalMarksLabel.Text=dataSet.Tables[0].Rows[0]["Total"].ToString();
                GridView1.DataSource=dataSet.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessage}'); window.location.href = window.location.href;", true);
            }

        }

        private void DisplayUserProfileImage()
        {
            DBClass dBClass = new DBClass();
            Object result=new Object();
            var parems=new string[3];
            parems[0]=Session["UserRoll"].ToString();
            parems[1]="1";
            parems[2]="1";
            var errorMessage = "";
            if(dBClass.GetImage(ref  result,"SP_GET_IMG", parems,ref errorMessage)) 
            {
                if (result != null && result != DBNull.Value)
                {
                    byte[] imageData = (byte[])result;
                    string base64String = Convert.ToBase64String(imageData);
                    UserProfileImage.ImageUrl = "data:image/jpeg;base64," + base64String;
                }
                else
                {

                    UserProfileImage.ImageUrl = "path_to_default_image.jpg";
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessage}'); window.location.href = window.location.href;", true);
            }
        }


        private void GetStatus()
        {

            DBClass dbClass = new DBClass();
            DataSet dataSet = new DataSet();
            var parems = new string[3];
            parems[0]=Session["UserRoll"].ToString();
            parems[1]="1";
            parems[2]="1";
            var errorMessage = "";
            if (dbClass.GetTableData(ref dataSet, "SP_GET_RESULT", parems, ref errorMessage))
            {
                StatusLabel.Text=dataSet.Tables[0].Rows[0]["Result"].ToString();
                gradeLable.Text=dataSet.Tables[0].Rows[0]["Rank"].ToString();
                if (StatusLabel.Text.Trim()=="PASS")
                {
                    StatusLabel.ForeColor=System.Drawing.Color.DarkGreen;
                    StatusLabel.BackColor=System.Drawing.Color.LightGreen;

                }
                else if (StatusLabel.Text.Trim()=="FAIL")
                {
                    StatusLabel.ForeColor=System.Drawing.Color.DarkRed;
                    StatusLabel.BackColor=System.Drawing.Color.LightPink;
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{errorMessage}'); window.location.href = window.location.href;", true);
            }



        }


    }
}
