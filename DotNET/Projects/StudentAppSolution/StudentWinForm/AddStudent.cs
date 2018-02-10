using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StudentCore;

namespace StudentWinForm
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentService service = new StudentService();
            List<Student> studentlist;

            if (service.GetStudents().Count > 0)
                studentlist = service.GetStudents();
            else
                studentlist = new List<Student>();

            Student student = new Student(Convert.ToInt32(TxtId.Text), TxtName.Text, Convert.ToInt32(TxtAge.Text), TxtLocation.Text);
            studentlist.Add(student);
            service.Save(studentlist);
            this.Visible = false;
            new MainForm().Show();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            String name = new LoginForm().Username;
            lblWelcomeMessage.Text += name;
        }
    }
}
