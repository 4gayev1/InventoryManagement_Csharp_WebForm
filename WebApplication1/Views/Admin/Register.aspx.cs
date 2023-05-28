using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Register : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           

            try
            {
                if (txtUserName.Text == "" || txtPassword.Text == "")
                {
                    lblerror.Text = "Məlumatlar Yetərsizdir!";
                }
                else
                {
                    string Username = txtUserName.Text;
                    string Password = Con.MD5Hash(txtPassword.Text);

                    string Query = "insert into Login values('{0}','{1}')";
                    Query = string.Format(Query, Username, Password);
                    Con.setData(Query);

                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception Ex)
            {
               // lblerror.InnerText = Ex.Message;
            }
         
        }

     
    }
}