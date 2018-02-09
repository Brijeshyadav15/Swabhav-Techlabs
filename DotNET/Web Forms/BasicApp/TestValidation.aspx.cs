using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestValidation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void registerBtn_Click(object sender, EventArgs e)
    {
        
            ResponseLbl.Text = "<h3> Registration Successful </h1>";
            ResponseLbl.Text += "<h3> Name  :" + NameTxt.Text + "</h1>";
            ResponseLbl.Text += "<h3> Age :" + AgeTxt.Text + "</h1>";
            ResponseLbl.Text += "<h3> Salary :" + SalaryTxt.Text + "</h1>";
            ResponseLbl.Text += "<h3> Email :" + EmailTxt.Text + "</h1>";
    }
}