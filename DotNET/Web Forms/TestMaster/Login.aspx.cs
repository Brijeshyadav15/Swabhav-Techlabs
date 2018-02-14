using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {      
    }

    protected void BtnLoginClicked(object sender, EventArgs e)
    {

        if (txtUser.Text == "Admin" && txtPassword.Text == "Admin123" && this.IsPostBack)
        {
            Session["UserID"] = 1;
            Session["UserName"] = txtUser.Text;
            Response.Redirect(Request.QueryString["returnUrl"].ToString());
        }
    }
}