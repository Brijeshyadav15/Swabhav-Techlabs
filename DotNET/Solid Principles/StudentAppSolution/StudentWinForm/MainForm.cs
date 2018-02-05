using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using StudentCore;

namespace StudentWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridStudents.Rows.Clear();
            StudentService service = new StudentService();
            foreach (Student student in service.GetStudents())
            {
                this.GridStudents.Rows.Add(student.Id, student.Name, student.Age, student.Location);
            }
            GridStudents.RowHeadersVisible = false;
            GridStudents.AllowUserToAddRows = false;
            GridStudents.Columns[0].Width = 100;
            GridStudents.Columns[1].Width = 150;
            GridStudents.Columns[2].Width = 150;
            GridStudents.Columns[3].Width = 150;
            //this.GridStudents.Rows.Add(service.GetStudents().Count, "Brijesh", "22", "Mumbai");
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new AddStudent().Show();
        }

        private void GridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
