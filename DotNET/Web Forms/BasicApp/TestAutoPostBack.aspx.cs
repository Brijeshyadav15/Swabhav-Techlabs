using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestAutoPostBack : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand fetchCommand = new SqlCommand("Select * from DEPT", conn);
            SqlDataReader reader = fetchCommand.ExecuteReader();

            DeptList.DataSource = reader;
            DeptList.DataTextField = "DNAME";
            DeptList.DataValueField = "DEPTNO";
            DeptList.DataBind();
            PopulateGrid(this, null);
        }
    }

    protected void PopulateGrid(object sender, EventArgs e)
    {

        var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        SqlCommand fetchCommand = new SqlCommand("Select * from EMP where DEPTNO =" + DeptList.SelectedValue + "", conn);
        SqlDataReader reader = fetchCommand.ExecuteReader();
        EmpGrid.DataSource = reader;
        EmpGrid.DataBind();
    }
}