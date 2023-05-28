using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views.Admin
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                lblusername.Text = Session["user"].ToString();
              
            }
            else
            {
                UserInfo.Visible = false;
                LogOutDiv.Visible = false;
            }
        }

        protected void LogOutBtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}