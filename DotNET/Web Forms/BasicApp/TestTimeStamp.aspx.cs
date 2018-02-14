using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class TestTimeStamp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Timestamp1.BorderColor = BorderColour.RED;
        //Timestamp2.BorderColor = BorderColour.RED;
    }
}

public enum BorderColour
{
    RED, GREEN, BLUE, WHITE, BLACK, YELLOW
}

