using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BlogPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Message.Text = "Enter Message";

        if (!this.IsPostBack)
        {
            MessageList.Items.Add(new ListItem("Hello, World"));
            MessageList.Items.Add(new ListItem("Hello, India"));
            MessageList.Items.Add(new ListItem("Hello, Mumbai"));
        }
    }

    protected void AddToList(object sender, EventArgs e)
    {
        string message = "Hello," + MessageBox.Text;

        MessageList.Items.Add(new ListItem(message));
        Button b = new Button();
        b.Text = "X";

    }

    protected void Delete(object sender, EventArgs e)
    {
        MessageList.Items.Remove(MessageList.SelectedItem);
    }

    protected void Clear(object sender, EventArgs e)
    {
        MessageList.Items.Clear();
    }


}