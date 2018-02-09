using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridApp
{
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            empGrid.Visible = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPopulate_Click(object sender, EventArgs e)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter custAdapter = new SqlDataAdapter("SELECT * FROM EMP", conn);
            DataSet ds = new DataSet("EMPS");
            custAdapter.Fill(ds);
            empGrid.Visible = true;
            empGrid.DataSource = ds.Tables[0];
            //empGrid.DataMember = "EMP";
            //empGrid.Visible = true;
        }
    }
}
