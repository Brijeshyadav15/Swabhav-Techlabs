using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridDataApp
{
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            InitializeComponent();
        }

        private void frmGrid_Load(object sender, EventArgs e)
        {

        }

        private void btn_Populate_Click(object sender, EventArgs e)
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["developmentserver"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlDataAdapter custAdapter = new SqlDataAdapter("SELECT * FROM EMP", conn);
            DataSet ds = new DataSet("EMPS");
            custAdapter.Fill(ds);
            empGrid.DataSource = ds.Tables[0];

            custAdapter = new SqlDataAdapter("SELECT * FROM DEPT", conn);
            ds = new DataSet("Dept");
            custAdapter.Fill(ds);
            deptGrid.DataSource =ds.Tables[0];

        }
    }
}
