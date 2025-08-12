using System;
using WorkshopManagementSystem.BLL;

namespace WorkshopManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = _userService.AuthenticateUser(email, password);

            if (user != null)
            {
                Session["UserID"] = user.UserID;
                Session["Role"] = user.Role;
                Session["FullName"] = user.FullName;

                Response.Redirect("Default.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invalid email or password');</script>");
            }
        }
    }
}
