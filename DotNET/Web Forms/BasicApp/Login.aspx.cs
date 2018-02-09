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

    protected void LoginClick(object sender, EventArgs e)
    {
        if (UserNameTxt.Text == "Admin" && PasswordTxt.Text == "admin123")
        {
            //Server.Transfer("welcome.aspx?username=" + UserNameTxt.Text);
            Response.Redirect("welcome.aspx?username=" + UserNameTxt.Text);
        }
    }

}