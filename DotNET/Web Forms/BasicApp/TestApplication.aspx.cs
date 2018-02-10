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
        if (Application["Count"] == null)
        {
            Application["Count"] = 0;
        }

        OldLbl.Text += Application["Count"];
        Application["Count"] = Convert.ToInt32(Application["Count"]) + 1;
        NewLbl.Text += Application["Count"];
        IDLbl.Text += Application.Keys;

    }
}