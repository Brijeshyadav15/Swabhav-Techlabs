using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Timestamp : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTimestamp.Text = DateTime.Now.ToString("hh:mm:ss tt");
    }

    public Color BorderColor
    {
        get
        {
            return lblTimestamp.BorderColor;
        }
        set
        {
            var temp = Color.FromName(value.ToString());
            lblTimestamp.BorderColor = temp;
        }
    }


}