using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BasicApp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Response.Write("<h1> Page Loaded </h1>");
            Response.Write("<h1> Get Method </h1>");
        }
        else
        {
            Response.Write("<h1> Page Loaded </h1>");
            Response.Write("<h1> Post Method </h1>");
        }
    }

    public void btnHello_click(Object Sender, EventArgs args)
    {
        String msg = "Hello " + txtName.Text;
        lblDisplay.Text = msg;
    }
}