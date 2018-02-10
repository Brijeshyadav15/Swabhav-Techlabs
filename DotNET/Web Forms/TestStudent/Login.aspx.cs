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
        if (Session["Username"] != null)
        {
            Session["Username"] = null;
        }
    }

    protected void LoginBtn_Click(object sender, EventArgs e)
    {
        if (UsernameTxt.Text == "admin" && PasswordTxt.Text == "admin123")
        {
            Session["Username"] = UsernameTxt.Text;
            Response.Redirect("Home.aspx");
        }

    }
}