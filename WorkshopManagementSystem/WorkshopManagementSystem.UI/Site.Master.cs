using System;
using System.Web.UI;

namespace WorkshopManagementSystem
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bool isLoggedIn = Session["UserID"] != null;

                liRegister.Visible = !isLoggedIn;
                liLogin.Visible = !isLoggedIn;
                liLogout.Visible = isLoggedIn;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }
    }
}
