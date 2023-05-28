using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Supplier : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Con = new Models.Functions();
                ShowSuppliers();
            }

        }

        private void ShowSuppliers()
        {
            string Query = "Select * from SupplierTbl";
            SuppliersList.DataSource = Con.GetData(Query);
            SuppliersList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(SupNameTb.Value == "" || SupAddTb.Value == "" || SupEmailTb.Value == "" || SupPhoneTb.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string SName = SupNameTb.Value;
                    string SAdd= SupNameTb.Value;
                    string SEmail = SupNameTb.Value;
                    string SPhone = SupNameTb.Value;

                    string Query = "insert into SupplierTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query,SName, SAdd, SEmail, SPhone);
                    Con.setData(Query);
                    ShowSuppliers();
                    Errmsg.InnerText = "Əlavə edildi";

                }
            }
            catch (Exception Ex){
                Errmsg.InnerText = Ex.Message;
            }

        }

        int Key = 0;
        protected void SuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupNameTb.Value = SuppliersList.SelectedRow.Cells[2].Text;
            SupAddTb.Value = SuppliersList.SelectedRow.Cells[3].Text;
            SupEmailTb.Value = SuppliersList.SelectedRow.Cells[4].Text;
            SupPhoneTb.Value = SuppliersList.SelectedRow.Cells[5].Text;

            if (SupNameTb.Value == ""){
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SuppliersList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SupNameTb.Value == "" || SupAddTb.Value == "" || SupEmailTb.Value == "" || SupPhoneTb.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string SName = SupNameTb.Value;
                    string SAdd = SupNameTb.Value;
                    string SEmail = SupNameTb.Value;
                    string SPhone = SupNameTb.Value;

                    string Query = "update  SupplierTbl set SupName = '{0}',SupAddress='{1}',SupEmail='{2}',SupPhone='{3}' where SupCode={4}";
                    Query = string.Format(Query, SName, SAdd, SEmail, SPhone,SuppliersList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowSuppliers();
                    Errmsg.InnerText = "Dəyişikliklər yadda saxlanıldı";

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
                if (SupNameTb.Value == "" || SupAddTb.Value == "" || SupEmailTb.Value == "" || SupPhoneTb.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string SName = SupNameTb.Value;
                    string SAdd = SupNameTb.Value;
                    string SEmail = SupNameTb.Value;
                    string SPhone = SupNameTb.Value;

                    string Query = "delete from SupplierTbl where SupCode={0}";
                    Query = string.Format(Query, SuppliersList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowSuppliers();
                    Errmsg.InnerText = "Silindi";

                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }
    }
}