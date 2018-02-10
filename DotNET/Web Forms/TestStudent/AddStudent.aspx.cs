using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentCore;

public partial class AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["Username"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }

    protected void AddStudentBtn_Click(object sender, EventArgs e)
    {
        StudentService service = new StudentService();
        List<Student> studentlist;

        if (service.GetStudents().Count > 0)
            studentlist = service.GetStudents();
        else
            studentlist = new List<Student>();

        Student student = new Student(Convert.ToInt32(IdTxt.Text), NameTxt.Text, Convert.ToInt32(AgeTxt.Text), LocationTxt.Text);
        studentlist.Add(student);
        service.Save(studentlist);
        Response.Redirect("DisplayStudents.aspx");
    }
}