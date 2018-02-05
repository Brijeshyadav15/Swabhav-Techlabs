﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentCore;

namespace StudentWinForm
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.ResultGrid.Hide();
            ResultGrid.Columns[0].Width = 100;
            ResultGrid.Columns[1].Width = 200;
            ResultGrid.Columns[2].Width = 150;
            ResultGrid.Columns[3].Width = 150;
            ResultGrid.RowHeadersVisible = false;
            ResultGrid.AllowUserToAddRows = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResultGrid.Rows.Clear();
            StudentService service = new StudentService();
            
            List<Student> results = service.Search(Convert.ToInt32(txtId.Text), txtName.Text, Convert.ToInt32(txtAge.Text), txtLocation.Text);

            if (results.Count > 0)
            {
                //MessageBox.Show("No of Students :" + results.Count);
                foreach (Student student in results)
                {
                    ResultGrid.Show();
                    this.ResultGrid.Rows.Add(student.Id, student.Name, student.Age, student.Location);
                }
            }
        }
    }
}