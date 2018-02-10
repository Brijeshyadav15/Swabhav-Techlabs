using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentCore;

public partial class SearchStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void SearchStudentBtn_Click(object sender, EventArgs e)
    {

        StudentService service = new StudentService();
        ResultsGrid.DataSource = service.Search(s => s.Name.Contains(NameTxt.Text));
        ResultsGrid.DataBind();
    }
}