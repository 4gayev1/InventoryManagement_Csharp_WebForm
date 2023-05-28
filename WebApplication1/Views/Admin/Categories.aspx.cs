using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
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
            ShowCategories();


            }
        }

        private void ShowCategories()
        {
            string Query = "Select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();
        }

        private void EmptyInputField()
        {
            CatNameTb.Value = "";
        }


        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" )
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string CatName = CatNameTb.Value;


                    string Query = "insert into CategoryTbl values('{0}')";
                    Query = string.Format(Query, CatName);
                    Con.setData(Query);
                    ShowCategories();
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
                if (CatNameTb.Value == "" )
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string CatName = CatNameTb.Value;


                    string Query = "delete from CategoryTbl where CatCode={0}";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowCategories();
                    Errmsg.InnerText = "Silindi";
                    EmptyInputField();

                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == "" )
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string CatName = CatNameTb.Value;

                    
                    string Query = "update  CategoryTbl set CatName='{0}' where CatCode='{1}'";
                    Query = string.Format(Query, CatName, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowCategories();
                    Errmsg.InnerText = "Dəyişikliklər yadda saxlanıldı";
                    EmptyInputField();

                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void CategoriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatNameTb.Value = CategoriesList.SelectedRow.Cells[2].Text;


            if (CatNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }
        }
    }
}