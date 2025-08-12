using System;
using WorkshopManagementSystem.BLL;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem
{
    public partial class Register : System.Web.UI.Page
    {
        private readonly UserService _userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Example roles
                ddlRole.Items.Clear();
                ddlRole.Items.Add("User");
                ddlRole.Items.Add("Admin");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            int role = Convert.ToInt32(ddlRole.SelectedValue);

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                // You can use a label for showing error messages
                Response.Write("<script>alert('Please fill in all fields.');</script>");
                return;
            }

            bool success = _userService.RegisterUser(fullName, email, password, role);

            if (success)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("<script>alert('Registration failed. Try again.');</script>");
            }
        }
    }
}
