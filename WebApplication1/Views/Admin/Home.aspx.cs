using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1.Views.Admin
{

    public partial class Home : System.Web.UI.Page
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
                ShowEmployeesCnt();
                ShowCategoriesCnt();
                ShowItemsCnt();
                ShowSuplliersCnt();
            }
        }

        private void ShowEmployeesCnt()
        {

            DataTable  dt = new DataTable();
            string Query = "Select Count(*) from EmployeeTbl";
            SqlDataAdapter  sda = new SqlDataAdapter(Query, "Data Source=Aghayev-Desktop;Initial Catalog=İnventoryManagementWeb;Integrated Security=True");
            sda.Fill(dt);
            EmployeeCnt.InnerText = dt.Rows[0][0].ToString();

            

        }


        private void ShowCategoriesCnt()
        {

            DataTable dt = new DataTable();
            string Query = "Select Count(*) from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, "Data Source=Aghayev-Desktop;Initial Catalog=İnventoryManagementWeb;Integrated Security=True");
            sda.Fill(dt);
            CategoriesCnt.InnerText = dt.Rows[0][0].ToString();



        }

        private void ShowItemsCnt()
        {

            DataTable dt = new DataTable();
            string Query = "Select Count(*) from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, "Data Source=Aghayev-Desktop;Initial Catalog=İnventoryManagementWeb;Integrated Security=True");
            sda.Fill(dt);
            ItemsCnt.InnerText = dt.Rows[0][0].ToString();



        }

        private void ShowSuplliersCnt()
        {

            DataTable dt = new DataTable();
            string Query = "Select Count(*) from SupplierTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, "Data Source=Aghayev-Desktop;Initial Catalog=İnventoryManagementWeb;Integrated Security=True");
            sda.Fill(dt);
            SuppliersCnt.InnerText = dt.Rows[0][0].ToString();



        }


        protected void Unnamed1_Click(object sender, EventArgs e)
        {

        }

        protected void EmployeeBtn_Click(object sender, EventArgs e)
        {
            
        }

        protected void CategoriesBtn_Click(object sender, EventArgs e)
        {

        }

        protected void SupllierBtn_Click(object sender, EventArgs e)
        {

        }

        protected void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}