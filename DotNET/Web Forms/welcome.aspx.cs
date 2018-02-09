using System;

public partial class welcome : System.Web.UI.Page
{
    public void Page_Load(Object Sender, EventArgs args)
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
