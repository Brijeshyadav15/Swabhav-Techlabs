using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentCore;

public partial class Display : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Username"] == null)
        {
            Response.Redirect("login.aspx");
        }

        StudentService service = new StudentService();
        StudentsGrid.DataSource = service.GetStudents();
        StudentsGrid.DataBind();
    }
}