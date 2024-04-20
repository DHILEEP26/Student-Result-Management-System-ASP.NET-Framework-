using Students_Record_Management_System.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Students_Record_Management_System
{
    public partial class About :System.Web.UI.Page
    {
        public int TotalStudents = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserRoll"]==null || Session["UserRoll"].ToString()!="Admin") 
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    LoadTS();
                    LoadPS();
                    LoadFS();
                    LoadData();
                    TamilAvg();
                    ENG_Avg();
                    MAT_Avg();
                    SCI_Avg();
                    SOC_Avg();
                }
            }

        }
        private void LoadTS()
        {
            DBClass dBClass = new DBClass();
            int total_Student =0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            if(dBClass.GetData(ref total_Student, "SP_GET_TOTAL_ST", parems,ref errorMessage))
            {
                TotalStudentsCountLabel.Text=total_Student.ToString();
                TotalStudents=total_Student;
            }
            else
            {
                string script =errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
        }
        private void LoadPS()
        {
            DBClass dBClass = new DBClass();
            int total_Student = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            if (dBClass.GetData(ref total_Student, "SP_GET_TOTAL_PS", parems, ref errorMessage))
            {
                PassStudentsCountLabel.Text=total_Student.ToString();
                
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
        }
        private void LoadFS()
        {
            DBClass dBClass = new DBClass();
            int total_Student = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            if (dBClass.GetData(ref total_Student, "SP_GET_TOTAL_FS", parems, ref errorMessage))
            {
                FailStudentsCountLabel.Text=total_Student.ToString();
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }
        }
        private void TamilAvg()
        {
            DBClass dBClass = new DBClass();
            int total_Tamil_marks = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            int Tamil_Avg = 0;
            if (dBClass.GetData(ref total_Tamil_marks, "SP_GET_AVG_TAMILMARK", parems, ref errorMessage))
            {
                Tamil_Avg=total_Tamil_marks/TotalStudents;
                TamilAverage.Text=Tamil_Avg.ToString()+"%";
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }

        }

        private void ENG_Avg()
        {
            DBClass dBClass = new DBClass();
            int total_English_marks = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            int English_Avg = 0;
            if (dBClass.GetData(ref total_English_marks, "SP_GET_AVG_ENGMARK", parems, ref errorMessage))
            {
                English_Avg=total_English_marks/TotalStudents;
                EngAverage.Text=English_Avg.ToString()+"%";
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }

        }
        private void MAT_Avg()
        {
            DBClass dBClass = new DBClass();
            int total_Maths_marks = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            int Maths_Avg = 0;
            if (dBClass.GetData(ref total_Maths_marks, "SP_GET_AVG_MATMARK", parems, ref errorMessage))
            {
                Maths_Avg=total_Maths_marks/TotalStudents;
                MathsAvg.Text=Maths_Avg.ToString()+"%";
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }

        }
        private void SCI_Avg()
        {
            DBClass dBClass = new DBClass();
            int total_marks = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            int Avg = 0;
            if (dBClass.GetData(ref total_marks, "SP_GET_AVG_SCIMARK", parems, ref errorMessage))
            {
                Avg=total_marks/TotalStudents;
                ScienceAvg.Text=Avg.ToString()+"%";
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }

        }
        private void SOC_Avg()
        {
            DBClass dBClass = new DBClass();
            int total_marks = 0;
            var parems = new string[2];
            parems[0]="1";
            parems[1]="1";
            var errorMessage = "";
            int Avg = 0;
            if (dBClass.GetData(ref total_marks, "SP_GET_AVG_SOCMARK", parems, ref errorMessage))
            {
                Avg=total_marks/TotalStudents;
                SociAvg.Text=Avg.ToString()+"%";
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
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
            if (dbClass.GetTableData(ref dataSet, "SP_GET_TEACHER_LIST", parems, ref errorMessage))
            {
                GridView1.DataSource=dataSet.Tables[0];
                GridView1.DataBind();
            }
            else
            {
                string script = errorMessage;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", script, true);
            }


        }


    }
}