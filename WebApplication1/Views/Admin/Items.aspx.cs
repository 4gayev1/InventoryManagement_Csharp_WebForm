using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Items : System.Web.UI.Page
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
                    Suppliers();
                    Category();
                    ShowSuppliers();

                }
            

        }


        private void Suppliers()
        {
            string Query = "Select SupName from SupplierTbl";
            SupplierTb.DataValueField = "SupName";
            SupplierTb.DataTextField = "SupName";
            SupplierTb.DataSource = Con.GetData(Query);
            SupplierTb.DataBind();
        }

        private void Category()
        {
            string Query = "Select CatName from CategoryTbl";
            ItemCategoryTb.DataValueField = "CatName";
            ItemCategoryTb.DataTextField = "CatName";
            ItemCategoryTb.DataSource = Con.GetData(Query);
            ItemCategoryTb.DataBind();
        }

        private void ShowSuppliers()
        {
            string Query = "Select * from ItemTbl";
            ItemsList.DataSource = Con.GetData(Query);
            ItemsList.DataBind();
        }

        private void EmptyInputField()
        {
            ItemNameTb.Value = "";
            SupplierTb.SelectedItem.Value = "";
            QuantityTb.Value = "";
            MinimumLevelTb.Value = "";
            ItemCategoryTb.SelectedItem.Value = "";
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemNameTb.Value == "" || SupplierTb.SelectedItem.Value == "" || QuantityTb.Value == "" || MinimumLevelTb.Value == "" || ItemCategoryTb.SelectedItem.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string ItemName = ItemNameTb.Value;
                    string Supplier = SupplierTb.SelectedItem.Value;
                    string Quantity = QuantityTb.Value;
                    string MinimumLevel = MinimumLevelTb.Value;
                    string ItemCategory = ItemCategoryTb.SelectedItem.Value;

                    string Query = "update  ItemTbl set itName = '{0}',Supplier='{1}',Quantity='{2}',Level='{3}',Category='{4}' where itCOde={5}";
                    Query = string.Format(Query, ItemName, Supplier, Quantity, MinimumLevel, ItemCategory, ItemsList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowSuppliers();
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
                if (ItemNameTb.Value == "" || SupplierTb.SelectedItem.Value == "" || QuantityTb.Value == "" || MinimumLevelTb.Value == "" || ItemCategoryTb.SelectedItem.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string ItemName = ItemNameTb.Value;
                    string Supplier = SupplierTb.SelectedItem.Value;
                    string Quantity = QuantityTb.Value;
                    string MinimumLevel = MinimumLevelTb.Value;
                    string ItemCategory = ItemCategoryTb.SelectedItem.Value;

                    string Query = "insert into ItemTbl values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, ItemName, Supplier, Quantity, MinimumLevel, ItemCategory);
                    Con.setData(Query);
                    ShowSuppliers();
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
                if (ItemNameTb.Value == "" || SupplierTb.SelectedItem.Value == "" || QuantityTb.Value == "" || MinimumLevelTb.Value == "" || ItemCategoryTb.SelectedItem.Value == "")
                {
                    Errmsg.InnerText = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string ItemName = ItemNameTb.Value;
                    string Supplier = SupplierTb.SelectedItem.Value;
                    string Quantity = QuantityTb.Value;
                    string MinimumLevel = MinimumLevelTb.Value;
                    string ItemCategory = ItemCategoryTb.SelectedItem.Value;

                    string Query = "delete from ItemTbl where itCOde={0}";
                    Query = string.Format(Query, ItemsList.SelectedRow.Cells[1].Text);
                    Con.setData(Query);
                    ShowSuppliers();
                    Errmsg.InnerText = "Silindi";
                    EmptyInputField();


                }
            }
            catch (Exception Ex)
            {
                Errmsg.InnerText = Ex.Message;
            }
        }

        protected void Unnamed3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemNameTb.Value = ItemsList.SelectedRow.Cells[2].Text;
            SupplierTb.DataValueField = ItemsList.SelectedRow.Cells[3].Text;
            QuantityTb.Value = ItemsList.SelectedRow.Cells[4].Text;
            MinimumLevelTb.Value = ItemsList.SelectedRow.Cells[5].Text;
            ItemCategoryTb.DataValueField = ItemsList.SelectedRow.Cells[6].Text;


            if (ItemNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItemsList.SelectedRow.Cells[1].Text);
            }
        }
    }
}