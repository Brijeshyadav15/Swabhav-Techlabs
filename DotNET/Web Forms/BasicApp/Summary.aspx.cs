using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Summary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SessionLbl.Text += Session["Count"];
        ApplicationLbl.Text += Application["Count"];
        IdLbl.Text += Session.SessionID;

    }
}