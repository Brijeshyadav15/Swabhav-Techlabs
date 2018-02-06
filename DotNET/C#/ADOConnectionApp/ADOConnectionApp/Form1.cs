using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ADOConnectionApp
{
    public partial class frmOrganizers : Form
    {
        string connstr = .Utility.GetConnectionString();

        public frmOrganizers()
        {
            InitializeComponent();
        }

        private void frmOrganizers_Load(object sender, EventArgs e)
        {

        }
    }
}
