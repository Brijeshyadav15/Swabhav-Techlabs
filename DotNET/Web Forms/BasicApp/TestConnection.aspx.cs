using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestConnection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ConnectToDB(object sender, EventArgs e)
    {
        var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;


        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        InfoLabel.Text = "Connection State :" + conn.State.ToString() + "<br>";
        InfoLabel.Text += "Server Version :" + conn.ServerVersion + "<br>";
        InfoLabel.Text += "Packet Size :" + conn.PacketSize + "<br>";
        InfoLabel.Text += "Statistics Enabled :" + conn.StatisticsEnabled + "<br>";
        InfoLabel.Text += "Workstation Id :" + conn.WorkstationId + "<br>";
        InfoLabel.Text += "DataSource :" + conn.DataSource + "<br>";
        InfoLabel.Text += "Database :" + conn.Database + "<br>";
        InfoLabel.Text += "ConnectionString :" + conn.ConnectionString + "<br>";




    }
}