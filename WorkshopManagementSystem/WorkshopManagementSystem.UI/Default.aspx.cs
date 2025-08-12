using System;
using WorkshopManagementSystem.BLL;
using System.Web.UI.WebControls;

namespace WorkshopManagementSystem.UI
{
    public partial class Default : System.Web.UI.Page
    {
        private WorkshopService _wService = new WorkshopService();
        private RegistrationService _regService = new RegistrationService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) BindWorkshops();
        }

        private void BindWorkshops()
        {
            rptWorkshops.DataSource = _wService.GetAllWorkshops();
            rptWorkshops.DataBind();
        }

        protected void rptWorkshops_Command(object source, CommandEventArgs e)
        {
            if (e.CommandName == "Register")
            {
                if (Session["UserID"] == null)
                {
                    Response.Redirect("~/Login.aspx");
                    return;
                }

                int userId = Convert.ToInt32(Session["UserID"]);
                int workshopId = Convert.ToInt32(e.CommandArgument);

                bool ok = _regService.RegisterForWorkshop(userId, workshopId);
                if (ok)
                {
                    // optional: show message
                    BindWorkshops(); // refresh
                }
                else
                {
                    // could be duplicate or full
                    Response.Write("<script>alert('Registration failed - maybe already registered or full.');</script>");
                }
            }
        }
    }
}
