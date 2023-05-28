using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Employee : System.Web.UI.Page
    {
        Models.Functions Con;
        int Key = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
      
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Con = new Models.Functions();
                ShowEmployee();
            }
        }



        private void ShowEmployee()
        {
            string Query = "Select * from EmployeeTbl";
            EmployeeList.DataSource = Con.GetData(Query);
            EmployeeList.DataBind();

        }

        private void EmptyInputField()
        {
            EmployeeNameTb.Value = "";
            EmployeePhoneTb.Value = "";
            EmployeePassTb.Value = "";
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameTb.Value == "" || EmployeePhoneTb.Value == "" || EmployeePassTb.Value == "" )
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string EmpName = EmployeeNameTb.Value;
                    string EmpPhone = EmployeePhoneTb.Value;
                    string EmpPass = EmployeePassTb.Value;

                    string Query = "update  EmployeeTbl set EmpName = '{0}',EmpPhone='{1}',EmpPass='{2}' where EmpCOde={3}";
                    Query = string.Format(Query, EmpName, EmpPhone, EmpPass, EmployeeList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowEmployee();
                    Errmsg.InnerText = "Dəyişikliklər yadda saxlanıldı";
                    EmptyInputField();


                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameTb.Value == "" || EmployeePhoneTb.Value == "" || EmployeePassTb.Value == "" )
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string EmpName = EmployeeNameTb.Value;
                    string EmpPhone = EmployeePhoneTb.Value;
                    string EmpPass = EmployeePassTb.Value;

                    string Query = "insert into EmployeeTbl values('{0}','{1}','{2}')";
                    Query = string.Format(Query, EmpName, EmpPhone, EmpPass);
                    Con.setData(Query);
                    ShowEmployee();
                    Errmsg.InnerText = "Əlavə edildi";
                    EmptyInputField();

                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameTb.Value == "" || EmployeePhoneTb.Value == "" || EmployeePassTb.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string EmpName = EmployeeNameTb.Value;
                    string EmpPhone = EmployeePhoneTb.Value;
                    string EmpPass = EmployeePassTb.Value;

                    string Query = "delete from EmployeeTbl where EmpCOde={0}";
                    Query = string.Format(Query, EmployeeList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowEmployee();
                    Errmsg.InnerText = "Silindi";

                    EmptyInputField();

                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeNameTb.Value = EmployeeList.SelectedRow.Cells[2].Text;
            EmployeePhoneTb.Value = EmployeeList.SelectedRow.Cells[3].Text;
            EmployeePassTb.Value = EmployeeList.SelectedRow.Cells[4].Text;

            if (EmployeeNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EmployeeList.SelectedRow.Cells[1].Text);
            }
        }
    }
}