using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        static SqlConnection sqlcon = new SqlConnection(@"Data Source=Aghayev-Desktop;Initial Catalog=İnventoryManagementWeb;Integrated Security=True");
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                string Username = txtUserName.Text;
                string Password = Con.MD5Hash(txtPassword.Text);

                sqlcon.Open();
                string checkquery = "Select count(1) from Login where Username='" + txtUserName.Text + "' and Password='" + Con.MD5Hash(txtPassword.Text.Trim()) + "'";
                SqlCommand cmd = new SqlCommand(checkquery, sqlcon);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    //lblerror.Text = "login Successful!";

                    Session["user"] = txtUserName.Text.Trim();
                    Response.Redirect("Home.aspx");

                }
                else
                {
                    lblerror.Text = "Login Failed. Incorrect Username or Password!";
                }
            }
            catch (Exception ex) { }
            finally { sqlcon.Close(); }

        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        


    }
}