using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestGrid : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void PopulateGrid(object sender, EventArgs e)
    {
        var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand fetchCommand = new SqlCommand("Select * from EMP", conn);
        SqlDataReader reader = fetchCommand.ExecuteReader();
        EmpGrid.DataSource = reader;
        EmpGrid.DataBind();
    }
}