using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestSession : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Count"] == null)
        {
            Session["Count"] = 0;
        }

        OldLbl.Text += Session["Count"];
        Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;
        NewLbl.Text += Session["Count"];
        IDLbl.Text += Session.SessionID;

    }
}